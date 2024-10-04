$("#seleccionImg").change(function () {
    var tam = this.files[0].size;
    if (tam > 50000000) {
        alert("El peso del archivo debe ser inferior a 5MB")
    } else {
        readURL(this)
    }
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#imagen").attr("src", e.target.result);
        }

        reader.readAsDataURL(input.files[0]);
    }
}