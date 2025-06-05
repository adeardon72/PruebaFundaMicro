Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports WebFundaMicro

Namespace Controllers
    Public Class THE_CLIENTController
        Inherits System.Web.Mvc.Controller

        Private db As New DB_FundaMicroEntities1

        ' GET: THE_CLIENT
        Function Index() As ActionResult
            Dim tHE_CLIENT = db.THE_CLIENT.Include(Function(t) t.THE_USERS)
            Return View(tHE_CLIENT.ToList())
        End Function

        ' GET: THE_CLIENT/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_CLIENT As THE_CLIENT = db.THE_CLIENT.Find(id)
            If IsNothing(tHE_CLIENT) Then
                Return HttpNotFound()
            End If
            Return View(tHE_CLIENT)
        End Function

        ' GET: THE_CLIENT/Create
        Function Create() As ActionResult
            ViewBag.USR_CRUD_ACTION = New SelectList(db.THE_USERS, "THE_USER", "THE_PSW")
            Return View()
        End Function

        ' POST: THE_CLIENT/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="ID_CLIENT,NAME,LASTNAME,CRUD_ACTION,USR_CRUD_ACTION,DATE_ACTION")> ByVal tHE_CLIENT As THE_CLIENT) As ActionResult
            If ModelState.IsValid Then
                tHE_CLIENT.ID_CLIENT = Nothing
                tHE_CLIENT.DATE_ACTION = DateTime.Now
                tHE_CLIENT.CRUD_ACTION = "CREATE"
                tHE_CLIENT.USR_CRUD_ACTION = "aardon"

                db.THE_CLIENT.Add(tHE_CLIENT)

                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.USR_CRUD_ACTION = New SelectList(db.THE_USERS, "THE_USER", "THE_PSW", tHE_CLIENT.USR_CRUD_ACTION)
            Return View(tHE_CLIENT)
        End Function

        ' GET: THE_CLIENT/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_CLIENT As THE_CLIENT = db.THE_CLIENT.Find(id)
            If IsNothing(tHE_CLIENT) Then
                Return HttpNotFound()
            End If

            ViewBag.USR_CRUD_ACTION = New SelectList(db.THE_USERS, "THE_USER", "THE_PSW", tHE_CLIENT.USR_CRUD_ACTION)
            tHE_CLIENT.CRUD_ACTION = "UPDATE"

            Return View(tHE_CLIENT)
        End Function

        ' POST: THE_CLIENT/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="ID_CLIENT,NAME,LASTNAME,CRUD_ACTION,USR_CRUD_ACTION,DATE_ACTION")> ByVal tHE_CLIENT As THE_CLIENT) As ActionResult
            If ModelState.IsValid Then
                tHE_CLIENT.DATE_ACTION = DateTime.Now
                tHE_CLIENT.CRUD_ACTION = "UPDATE"
                tHE_CLIENT.USR_CRUD_ACTION = "aardon"

                db.Entry(tHE_CLIENT).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.USR_CRUD_ACTION = New SelectList(db.THE_USERS, "THE_USER", "THE_PSW", tHE_CLIENT.USR_CRUD_ACTION)
            Return View(tHE_CLIENT)
        End Function

        ' GET: THE_CLIENT/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_CLIENT As THE_CLIENT = db.THE_CLIENT.Find(id)
            If IsNothing(tHE_CLIENT) Then
                Return HttpNotFound()
            End If
            Return View(tHE_CLIENT)
        End Function

        ' POST: THE_CLIENT/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim tHE_CLIENT As THE_CLIENT = db.THE_CLIENT.Find(id)
            ' db.THE_CLIENT.Remove(tHE_CLIENT)
            If ModelState.IsValid Then
                tHE_CLIENT.DATE_ACTION = DateTime.Now
                tHE_CLIENT.CRUD_ACTION = "DELETE"
                tHE_CLIENT.USR_CRUD_ACTION = "aardon"

                db.Entry(tHE_CLIENT).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If


            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
