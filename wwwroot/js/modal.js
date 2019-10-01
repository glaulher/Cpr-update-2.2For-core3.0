$(function () {
    $(".createlivrocaixa").click(function () {                             
        $("#modal").load("LivroCaixa/create" , function () {
        $("#modal").modal();
        $.validator.unobtrusive.parse('form');
        });
    });

    $(".create").click(function () {                             
        $("#modal").load("Categoria/create" , function () {
        $("#modal").modal();
        $.validator.unobtrusive.parse('form');
        });
    });

    $(".edit").click(function () {
        var id = $(this).attr("data-id");                  
        $("#modal").load("Categoria/Edit?id=" + id , function () {
        $("#modal").modal();
        $.validator.unobtrusive.parse('form');
        });
    });

$(".delete").click(function () {
        var id = $(this).attr("data-id");                  
        $("#modal").load("Categoria/Delete?id=" + id , function () {
        $("#modal").modal();
        $.validator.unobtrusive.parse('form');
        });
    });
});
