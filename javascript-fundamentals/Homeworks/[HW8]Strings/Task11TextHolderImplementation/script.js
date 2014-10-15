var format = "{0}, {1}, {0} text {2}";
var str = stringFormat(format, 1, "Pesho", "Gosho");
console.log(str);

function stringFormat(value, parameters) {
    var result;

    if (value) {
        result = value.toString();
    }

    if (parameters) {
        for (var i = 0, len = arguments.length; i < len - 1; i++) {
            var pattern = "\\{" + i + "\\}";
            var regex = new RegExp(pattern, "g");

            result = result.replace(regex, arguments[i + 1].toString());
        }
    }

    return result;
}