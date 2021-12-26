var startPoint = 0;
var endPoint = 0;
function GetJourneys() {
    var date = $('#date').val()
    location.href = "Journey/Index?startPoint=" + startPoint + "&endPoint=" + endPoint + "&date=" + date;
};

function ButtonClick (i, e) {
    if (e)
        startPoint = i;
    else
        endPoint = i;
};