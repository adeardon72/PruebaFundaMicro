@ModelType WebFundaMicro.THE_CLIENT
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>THE_CLIENT</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.NAME)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.NAME)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.LASTNAME)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LASTNAME)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CRUD_ACTION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CRUD_ACTION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DATE_ACTION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DATE_ACTION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.THE_USERS.THE_PSW)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.THE_USERS.THE_PSW)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
