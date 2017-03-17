$(document).ready(function () {
    jVal = {

        'login': function () {
            $('body').append('<div id="nameInfo" class="info"></div>');
            var nameInfo = $('#nameInfo');
            var ele = $('#login');
            var pos = ele.offset();
            nameInfo.css({
                top: pos.top - 3,
                left: pos.left + ele.width() + 15
            });

            if (ele.val().length < 6) {
                jVal.errors = true;
                nameInfo.removeClass('correct').addClass('error').html('← at least 6 characters').show();
                ele.removeClass('normal').addClass('wrong');
            } else {
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

        if (ele.val().length < 6) {
            jVal.errors = true;
            nameInfo.removeClass('correct').addClass('error').html('← at least 6 characters').show();
            ele.removeClass('normal').addClass('wrong');
        } else {
            nameInfo.removeClass('error').addClass('correct').html('√').show();
            ele.removeClass('wrong').addClass('normal');
        }

    }
    };
    $('#login').change(jVal.login);
    $('#password').change(jVal.password);

});