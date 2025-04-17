$(document).ready(function () {

    $("#txtProduct").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: '/Product/Fn_Get_GlobalSearch',
                type: "POST",
                dataType: "json",
                data: { Prefix: request.term },
                success: function (data) {
                    var obj = JSON.parse(data.message)
                    response($.map(obj, function (item) {
                        return { label: item.SearchKeyword, value: item.SearchKeyword };
                    }));
                }
            });
        },
        select: function (event, ui) {
            var str = ui.item.value;
            var vList = str.split("--");
            sessionStorage.setItem("SearchKeyword", vList[0]);
            sessionStorage.setItem("SearchField", vList[1]);

        }
    });
});