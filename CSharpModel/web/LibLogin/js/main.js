
$(document).ready(function(){
    "use strict";

    $('body').on('keydown', '#txtusua', function(e) {
        if (e.which == 9) {
            e.preventDefault();
            var input = $('#txtusua');
            var check = true;
            for(var i=0; i<input.length; i++) {
                if(validate(input[i]) == false){
                    showValidate(input[i]);
                    check=false;
                }
            }
            return check;
        }
    });

    $('body').on('keydown', '#txtpassw', function(e) {
        if (e.which == 9) {
            e.preventDefault();
            var input = $('#txtpassw');
            var check = true;
            for(var i=0; i<input.length; i++) {
                if(validate(input[i]) == false){
                    showValidate(input[i]);
                    check=false;
                }
            }
            return check;
        }
    });

    $('.validate-form .input100').each(function(){
        $(this).focus(function(){
           hideValidate(this);
        });
    });

    function validate (input) {
        if($(input).attr('type') == 'email' || $(input).attr('name') == 'email') {
            if($(input).val().trim().match(/^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{1,5}|[0-9]{1,3})(\]?)$/) == null) {
                return false;
            }
        }
        else {
            if($(input).val().trim() == ''){
                return false;
            }
        }
    }

    function showValidate(input) {
        var thisAlert = $(input).parent().parent().parent().parent().parent().parent().parent();

        $(thisAlert).addClass('alert-validate');
    }

    function hideValidate(input) {
        var thisAlert = $(input).parent().parent().parent().parent().parent().parent().parent();

        $(thisAlert).removeClass('alert-validate');
    }
    
    

});