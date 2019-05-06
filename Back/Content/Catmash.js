var cat1Id = 0;
var cat2Id = 0;

function LoadCats() {
    //$.getJSON("api/Cats/0").done(function(json) {
    //    debugger;
    $.getJSON("api/Cats/0",
            function(json) {
                debugger;
                cat1Id = json["Id"];
                $("#cat1").attr('src', json["PhotoUrl"]);
            })
        .fail(function() {
            console.log("error");
        });

    var cat2Url;
    //do {
    $.getJSON("api/Cats/0",
            function (json) {
                debugger;
                cat2Id = json["Id"];
            })
        .fail(function () {
            console.log("error");
        });
    //} while (cat1Id == cat2Id);
    $("#cat2").attr('src', cat2Url);

}

$(document).ready(
    function() {
        LoadCats();
    }
);
