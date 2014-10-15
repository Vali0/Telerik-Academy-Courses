String.prototype.replaceSymbols = replaceAllSymbols;
var str = "Lorem   ipsum dummy            text  generator  hahaha :)";
var replacedSymbols = str.replaceSymbols(' ', "&nbsp;");
console.log(replacedSymbols);

function replaceAllSymbols(oldSymbol, newSymbol) {
    var result = result || "",
        len = this.length;

    for (var i = 0; i < len; i++) {
        if (this[i] === oldSymbol) {
            result += newSymbol;
        } else {
            result += this[i];
        }
    }

    return result;
}