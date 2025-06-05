@ModelType WebFundaMicro.THE_USERS
@Code
    ViewData("Title") = "Delete"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>THE_USERS</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.THE_PSW)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.THE_PSW)
        </dd>

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

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
