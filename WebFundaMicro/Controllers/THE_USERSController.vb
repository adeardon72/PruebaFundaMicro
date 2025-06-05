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
    Public Class THE_USERSController
        Inherits System.Web.Mvc.Controller

        Private db As New DB_FundaMicroEntities1

        ' GET: THE_USERS
        Function Index() As ActionResult
            Return View(db.THE_USERS.ToList())
        End Function

        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Login(username As String, password As String) As ActionResult
            ' Check against the the_users table using real field names
            Dim user = db.THE_USERS.FirstOrDefault(Function(u) u.THE_USER = username AndAlso u.THE_PSW = password)

            If user IsNot Nothing And False Then
                Session("LoggedInUser") = user
                Return RedirectToAction("Index", "Home")
            End If

            ViewBag.ErrorMessage = "Invalid login"
            Return View()
        End Function


        ' GET: THE_USERS/Details/5
        Function Details(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_USERS As THE_USERS = db.THE_USERS.Find(id)
            If IsNothing(tHE_USERS) Then
                Return HttpNotFound()
            End If
            Return View(tHE_USERS)
        End Function

        ' GET: THE_USERS/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: THE_USERS/Create
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="THE_USER,THE_PSW,NAME,LASTNAME")> ByVal tHE_USERS As THE_USERS) As ActionResult
            If ModelState.IsValid Then
                db.THE_USERS.Add(tHE_USERS)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tHE_USERS)
        End Function

        ' GET: THE_USERS/Edit/5
        Function Edit(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_USERS As THE_USERS = db.THE_USERS.Find(id)
            If IsNothing(tHE_USERS) Then
                Return HttpNotFound()
            End If
            Return View(tHE_USERS)
        End Function

        ' POST: THE_USERS/Edit/5
        'To protect from overposting attacks, enable the specific properties you want to bind to, for 
        'more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="THE_USER,THE_PSW,NAME,LASTNAME")> ByVal tHE_USERS As THE_USERS) As ActionResult
            If ModelState.IsValid Then
                db.Entry(tHE_USERS).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(tHE_USERS)
        End Function

        ' GET: THE_USERS/Delete/5
        Function Delete(ByVal id As String) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tHE_USERS As THE_USERS = db.THE_USERS.Find(id)
            If IsNothing(tHE_USERS) Then
                Return HttpNotFound()
            End If
            Return View(tHE_USERS)
        End Function

        ' POST: THE_USERS/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As String) As ActionResult
            Dim tHE_USERS As THE_USERS = db.THE_USERS.Find(id)
            db.THE_USERS.Remove(tHE_USERS)
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
