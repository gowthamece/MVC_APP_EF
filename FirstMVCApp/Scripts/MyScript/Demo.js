var str = 'hello';
var number = 1;
var obj = new String();
//document.getElementById('message').innerHTML = "Dynamic Message";
console.log(typeof str);
console.log(typeof number);
console.log(typeof obj);
$(document).ready(function () {
    
    $("#txttrest").val("hello");
    $("#txttrest").attr('style', 'color:blue');
    $("#txttrest").addClass('txtstyle');

    $.ajax({
        type: "GET",
        url: "/Employees/GetEmployees",
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (dataResponse) {
            debugger;
            
            //console.log()
            $.each(dataResponse,function (i, val) {
                var markup = "<tr><td>" + val.EmployeeID + "</td><td>" + val.FirstName +
                    "</td><td>" + val.LastName + "</td><td>" + val.Email + "</td> <td>" + val.Age + "</td> </tr>";
                $("#tblEmp tbody").append(markup);
            });

        }
    });
});
function myFunction(p1, p2) {
    return p1 * p2;
}
console.log(myFunction(2, 3));
var person = { firstName: "John", lastName: "Doe", age: 50, eyeColor: "blue" };
console.log(person.firstName);

function keyDown(event) {
    
    console.log(event.keyCode);
}
function onBtnClick() {
    //document.getElementById("demo").innerHTML = "Hello JavaScript!"
    console.log($("#txttrest").val());
}
//$('#btnFormSubmit').on
$(document).on("click",'#btnFormSubmit', function () {
    debugger;
    var Employee = {
        FirstName: $('#txtFirstName').val(),
        LastName: $("#txtlastName").val(),
        Age: $("#txtAge").val(),
        Email: $("#txtEmail").val(),
        EmployeeID: $('table tr').length +2
    };
    $.ajax({
        type: "POST",
        url: "/Employees/JQAjax",
        data: JSON.stringify(Employee),
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        success: function (dataResponse) {
            // alert(data.msg);
            console.log(dataResponse);
            // toastr("Successfully Added");
            dataResponse = dataResponse.Employee;
            var markup = "<tr><td>" + dataResponse.EmployeeID + "</td><td>" + dataResponse.FirstName +
                "</td><td>" + dataResponse.LastName + "</td><td>" + dataResponse.Email + "</td> <td>" + dataResponse.Age + "</td> </tr>";
            $("table tbody").append(markup);
            //var popUp =
            //    "<div id=\"myModal\" class=\"modal fade\" role=\"dialog\" data-container=\"body\" data-backdrop=\"static\" style=\"z-index:9999999!important;\">" +
            //    "<div class=\"modal-dialog\">" +
            //    "<div class=\"modal-content\">" +
            //    "<div class=\"modal-header\">" +
            //    "<button type=\"button\" class=\"close\" data-dismiss=\"modal\">&times;</button>" +
            //    "<h3 class=\"modal-title\"><i class=\"fa fa-exclamation-triangle\" aria-hidden=\"true\"></i>" +
            //    "Success" +
            //    "</h3>" +
            //    "</div>" +
            //    "<div class=\"modal-body\">" +
            //    dataResponse.FirstName +
                
            //    "<div class=\"modal-footer\">" +
            //    "<button id=\"ErrorClose\" class=\"btnOK btn btn-primary m-r-sm\" data-dismiss=\"modal\">OK</button>" +
            //    "</div>" +
            //    "</div>" +
            //    "</div>" +
            //    "</div>";

            //$(popUp).prependTo($("body"));

            //$('#myModal').modal('show');
        },
        error: function () {
            alert("Error occured!!")
        }
    });
})