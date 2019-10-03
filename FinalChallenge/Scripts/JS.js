var theList = {};

function continueOn() {
    theList.player = $("#playerName").val();
    theList.items = new Array();

    nextPage();
}

function nextPage() {
    $("#greet").html(theList.player);
    $("#characterFriends").show();

    $("#first").hide();
    $("#secondPage").show();
}

