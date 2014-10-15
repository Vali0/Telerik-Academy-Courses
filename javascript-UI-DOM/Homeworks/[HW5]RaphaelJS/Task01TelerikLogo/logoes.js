/// <reference path="/raphaeljs-v2.1.2.js" />

var logoes = (function() {
    var paper = new Raphael(10, 10, 960, 500);

    function telerik() {
        paper.text(350, 100, "Telerik")
            .attr({
                      "font-weight": "bold",
                      "font-size": 100,
                      "font-family": "Calibri"
                  });

        paper.text(500, 95, "®")
            .attr({
                      "font-weight": "bold",
                      "font-size": 20,
                  });

        paper.text(370, 150, "Develop experiences")
            .attr({
                      "font-size": 35,
                      "font-family": "Calibri"
                  });

        paper.path("M 40 80 L 75 55 L 125 125 L 100 150 L 75 125 L 125 55 L 160 80")
            .attr({
                      "stroke-width": 10,
                      stroke: "#C1D832"
                  });
    }
    
    function youtube() {
        paper.text(270, 300, "You")
            .attr({
                      "font-weight": "bold",
                      "font-size": 80,
                      "font-family": "Calibri",
                      fill: "#4A4A4A"
                  });

        paper.rect(333, 257, 170, 90, 25)
            .attr({
                      stroke:"none",
                      fill: "#EC262A"
                  });

        paper.text(420, 300, "Tube")
            .attr({
                      "font-weight": "bold",
                      "font-size": 80,
                      "font-family": "Calibri",
                      fill: "white"
                  });
    }

    return {
        telerik: telerik,
        youtube: youtube
    }
}());

logoes.telerik();
logoes.youtube();