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

    <ul class="navbar-nav">
        @If Session("LoggedInUser") IsNot Nothing Then
            Dim user = CType(Session("LoggedInUser"), WebFundaMicro.THE_USERS)
            @<li class="nav-item"><span class="nav-link text-light">Hola, @user.THE_USER</span></li>
            @<li class="nav-item">@Html.ActionLink("Cerrar sesión", "Logout", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})</li>
        Else
            @<li class="nav-item">@Html.ActionLink("Iniciar sesión", "Login", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})</li>
        End If
    </ul>

    <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-dark bg-dark">
        <div class="container">
            @Html.ActionLink("FundaMicro", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" title="Toggle navigation" aria-controls="navbarSupportedContent"
                    aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse d-sm-inline-flex justify-content-between">
                <ul class="navbar-nav flex-grow-1">                    
                    <li>@Html.ActionLink("Crear usuario", "Index", "THE_USERS", New With {.area = ""}, New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Clientes", "Index", "THE_CLIENT", New With {.area = ""}, New With {.class = "nav-link"})</li>
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
