﻿@Imports WebFundaMicro
@Code
    Layout = Nothing
    Dim currentUser = TryCast(Session("LoggedInUser"), THE_USERS)
    Dim isAuthenticated As Boolean = currentUser IsNot Nothing

    ' Si la vista requiere autenticación y el usuario no ha iniciado sesión
    Dim loginRequired As Boolean = Not Request.Url.AbsolutePath.ToLower().Contains("/the_users/login")

    If Not isAuthenticated AndAlso loginRequired Then
        Response.Redirect(Url.Action("Login", "THE_USERS"))
    End If
End Code

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("FundaMicro", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">
                    <li class="nav-item">@Html.ActionLink("Crear usuario", "Index", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li class="nav-item">@Html.ActionLink("Clientes", "Index", "THE_CLIENT", New With {.area = ""}, New With {.class = "nav-link"})</li>
                </ul>

                <ul class="navbar-nav">
                    <li class="nav-item">
                        <span class="nav-link text-light">Hola</span>
                    </li>
                    <li class="nav-item">
                        @If isAuthenticated Then
                            @Html.ActionLink("Cerrar sesión", "Logout", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})

                        Else

                            @Html.ActionLink("Iniciar sesión", "Login", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})

                        End If
                    </li>

                </ul>
            </div>
        </div>
    </nav>

    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - Bienvenidos</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
