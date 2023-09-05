$("#Them").off('click').on('click', function () {
    var A = $("#txtHo").val() == "" ? alert("nhap ho") : $("#txtHo").val();
    var B = $("#txtTen").val() == "" ? alert("nhap ten") : $("#txtTen").val();
    var C = $("#txtQG").val() == "" ? alert("chon Quoc Gia") : $("#txtQG").val();
    $("#txtThongTin").html("Ho: " + A + "    Ten: " + B + "    QuocGia: " + C);
    $("#body").append('<tr><td>' + A + '</td><td>' + B + '</td><td>' + C + '</td></tr>');
    $("#txtHo").val("");
    $("#txtTen").val("");
    $("#txtQG").val("");
});
$("#Re").off('click').on('click', function () {
    $("#txtHo").val("");
    $("#txtTen").val("");
    $("#txtQG").val("");
    $("#txtThongTin").html("");
});
$("#ReT").off('click').on('click', function () {
    $("#body").html("");
});
//lấy giá trị của text là val, gán nội dung html cho id thường cho thẻ p, h...