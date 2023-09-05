//$("#btnTaoMoi").off('click').on('click', function () {
//    TaoMoi();

//});
//$("#btnCapNhat").off('click').on('click', function () {
//    SavaData();
//});

//function TaoMoi() {
//    $("#txtSTT").val("")
//    $("#txtTenGoi").val("")
//    $("#txtGhiChu").val("")
//    $.toastr.success('Tạo thành công');
//}
//function SavaData() {
//    var stt = $("#txtSTT").val()
//    var tengoi = $("#txtTenGoi").val()
//    var ghichu = $("#txtGhiChu").val()
//    //&& khi tất cả điều kiện đều đúng true
//    //|| khi một trong các điều kiện đúng thì là true
//    if (stt == "" || stt == null || stt == undefined) {
//        $.toastr.warning('số thứ tự không được để trống');
//        $("#txtSTT").focus();
//        return;
//        // toastr là thông báo $.toastr.màu thông báo('thông báo được biết');
//    }
//    if (tengoi == "" || tengoi == null || tengoi == undefined) {
//        $.toastr.warning('tên không được để trống' );
//        $("#txtTenGoi").focus();
//        return;
//    }
//    $("#txtKetQua").append('<tr><td>' + stt + '</td><td>' + tengoi + '</td><td>' + ghichu + '</td></tr>')
//}

var myController = {
    // hàm <=> phương thức 
    init: function () {
        myController.Event();
        myController.LoadTable();
    },
    // hàm sự kiện 
    Event: function () {
        $("#btnTaoMoi").off('click').on('click', function () {
        });
        $("#btnCapNhat").off('click').on('click', function () {
            myController.SavaData();
        });
    },

    SavaData: function () {
        var stt = $("#txtSTT").val()
        var tengoi = $("#txtTenGoi").val()
        var ghichu = $("#txtGhiChu").val()
        //&& khi tất cả điều kiện đều đúng true
        //|| khi một trong các điều kiện đúng thì là true
        if (stt == "" || stt == null || stt == undefined) {
            $.toastr.warning('số thứ tự không được để trống');
            $("#txtSTT").focus();
            return;
            // toastr là thông báo $.toastr.màu thông báo('thông báo được biết');
        }
        if (tengoi == "" || tengoi == null || tengoi == undefined) {
            $.toastr.warning('tên không được để trống');
            $("#txtTenGoi").focus();
            return;
        }
        $("#txtKetQua").append('<tr><td>' + stt + '</td><td>' + tengoi + '</td><td>' + ghichu + '</td></tr>')
    },

    LoadTable: function () {
        $("#txtKetQua").append('<tr><td>' + "Trần Minh " + '</td><td>' + "Quân" + '</td><td>' + "abc" + '</td></tr>')
        
    }

}

myController.init();