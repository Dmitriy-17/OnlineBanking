$(document).ready(function () {
    jVal = {

        'login': function () {
            $('body').append('<div id="loginInfo" class="info"></div>');
            var loginInfo = $('#loginInfo');
            var ele = $('#login');
            var pos = ele.offset();
            loginInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });

            if (ele.val().length < 3) {
                jVal.errors = true;
                loginInfo.removeClass('correct').addClass('error').html('← at least 3 characters').show();
                ele.removeClass('normal').addClass('wrong');
                ele.prop('valid', 'invalid');

            }
            else if (ele.val().length > 30) {
                jVal.errors = true;
                loginInfo.removeClass('correct').addClass('error').html('← not more than 30 characters').show();
                ele.removeClass('normal').addClass('wrong');
            }
            else {
                loginInfo.removeClass('error').addClass('correct').html('√').show();
                ele.removeClass('wrong').addClass('normal');
            }
        },
        'name': function () {
            $('body').append('<div id="nameInfo" class="info"></div>');
            var nameInfo = $('#nameInfo');
            var ele = $('#name');
            var pos = ele.offset();
            nameInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });

            if (ele.val().length < 3) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('← at least 3 characters').show();
                ele.removeClass('normal').addClass('wrong');
                ele.prop('valid', 'invalid');

            }
            else if (ele.val().length > 30) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('← not more than 30 characters').show();
                ele.removeClass('normal').addClass('wrong');
            }
            else {
                nameInfo.removeClass('error').addClass('correct').html('√').show();
                ele.removeClass('wrong').addClass('normal');
            }
        },
        'password': function () {
        $('body').append('<div id="passInfo" class="info"></div>');
        var nameInfo = $('#passInfo');
        var ele = $('#password');
        var pos = ele.offset();
        nameInfo.css({
            top: pos.top - 3,
            left: pos.left + ele.width() + 15
        });

        if (ele.val().length < 4) {
            jVal.errors = true;
            nameInfo.removeClass('correct').addClass('error').html('← at least 4 characters').show();
            ele.removeClass('normal').addClass('wrong');
        } else {
            nameInfo.removeClass('error').addClass('correct').html('√').show();
            ele.removeClass('wrong').addClass('normal');
        }

        },
        'confirmPassword': function () {
            $('body').append('<div id="passconfirmInfo" class="info"></div>');
            var nameInfo = $('#passconfirmInfo');
            var pas = $('#password');
            var ele = $('#confirmPassword');
            var pos = ele.offset();
            nameInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });

            if (ele.val() != pas.val()) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('passwords do not match').show();
                ele.removeClass('normal').addClass('wrong');
            } else {
                nameInfo.removeClass('error').addClass('correct').html('√').show();
                ele.removeClass('wrong').addClass('normal');
            }

        },
        'email': function () {
            $('body').append('<div id="emailInfo" class="info"></div>');
            var emailInfo = $('#emailInfo');
            var ele = $('#email');
            var pos = ele.offset();
            emailInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });
            var patt = /^.+@.+[.].{2,}$/i;
            if (!patt.test(ele.val())) {
                jVal.errors = true;
                emailInfo.removeClass('correct').addClass('error').html('← give me a valid email adress').show();
                ele.removeClass('normal').addClass('wrong');
            } else {
                emailInfo.removeClass('error').addClass('correct').html('√').show();
                ele.removeClass('wrong').addClass('normal');
            }
        },
        'address': function () {
            $('body').append('<div id="addressInfo" class="info"></div>');
            var nameInfo = $('#addressInfo');
            var ele = $('#address');
            var pos = ele.offset();
            nameInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });

            if (ele.val().length < 4) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('← at least 4 characters').show();
                ele.removeClass('normal').addClass('wrong');
            }
            else if (ele.val().length > 40) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('← not more than 30 characters').show();
                ele.removeClass('normal').addClass('wrong');
            }
            else {
                nameInfo.removeClass('error').addClass('correct').html('√').show();
                ele.removeClass('wrong').addClass('normal');
            }
        }
    };

    $('#regForm input').on('keyup blur', function () {
        if ($('#regForm').valid()) {
            $('sendReg').prop('disabled', false);
        } else {
            $('sendReg').prop('disabled', 'disabled');
        }
    });

    $('#login').change(jVal.login);
    $('#name').change(jVal.name);
    $('#password').change(jVal.password);
    $('#confirmPassword').change(jVal.confirmPassword);
    $('#email').change(jVal.email);
    $('#address').change(jVal.address);


});