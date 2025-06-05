@ModelType WebFundaMicro.THE_USERS
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.THE_USER }) |
    @Html.ActionLink("Back to List", "Index")
</p>
