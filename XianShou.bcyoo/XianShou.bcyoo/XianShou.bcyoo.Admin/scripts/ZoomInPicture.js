
function ZoomInMouseOver(event, outDiv, imgDiv, zoomSize) {
    var offsetX = 20 - $("#" + outDiv).offset().left;
    var offsetY = 20 - $("#" + outDiv).offset().top;
    var size = zoomSize * $('#' + imgDiv).width();
    var $target = $(event.target);
    if ($target.is('img')) {
        $("<img id='tip' src='" + $target.attr("src") + "'>").css({
            "height": size,
            "width": size,
            "top": event.pageX + offsetX,
            "z-index": 100,
            "left": event.pageY + offsetY,
        }).appendTo($("#" + outDiv));
    }
}

function ZoomInMouseOut() {
    $("#tip").remove();
}

function ZoomInMouseMove(event, outDiv) {
    var offsetX = 20 - $("#" + outDiv).offset().left;
    var offsetY = 20 - $("#" + outDiv).offset().top;
    $("#tip").css(
        {
            "left": event.pageX + offsetX,
            "top": event.pageY + offsetY
        });
}

function TextMouseOver(event, outDiv, thisClass) {
    var offsetX = 10 - $("#" + outDiv).offset().left;
    var offsetY = 10 - $("#" + outDiv).offset().top;
    var size = 400;
    $("<img id='tip' src='http://mobile.service.osmws.com/image/resize/" + $(thisClass).attr("name") + "/0'>").css({
        "height": size,
        "top": event.pageX + offsetX,
        "z-index": 1000,
        "left": event.pageY + offsetY,
        "position": "absolute"
    }).appendTo($("#" + outDiv));
}

function TextMouseOut() {
    $("#tip").remove();
}

function TextMouseMove(event, outDiv) {
    var offsetX = 10 - $("#" + outDiv).offset().left;
    var offsetY = 10 - $("#" + outDiv).offset().top;
    $("#tip").css(
        {
            "left": event.pageX + offsetX,
            "top": event.pageY + offsetY
        });
}
