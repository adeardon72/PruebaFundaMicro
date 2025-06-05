@ModelType IEnumerable(Of WebFundaMicro.THE_CLIENT)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.NAME)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LASTNAME)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CRUD_ACTION)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DATE_ACTION)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.THE_USERS.THE_PSW)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NAME)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LASTNAME)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CRUD_ACTION)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DATE_ACTION)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.THE_USERS.THE_USER)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.ID_CLIENT }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.ID_CLIENT }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.ID_CLIENT })
        </td>
    </tr>
Next

</table>
