﻿var user = user || {};

user.block = function (id, invoker) {
    $.ajax({
        url: "/api/services/user/block",
        dataType: "json",
        method: "POST",
        data: { id: id },
        success: function () {
            invoker.closest('tr').remove();
        }
    });
}

user.update = function (formId, returnUrl) {
    var postData = objectifyForm(formId);
    $.ajax({
        url: "/api/services/user/update",
        dataType: "json",
        contentType: "application/json",
        method: "PUT",
        data: JSON.stringify(postData),
        success: function () {
            window.location.href = returnUrl;
        }
    });
}