var jsConsole = (function () {
    function writeLine(value, parameters) {
        console.log(writeToConsole.apply(null, arguments));
    }

    function writeError(value, parameters) {
        console.error(writeToConsole.apply(null, arguments));
    }

    function writeWarning(vlaue, parameters) {
        console.warn(writeToConsole.apply(null, arguments));
    }

    function writeToConsole(value, parameters) {
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

    return {
        writeLine: writeLine,
        writeError: writeError,
        writeWarning: writeWarning,
    }
}());