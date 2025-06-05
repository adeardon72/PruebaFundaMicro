@ModelType WebFundaMicro.THE_CLIENT
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.ID_CLIENT }) |
    @Html.ActionLink("Back to List", "Index")
</p>
