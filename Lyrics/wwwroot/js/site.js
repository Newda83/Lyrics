// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// ajax function to handle input of artist name
$('#searchBtn').click(function () {
    var name = $('#artistInput').val();
    $("#results").html('Searching For Info, please wait. This may take a few minutes');
    $("#artistInput").attr("disabled", true);
    $("#artistInput").attr("searchBtn", true);
    $("#artistInput").attr("simpleSearchBtn", true);
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

$('#simpleSearchBtn').click(function () {
    var name = $('#artistInput').val();
    $("#results").html('Searching For Info, please wait. this may take a minute or 2');
    $("#artistInput").attr("disabled", true);
    $("#artistInput").attr("searchBtn", true);
    $("#artistInput").attr("simpleSearchBtn", true);
    $.ajax({
        url: '/Home/ArtistSimple',
        contentType: "application/json; charset=utf-8",
        data: { name: name },
        dataType: "html",
        success: function (result, status, xhr) {
            $("#results").html(result);
            $("#artistInput").attr("disabled", false);
            $("#artistInput").attr("searchBtn", false);
            $("#artistInput").attr("simpleSearchBtn", false);
        },

    })
});