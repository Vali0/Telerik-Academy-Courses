/// <reference path="/libraries/kinetic-v5.1.0.min.js" />

(function () {
    var stage = new Kinetic.Stage({
                                      container: 'container',
                                      width: 578,
                                      height: 400
                                  });

    var imageObj = new Image();
    imageObj.onload = function () {
        var mario = new Kinetic.Sprite({
                                           x: 250,
                                           y: 245,
                                           image: imageObj,
                                           animation: 'idle',
                                           animations: {
                idle: [
                                                       24, 103, 15, 27,
                                                       47, 104, 16, 26,
                                                       70, 103, 16, 27,
                                                       93, 103, 15, 27,
                                                       116, 104, 16, 26,
                                                       142, 103, 16, 27,
                                                       165, 103, 15, 27
                                                   ]
            },
                                           frameRate: 7,
                                           frameIndex: 0
                                       });

        var layer = new Kinetic.Layer();
        layer.add(mario);
        stage.add(layer);
        mario.start();
    };

    imageObj.src = '/images/SMAS-SMB2Mario.gif';
}());