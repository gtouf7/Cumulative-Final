// AJAX teacher input

function AddTeacher() {
    var URL = "http://localhost:60165/api/TeacherData/AddTeacher/";

    var request = new XMLHttpRequest();

    var TeacherFname = document.getElementById("teacherFname").value;
    var TeacherLname = document.getElementById("teacherLname").value;
    var TeacherId = document.getElementById("teacherId").value;
    var EmployeeNo = document.getElementById("employeeNo").value;
    var Salary = document.getElementById("salary").value;

    var TeacherData = {
        "TeacherFname": TeacherFname,
        "TeacherLname": TeacherLname,
        "TeacherId": TeacherId,
        "EmployeeNo": EmployeeNo,
        "Salary": Salary

    };

    request.open("POST", URL, true);
    request.setRequestHeader("Content-Type", "application/json");
    request.onreadystatechange = function () {
        if (request.readyState == 4 & request.status == 200) { }

    }

    request.send(JSON.stringify(TeacherData));
}