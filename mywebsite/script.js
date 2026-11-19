function registerStudent() {

    let name = document.getElementById("name").value;
    let email = document.getElementById("email").value;

    if (name == "" || email == "") {
        alert("Please fill all fields");
    }
    else {
        document.getElementById("result").innerHTML =
            "Welcome " + name + "! Registration successful.";
    }
}