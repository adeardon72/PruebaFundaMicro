@ModelType IEnumerable(Of WebFundaMicro.THE_USERS)
@Code
ViewData("Title") = "Index"
Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.THE_PSW)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.NAME)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.LASTNAME)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.THE_PSW)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.NAME)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.LASTNAME)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.THE_USER }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.THE_USER }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.THE_USER })
        </td>
    </tr>
Next

</table>
