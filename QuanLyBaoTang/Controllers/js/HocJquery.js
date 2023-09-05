//cú pháp jquery
//$("phần tử chọn") => cú pháp chọn phần tử
//cách viết Event => click, change,....
//cách đặt tên function tênfuntion() VD: function Tinhtoan()
//$("#btn-an").off('click').on('click', function () {
//    AnTheP();
//});
////hàm là funtion => mục đích mô tả công việc xử lý của mình khi viết
//function AnTheP() {
//    //cú pháp ẩn phần tử html hide()
//    $("p").hide();
//}
//$("#btn-hien").off('click').on('click', function () {
//    $("p").show();
//});
////lấy giá trị của input, select => val()

//$("#txt-soA").off('change').on('change', function () {
                                                                    //lấy giá trị của input => txtsoA
                                                                    //cách chuyển đổi từ kiểu string => Int
                                                                    //cú pháp : parseInt(chuỗi chuyển đổi)
                                                                    /* var A = parseInt($("#txt-soA").val());*/
                                                                    //cách chuyển đổi từ kiểu string => Int
                                                                    //cú pháp : parseInt(chuỗi chuyển đổi)
                                                                    //alert là show hộp thoại khi nhập xong input
                                                                    /* alert(A);*/
                                                                    //});
                                                                    //$("#txt-soB").off('change').on('change', function () {
                                                                    //    var B = parseInt($("#txt-soB").val());
                                                                    //});
//    var giatriA;
//    var giatriB;
//    if ($("#txt-soB").val() == "") {
//        giatriB = 0;
//    } else {
//        giatriB = parseInt($("#txt-soB").val())
//    }
//    if ($("#txt-soA").val() == "") {
//        giatriA = 0;
//    } else {
//        giatriA = parseInt($("#txt-soA").val())
//    }
//    $("#txt-ketqua").val(giatriA + giatriB);
//});
//$("#txt-soB").off('change').on('change', function () {
//    var giatriA;
//    var giatriB;
//    if ($("#txt-soA").val() == "") {
//        giatriA = 0;
//    } else {
//        giatriA = parseInt($("#txt-soA").val())
//    }
//    if ($("#txt-soB").val() == "") {
//        giatriB = 0;
//    } else {
//        giatriB = parseInt($("#txt-soB").val())
//    }
//    $("#txt-ketqua").val(giatriA + giatriB);
//});

$("#tinh").off('click').on('click', function () {
    TinhToan();
    //var giatriA;
    //var giatriB;
    //if ($("#txt-soA").val() == "") {
    //    giatriA = 0;
    //} else {
    //    giatriA = parseInt($("#txt-soA").val())
    //}
    //if ($("#txt-soB").val() == "") {
    //    giatriB = 0;
    //} else {
    //    giatriB = parseInt($("#txt-soB").val())
    //}
    //$("#txt-ketqua").val(giatriA + giatriB);
});

function TinhToan() {
    var giatriA = $("#txt-soA").val() == "" ? 0 : parseInt($("#txt-soA").val());
    var giatriB = $("#txt-soB").val() == "" ? 0 : parseInt($("#txt-soB").val());
    $("#txt-ketqua").val(giatriA + giatriB);
}
$("#Re").off('click').on('click', function () {
    $("#txt-soA").val("")
    $("#txt-soB").val("")
    $("#txt-ketqua").val("")
});