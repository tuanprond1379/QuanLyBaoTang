//var myController = {
//    init: function () {
//        myController.Event();
//    },
//    Event: function () {
//        $("#btndangnhap").off('click').on('click', function () {
//            myController.DangNhap();
//              /* myController.Save();*/
//        });
//    },
//    DangNhap: function () {
//        var Email = $("#Email").val();
//        var Pass = $("#Password").val();

//        if (Email == "" || Email == null || Email == undefined) {
//            $.toastr.warning('Email không được để trống');
//            $("#Email").focus();
//            return;
//        }
//        if (Pass == "" || Pass == null || Pass == undefined) {
//            $.toastr.warning('Passward không được để trống');
//            $("#Password").focus();
//            return;
//        }
//    /*    myController.Save();*/
//        if (Email == "123" && Pass == "123") {
//                    myController.Save();
//                }
//                else {
//                    $("#Email").val("");
//                    $("#Password").val("");

//                    $.toastr.error('Đăng nhập không thành công');
//                    return;
//                }

//    },
//    Save: function () {
//        var checked = $("#customCheck1").prop('checked');
//        if (checked == true) {
//            $.toastr.success('Đăng Nhập Thành Công');
//            return;
//        }
//        else {
//            $.toastr.warning('Tích Chọn Để Đăng Nhập');
//            return;
//        }
//    },
//};
//myController.init();




// khởi tạo đối tượng Controller
var myController = {

    // hàm khởi tạo init => để gọi đến các hàm mình muốn thực thi
    init: function () {
        // gọi đến hàm đăng ký sự kiện => regesterEvent
        myController.regesterEvent();
    },

    regesterEvent: function () {
     
        $("#cbTen").select2();
        $(".select2").css({ 'text-align': 'start' });
        // đăng ký sự kiện click cho button có id => btnDangNhap
        $("#btndangnhap").off('click').on('click', function () {
            // gọi đến hàm SaveData() => để lưu dữ liệu
            myController.SaveData();
        });

    },
    SaveData: function () {
        //swal({
        //    title: "Bạn có muốn xác nhận",
        //    text: "Xác nhận sẽ không được chỉnh sửa",
        //    type: "warning",
        //    showCancelButton: true,
        //    confirmButtonColor: "#385ed1",
        //    confirmButtonText: "Tôi đồng ý",
        //    closeOnConfirm: false
        //}, function () {
        //    swal("Deleted!", "Your imaginary file has been deleted.", "success");
        //});

        bootbox.confirm({
            message: 'Tôi đồng ý',
            buttons: {
                confirm: {
                    label: '<i>class:"feather icon-check-circle"</i> Yes',
                    className: 'btn-sm btn-success'
                },
                cancel: {
                    label: 'No',
                    className: 'btn-sm btn-danger'
                }
            },
            callback: function (result) {
                console.log('This was logged in the callback: ' + result);
            }
        });

    },
    //SaveData: function () {

    //    // lấy ra giá trị của input , checked
    //    var txtEmail = $("#Email").val();
    //    var txtPassword = $("#Password").val();
    //    var ckGhiNho = $("#customCheck1").prop('checked');

    //    // xem xét điều kiện if else if
    //    // 1. => nếu email hoặc password bằng rỗng thì yêu cầu không được để trống
    //    if (txtEmail == "" || txtEmail == undefined || txtEmail == null) {
    //        // hiển thị lên hộp thoại thông báo
    //       /* 4 dạng thông báo: (được gán vào thuộc tính icon)*/
    //        $.toast({ heading: 'warning', text: 'Bạn Không Được Để Trống Email',  icon: 'warning' })
    //        $.toast({ heading: 'error', text: 'Bạn Không Được Để Trống Email',  icon: 'error' })
    //        $.toast({ heading: 'info', text: 'Bạn Không Được Để Trống Email',  icon: 'info' })
    //        $.toast({ heading: 'success', text: 'Bạn Không Được Để Trống Email',  icon: 'success' })
    //        return; //==> thoát luôn ra khỏi hàm khi gặp lệnh return
    //    } else if (txtPassword == "" || txtPassword == undefined || txtPassword == null) {
    //        alert("Mật khẩu không được để chống");
    //        return;
    //        // Khi check xong lần lượt Email và Paswword => tiếp tục check đên ckGhiNho
    //    } else if (ckGhiNho == false || ckGhiNho == "false") {
    //        alert("Bạn phải tích chọn");
    //        return;
    //        // Check xong thông tin bắt đầu check đến so sánh mật khẩu
    //    } else if (txtEmail == "admin@gmail.com" && txtPassword == "123456admin") {
    //        alert("Đăng nhập thành công");
    //    } else {
    //        // đăng nhập thất bại thì sẽ reset lại các trường thông tin
    //        alert("Đăng nhập thất bại");
    //        // gán giá trị cho các  input , checked
    //        $("#Email").val("");
    //        $("#Password").val("");
    //        $("#customCheck1").prop('checked', false);
    //    }

    //}

};

// gọi đến hàm khởi tạo để được thực thi hàm
myController.init();





