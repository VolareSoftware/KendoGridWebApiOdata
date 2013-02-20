$(function () {
    var dataSource = new kendo.data.DataSource({
        type: "odata",
        transport: {
            read: {
                url: "/api/Cats",
                dataType: "json"
            },
        },
        schema: {
            data: function (data) {
                return data["value"];
            },
            total: function (data) {
                return data["odata.count"];
            },
            model: {
                fields: {
                    Id: { type: "number" },
                    Name: { type: "string" },
                    Color: { type: "string" }
                }
            }
        },
        pageSize: 10,
        serverPaging: true,
        serverFiltering: true,
        serverSorting: true
    });

    $("#grid").kendoGrid({
        dataSource: dataSource,
        filterable: true,
        sortable: true,
        pageable: true,
        columns: [
            { field: "Id" },
            { field: "Name" },
            { field: "Color" }
        ]
    });
});