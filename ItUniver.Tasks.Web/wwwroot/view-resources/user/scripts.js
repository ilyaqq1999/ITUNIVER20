var user = user || {};

user.block = function (id, invoker) {
    $.ajax({
        url: "/api/services/user/block",
        dataType: "json",
        //contentType: "application/json",
        method: "POST",
        data: { id: id },//JSON.stringify({ id: id }),
        success: function () {
            //debugger;
            invoker.closest('tr').remove();
        }
    });
}

user.update = function (formId, returnUrl) {
    //debugger;
    var postData = objectifyForm(formId);
    $.ajax({
        url: "/api/services/user/update",
        dataType: "json",
        contentType: "application/json",
        method: "PUT",
        data: JSON.stringify(postData),
        success: function (data) {
            //debugger;
            window.location.href = returnUrl;
        }
    });
}