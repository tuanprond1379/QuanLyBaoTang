var myController = {
    init: function () {
        myController.RegesterRvent();
    },
    RegesterRvent: function () {
        $("#tinh").off('click').on('click', function () {
            myController.Tinh();
        });
        $("#Re").off('click').on('click', function () {
                myController.Reset();
        });
    },
    Tinh: function () {
        var giatriA;
        var giatriB;
        var giatriC;
        var giatriA = $("#txt-soA").val() == "" ? 0 : parseInt($("#txt-soA").val());
        var giatriB = $("#txt-soB").val() == "" ? 0 : parseInt($("#txt-soB").val());
      
       /* $("#txt-ketqua").val(giatriA + giatriB);*/
        var phanloai = $("#chonpheptinh").val();
        if (phanloai == "+") {
            $("#txt-ketqua").val(giatriA + giatriB);
        } else if (phanloai == "-") {
            $("#txt-ketqua").val(giatriA - giatriB);
        } else if (phanloai == "*") {
            $("#txt-ketqua").val(giatriA * giatriB);
        } else if (phanloai == "/") {
            $("#txt-ketqua").val(giatriA / giatriB);
        }
        var giatriC = $("#txt-ketqua").val();
        $("#KetQuaIn").append("<div>" + giatriA + phanloai + giatriB + " = " + giatriC + "</div>")
        /*lấy giá trrij cho checked*/
       // $("#").prop('checked');
       ///* gán giá trị cho checked*/
       // $("#").prop('checked', true);
       // $("#").prop('checked'. false);
    },
    Reset: function () {
        $("#txt-soA").val("")
        $("#txt-soB").val("")
        $("#txt-ketqua").val("")
    },
};
myController.init();
