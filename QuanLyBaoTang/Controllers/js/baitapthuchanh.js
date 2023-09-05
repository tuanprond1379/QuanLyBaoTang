$("#btnThem").off('click').on('click', function () {
    Them();
})
$("#btnTao").off('click').on('click', function () {
    TaoMoi()
})
$("#btnXoa").off('click').on('click', function () {
    Xoa()
})
function Them() {
    var Ho = $("#txtHo").val();
    var Ten = $("#txtTen").val();
    var SDT = $("#txtSDT").val();
    if (Ho == "" || Ho == null || Ho == undefined) {
        $.toastr.warning('Họ không được để trống');
        $("#txtHo").focus();
        return;

    }
    if (Ten == "" || Ten == null || Ten == undefined) {
        $.toastr.warning('Tên không được để trống');
        $("#txtTen").focus();
        return;

    }
    $("#DanhSach").append('<tr><td>' + Ho + '</td><td>' + Ten + '</td><td>' + SDT + '</td></tr>')
}
function TaoMoi() {
    $("#txtHo").val("");
    $("#txtTen").val("");
    $("#txtSDT").val("");
    $.toastr.success('Tạo mới thành công');
}
function Xoa() {
    $("#DanhSach").val("");
    $.toastr.success('Xóa danh sách thành công');
}