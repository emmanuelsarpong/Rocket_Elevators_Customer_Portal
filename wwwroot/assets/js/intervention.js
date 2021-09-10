jQuery(document).ready(function(){

    $("select#building_id").hide();
    $("#building_label").hide();

    $("select#battery_id").hide();
    $("#battery_label").hide();

    $("select#column_id").hide();
    $("#column_label").hide();

    $("select#elevator_id").hide();
    $("#elevator_label").hide();

});

$('#customer_id').change(function(){
    var id_value_string = $(this).val();
    if (id_value_string == "") {
        $('#select#building_id option').remove();
        var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option';
        $(row).append('select#building_id');
    } else {

        $.ajax({
            dataType: 'json',
            cache: false,
            url: '/get_building_by_customer/' + id_value_string,
            timeout: 5000,
            error: function(XMLHttpRequest, errorTextStatus, error){
                alert('failed to submit: ' + errorTextStatus + ';' + error);
            },
            success: function(data){

                $('#select#building_id option').remove();

                var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option>';
                $(row).append('select#building_id');
                console.log(data);
                $.each(data, function(i,j){
                    row = '<option value=\'' + j.id + '\'>' + j.id + '</option>';
                    $(row).append('select#building_id');
                });
                $('select#building_id').show();
            }
        });
    }
    ShowHide();
});

$('select#building_id').change(function(){
    var id_value_string = $(this).val();
    console.log(id_value_string);
    if (id_value_string == "") {
        $('#select#battery_id option').remove();
        var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option';
        $(row).append('select#battery_id');
    } else{
        //Send request and update course dropdown
        $.ajax({
            dataType: 'json',
            cache: false,
            url: '/get_battery_by_building/' + id_value_string,
            timeout: 5000,
            error: function(XMLHttpRequest, errorTextStatus, error){
                alert('failed to submit: ' + errorTextStatus + ';' + error);
            },
            success: function(data){

                $('#select#building_id option').remove();

                var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option>';
                $(row).append('select#battery_id');

                $.each(data, function(i,j){
                    row = '<option value=\'' + j.id + '\'>' + j.id + '</option>';
                    $(row).append('select#battery_id');
                });
            }
        });
    }
    ShowHide();
});

$('select#battery_id').change(function(){
    var id_value_string = $(this).val();
    console.log(id_value_string);
    if (id_value_string == "") {
        $('#select#column_id option').remove();
        var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option';
        $(row).append('select#battery_id');
    } else{
        //Send request and update course dropdown
        $.ajax({
            dataType: 'json',
            cache: false,
            url: '/get_column_by_battery/' + id_value_string,
            timeout: 5000,
            error: function(XMLHttpRequest, errorTextStatus, error){
                alert('failed to submit: ' + errorTextStatus + ';' + error);
            },
            success: function(data){

                $('#select#column_id option').remove();

                var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option>';
                $(row).append('select#column_id');

                $.each(data, function(i,j){
                    row = '<option value=\'' + j.id + '\'>' + j.id + '</option>';
                    $(row).append('select#column_id');
                });
            }
        });
    }
    ShowHide();
});

$('select#column_id').change(function(){
    var id_value_string = $(this).val();
    console.log(id_value_string);
    if (id_value_string == "") {
        $('#select#elevator_id option').remove();
        var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option';
        $(row).append('select#battery_id');
    } else{
        //Send request and update course dropdown
        $.ajax({
            dataType: 'json',
            cache: false,
            url: '/get_elevator_by_column/' + id_value_string,
            timeout: 5000,
            error: function(XMLHttpRequest, errorTextStatus, error){
                alert('failed to submit: ' + errorTextStatus + ';' + error);
            },
            success: function(data){

                $('#select#elevator_id option').remove();

                var row = '<option value=\'' + 'nullest' + '\' selected>' + '--- Select ---' + '</option>';
                $(row).append('select#elevator_id');

                $.each(data, function(i,j){
                    row = '<option value=\'' + j.id + '\'>' + j.id + '</option>';
                    $(row).append('select#elevator_id');
                });
            }
        });
    }
    ShowHide();
});

function ShowHide(){

    $("select#building_id").hide();
    $("#building_label").hide();

    $("select#battery_id").hide();
    $("#battery_label").hide();

    $("select#column_id").hide();
    $("#column_label").hide();

    $("select#elevator_id").hide();
    $("#elevator_label").hide();

}