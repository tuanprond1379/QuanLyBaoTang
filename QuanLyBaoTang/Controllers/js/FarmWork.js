var myController = {
    init: function () {
        myController.Event();
    },
    Event: function () {
        $("#toast").off('click').on('click', function () {
            myController.Toast();
        });
        $("#bootbox").off('click').on('click', function () {
            myController.bootbox();
        });
        $("#sweet").off('click').on('click', function () {
            myController.sweet();
        });
    },
    Toast: function () {
        $.toast({ heading: 'warning', text: 'hehe', icon: 'warning' })
    },
    bootbox: function () {
        bootbox.confirm({
            message: 'Tôi đồng ý',
            buttons: {
                confirm: {
                    label: 'Yes',
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
    sweet: function () {
        swal({
            title: "Bạn có muốn xác nhận",
            text: "Xác nhận sẽ không được chỉnh sửa",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: "#385ed1",
            confirmButtonText: "Tôi đồng ý",
            closeOnConfirm: false
        }, function () {
            swal("Deleted!", "Your imaginary file has been deleted.", "success");
        });
    }
};
myController.init();