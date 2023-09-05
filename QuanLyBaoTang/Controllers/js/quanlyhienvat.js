//seclector => lựa chọn phần tử HTMLAllCollection

//có 2 cách hay dùng: lấy thông qua class // iD

//cú pháp lấy phần tử của jquery

//$("phần tử lựa chọn") thuộc tính 


$("#bntLayGiaTri3").off('click').on('click', function () {
    var a = parseInt($("#txtA").val());
    var b = parseInt($("#txtB").val());
    var c = a + b;

    $("#txtC").val(c);
})

$("#txtA").off('change').on('change', function () {
    var a = parseInt($("#txtA").val());
    var b = parseInt($("#txtB").val());
    var c = a + b;

    $("#txtC").val(c);
})

$("#txtB").off('change').on('change', function () {
    var a = parseInt($("#txtA").val());
    var b = parseInt($("#txtB").val());
    var c = a + b;

    $("#txtC").val(c);
})
