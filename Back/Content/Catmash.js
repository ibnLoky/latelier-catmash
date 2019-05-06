function LoadCats() {
    $.getJSON("api/Cats/0",
            function(json) {
                debugger;
                $("#cat1Id").attr('text', json["Id"]);
                $("#cat1").attr('src', json["PhotoUrl"]);
            })
        .fail(function() {
            console.log("error");
        });

    var cat2Url;
    debugger;
    $.getJSON("api/Cats/0",
            function(json) {
                debugger;
                $("#cat2Id").attr('text', json["Id"]);
                $("#cat2").attr('src', json["PhotoUrl"]);
            })
        .fail(function() {
            console.log("error");
        });
    $("#cat2").attr('src', cat2Url);
    $("#cat1").on('click',
        function () {
            $.post("api/Votes/", { Voted: $("#cat1Id").attr('text'), Against: $("#cat2Id").attr('text') });
            $("#cat1").off("click");
            $("#cat2").off("click");
            LoadCats();
        });
    $("#cat2").on('click',
        function () {
            $.post("api/Votes/", { Voted: $("#cat2Id").attr('text'), Against: $("#cat1Id").attr('text')});
            $("#cat1").off("click");
            $("#cat2").off("click");
            LoadCats();
        });

}

$(document).ready(
    function() {
        LoadCats();
    }
);
