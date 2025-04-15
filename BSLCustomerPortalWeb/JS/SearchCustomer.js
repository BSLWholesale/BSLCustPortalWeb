$(document).ready(function () {

    $("#txtCompanyName1").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: '/CustomerVisit/Fn_Get_SearchCustomerEmail',
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
            var vCustList = str.split("--");
        },
        open: function (event, ui) {
            $(".ui-autocomplete").css("z-index", "10000");
        },
        close: function (event, ui) {
            $(".ui-autocomplete").css("z-index", "");
        }
    });
});