@ModelType IEnumerable(Of WebFundaMicro.THE_USERS)
@Code
    ViewBag.Title = "Iniciar Sesión"

    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>
    @ViewBag.Title
    
</h2>
<p>
    @Html.ActionLink("Login", "Login")
</p>
@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <div class="form-group">
            @Html.Label("Nombre de usuario")
            @Html.TextBox("username", "", New With {.class = "form-control"})
        </div>

        <div class="form-group">
            @Html.Label("Contraseña")
            @Html.Password("password", "", New With {.class = "form-control"})
        </div>


        <button type="submit" class="btn btn-primary">Iniciar sesión</button>
        <div Class="text-danger mt-2">
            @If ViewBag.ErrorMessage IsNot Nothing Then
                @ViewBag.ErrorMessage
            End If
        </div>
    </div>


End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section







