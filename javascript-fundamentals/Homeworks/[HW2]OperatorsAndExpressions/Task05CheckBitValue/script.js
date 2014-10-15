function checkNumber() {
    var number,
        mask,
        numberAndMask,
        bit,
        container;

    number = document.getElementById("user-input").value;
    mask = 1 << 3;
    numberAndMask = number & mask;
    bit = numberAndMask >> 3;
    container = document.getElementById("result");
    container.innerHTML = bit;
}