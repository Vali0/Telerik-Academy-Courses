function getTextFieldValue() {
    var fieldValue = document.querySelector('input[type=text]').value;
    console.log(fieldValue);
}

(function() {
    var button = document.getElementById('printButton');
    button.addEventListener('click', getTextFieldValue, false);
})();