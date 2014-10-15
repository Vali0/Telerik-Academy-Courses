/// <reference path="/libraries/raphael-min.js" />
(function () {
    var paper = Raphael(0, 0, 600, 450);

    paper.rect(0, 280, 600, 20)
        .attr({
                  stroke: 'none',
                  fill: 'brown'
              })

    paper.rect(0, 0, 600, 280)
        .attr({
                  stroke: 'none',
                  fill: '90-rgba(240,249,255,1):5-rgba(161,219,255,1):100'
              })

    var tree = paper.image('/images/treee.png', 600, 140, 130, 150);
    var firstCloud = paper.image('/images/SMB3_item_Cloud.png', 600, 20, 30, 50);
    var secondCloud = paper.image('/images/SMB3_item_Cloud.png', 650, 60, 30, 50);
    var alwaysMove = Raphael.animation({ x: -150 }, 5000).repeat(Infinity);

    tree.animate(alwaysMove);
    firstCloud.animate(alwaysMove);
    secondCloud.animate(alwaysMove);
}());