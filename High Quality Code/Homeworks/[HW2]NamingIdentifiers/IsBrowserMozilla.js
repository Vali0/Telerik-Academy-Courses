function onButtonClick(event, arguments) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        isMozilla = browser === "Mozilla";

    if (isMozilla) {
        alert("Your browser is Mozilla");
    } else {
        alert("Your browser is not Mozilla");
    }
}