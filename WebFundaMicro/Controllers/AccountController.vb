Imports System.Web.Mvc



Public Class AccountController
    Inherits Controller

    Private db As New THE_USERSEntities()

    ' GET: /Account/Login
    Function Login() As ActionResult
        Return View()
    End Function

    ' POST: /Account/Login
    <HttpPost>
    <ValidateAntiForgeryToken>
    Function Login(model As UserLogin) As ActionResult
        If ModelState.IsValid Then
            Dim user = db.THE_USERS.FirstOrDefault(Function(u) u.THE_USER = model.THE_USER AndAlso u.THE_PSW = model.THE_PSW)

            If user IsNot Nothing Then
                ' Autenticación simple (se recomienda usar Identity o JWT para producción)
                Session("User") = user.THE_USER
                Return RedirectToAction("Index", "Home")
            Else
                ModelState.AddModelError("", "Usuario o contraseña incorrectos.")
            End If
        End If
        Return View(model)
    End Function

    Function Logout() As ActionResult
        Session.Abandon()
        Return RedirectToAction("Login")
    End Function
End Class
