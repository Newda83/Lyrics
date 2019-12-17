// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// ajax function to handle input of artist name
$('#searchBtn').click(function () {
    var name = $('#artistInput').val();
    $("#results").html('Searching For Info, please wait');
    $("#artistInput").attr("disabled", true);
    $("#artistInput").attr("searchBtn", true);
    $.ajax({
        url: '/Home/Artist',
        contentType: "application/json; charset=utf-8",
        data: { name: name },
        dataType: "html",
        success: function (result, status, xhr) {
            $("#results").html(result);
            $("#artistInput").attr("disabled", false);
            $("#artistInput").attr("searchBtn", false);
        },
        
    })
});