
//$("#In").off('click').on('click', function () {
//    inra();

//});
//function inra() {
//    var Ten = $("#Ten").val();
//    var Tuoi = $("#Tuoi").val();
//    var SĐT = $("#SĐT").val();
//    var ketqua = $("#check").prop('checked')
//    if (ketqua == true) {
//        alert("Nam:" + "  Tên: " + Ten + "  Tuổi: " + Tuoi + "  SĐT: " + SĐT);
//    } else (ketqua == false)
//     alert("Nu:" + "  Tên: " + Ten + "  Tuổi: " + Tuoi + "  SĐT: " + SĐT); 

//}




var mycontroller = {
    init: function () {
        mycontroller.dangkysuukien();
    },
    dangkysuukien: function () {
        $("#btnIn").off('click').on('click', function () {
            mycontroller.inra();

        });
    },
    inra: function () {
        var ten = $("#Ten").val();
        var tuoi = $("#Tuoi").val();
        var sđt = $("#SĐT").val();
        var ketqua = $("#check").prop('checked');

        if (ketqua == true) {
            $("#InThongTin").append("Nam:" + "     Tên: " + ten + "     Tuổi: " + tuoi + "     SĐT: " + sđt + "</br>");
        }
        else {
            $("#InThongTin").append("Nu:" + "     Tên: " + ten + "     Tuổi: " + tuoi + "     SĐT: " + sđt + "</br>");
        } 
    },
}
mycontroller.init();




var myController = {
    init: function () {

    },
    cachamchay: function () {
        $("#btnThem").off('click').on('click', function () {

        });
    },
    themmoi: function () {
        var A = $("#txtTen").val();
        var B = $("#txtTuoi").val();
        
    },

}
mycontroller.init();