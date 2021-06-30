//Load Data in Table when documents is ready  
$(document).ready(function () {
    loadData();

    //dropdown
    $.ajax({
        type: 'GET',
        url: '/Members/GetAll',
        datatype: 'JSON',
        data: {},
        success: function (data) {
            $('#memberDropDownList').empty();
            $('#memberDropDownList').append("<option value='0'>Select</option>");
            $.each(data, function (i, item) {
                $('#memberDropDownList').append("<option value='" + item.Id + "'>" + item.Name + "</option>");
            });
        },
        error: function (data) { alert(data.responseText); }
    })



    $("#memberDropDownList").change(function () {
        
        GetByID(document.getElementById("memberDropDownList").value)
        
    });



});

//Load Data function  
function loadData() {
    $.ajax({
        url: "/Members/GetAll",
        type: "GET",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            var html = '';
            $.each(result, function (key, item) {
                html += '<tr>';
                html += '<td><a href="#" class="btn btn-warning"  onclick="return GetByID(' + item.Id + ')">' + item.Name + ' </a></td>';
                html += '<td>' + item.Title + '</td>';
                html += '<td>' + item.Id + '</td>';
                html += '<td><a href="#" class="btn btn-danger" onclick="Delete(' + item.Id + ')">Delete</a></td>';
                html += '</tr>';
            });
            $('.tbody').html(html);
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Add Data Function   
function Add() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var MemberObj = {
       
        Name: $('#Name').val(),
        Title: $('#Title').val(),
        ProjectID: $('#ProjectId').val(),
        
    };
    $.ajax({
        url: "/Members/Add",
        data: MemberObj,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            loadData();
            $('#myModal').modal('hide');
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//Function for getting the Data Based upon Member ID  
function GetByID(Id) {
    $('#Name').css('border-color', 'lightgrey');
    $('#Title').css('border-color', 'lightgrey');
    $('#ProjectID').css('border-color', 'lightgrey');
    $('#Id').css('border-color', 'lightgrey');
    $.ajax({
        url: "/Members/GetByID/" + Id,
        typr: "GET",
        contentType: "application/json;charset=UTF-8",
        dataType: "json",
        success: function (result) {
           
            $('#Name').val(result.Name);
            $('#Title').val(result.Title);
            $('#Id').val(result.Id);
            

            $('#myModal').modal('show');
            $('#btnUpdate').show();
            $('#btnAdd').hide();
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
    return false;
}

//function for updating member's record  
function Update() {
    var res = validate();
    if (res == false) {
        return false;
    }
    var MemberObj = {
        Id: $('#Id').val(),
        Name: $('#Name').val(),
        Title: $('#Title').val(),
        ProjectId: $('#ProjectId').val(),
        
    };
    $.ajax({
        url: "/Members/Update",
        data: MemberObj,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (data) {
            loadData();
            $('#myModal').modal('hide');
            $('#Name').val("");
            $('#Title').val("");
            $('#ProjectId').val("");
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
}

//function for deleting Member's record  
function Delete(Id) {
    var ans = confirm("Are you sure you want to delete this Record?");
    if (ans) {
        $.ajax({
            url: "/Members/Delete/" + Id,
            type: "POST",
            contentType: "application/json;charset=UTF-8",
            dataType: "json",
            success: function (result) {
                loadData();
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });
    }
}

//Function for clearing the textboxes  
function clearTextBox() {
    $('#ProjectId').val("");
    $('#Name').val("");
    $('#Title').val("");
   
    $('#btnUpdate').hide();
    $('#btnAdd').show();
    
}
//Valdidation using jquery  
function validate() {
    var isValid = true;
    if ($('#Name').val().trim() == "") {
        $('#Name').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Name').css('border-color', 'lightgrey');
    }
    if ($('#Title').val().trim() == "") {
        $('#Title').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Title').css('border-color', 'lightgrey');
    }

    
       
    
}  