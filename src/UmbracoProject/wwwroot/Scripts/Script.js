
var alertEl;
var userNameEl;
var passwordEl;
var loginFormEl;

$(document).ready(function () {
    alertEl = $(".alert");
    userNameEl = $("#user-name");
    passwordEl = $("#password");
    loginFormEl = $("#login-form");

    loginFormEl.validate();

    $("#close-alert").click(function () {
        hideAlert(alertEl);
    });
    $("#login-button").click(login);
    $("#register-button").click(register);
});

function register(e) {
    if (!loginFormEl.valid()) {
        return;
    }

    var userName = userNameEl.val();
    var password = userNameEl.val();
    var registerUrl = "/api/account/Register";
    var userData = { email: userName, password: password }

    $.post(registerUrl, userData)
        .done(function (data) {
            var result = JSON.parse(data);
            if (result.ResultCode < 0) {
                showAlert(alertEl, "alert-warning", result.ResultMessage);
            } else {
                showAlert(alertEl, "alert-success", "Success user registered");
            }
        })
        .fail(alertError);
    e.preventDefault();
}

function login(e) {
    if (!loginFormEl.valid()) {
        return;
    }

    var userName = userNameEl.val();
    var password = userNameEl.val();
    var loginUrl = "/api/account/login";
    var userData = { userName: userName, password: password }

    $.post(loginUrl, userData)
        .done(function (data) {
            var result = JSON.parse(data);
            if (result.ResultCode < 0) {
                showAlert(alertEl, "alert-warning", result.ResultMessage);
            } else {
                var resultStr = "";
                for (var key in result) {
                    if (Object.prototype.hasOwnProperty.call(result, key)) {
                        var val = result[key];
                        resultStr += key + " - " + val + "<br>";
                    }
                }
                showAlert(alertEl, "alert-success", resultStr);
            }
        })
        .fail(alertError);
    e.preventDefault();
}

function alertError() {
    showAlert(alertEl, "alert-danger", "Error");
}

function clearAlert(element) {
    element.find("#alert-message").html("");
    element.removeClass("alert-danger");
    element.removeClass("alert-success");
}

function showAlert(element, alertClass, html) {
    clearAlert(element);
    element.find("#alert-message").html(html);
    element.addClass(alertClass);
    element.removeClass("d-none");
    element.addClass("d-block");
}

function hideAlert(element) {
    clearAlert(element);
    element.removeClass("d-block");
    element.addClass("d-none");
}