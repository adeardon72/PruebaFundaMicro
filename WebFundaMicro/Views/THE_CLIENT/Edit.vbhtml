@ModelType WebFundaMicro.THE_CLIENT
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>THE_CLIENT</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        @Html.HiddenFor(Function(model) model.ID_CLIENT)

        <div class="form-group">
            @Html.LabelFor(Function(model) model.NAME, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.NAME, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.NAME, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.LASTNAME, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.LASTNAME, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.LASTNAME, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.CRUD_ACTION, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.CRUD_ACTION)
                <!--
    @Html.EditorFor(Function(model) model.CRUD_ACTION, New With { .htmlAttributes = New With { .class = "form-control" } })
    @Html.ValidationMessageFor(Function(model) model.CRUD_ACTION, "", New With { .class = "text-danger" })
        -->
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.USR_CRUD_ACTION, "USR_CRUD_ACTION", htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DisplayFor(Function(model) model.USR_CRUD_ACTION)
                <!--
    @Html.DropDownList("USR_CRUD_ACTION", Nothing, htmlAttributes:=New With {.class = "form-control"})
    @Html.ValidationMessageFor(Function(model) model.USR_CRUD_ACTION, "", New With {.class = "text-danger"})
        -->
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.DATE_ACTION, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                
                @Html.DisplayFor(Function(model) model.DATE_ACTION)
                <!--
    @Html.EditorFor(Function(model) model.DATE_ACTION, New With {.htmlAttributes = New With {.class = "form-control"}})
    @Html.ValidationMessageFor(Function(model) model.DATE_ACTION, "", New With {.class = "text-danger"})
        -->
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
