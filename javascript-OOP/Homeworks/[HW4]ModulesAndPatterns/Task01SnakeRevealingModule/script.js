(function () {
    var canvas = document.getElementById('snake-canvas');
    var ctx = canvas.getContext('2d');

    var WIDTH = canvas.clientWidth;
    var HEIGHT = canvas.clientHeight;
    var score = 0;

    ctx.strokeRect(0, 0, WIDTH, HEIGHT);
    rocks = [],
    apples = [];

    var textures = (function () {
        var gameObjectsCount = 10;

        function GameBlock(xPosition, yPosition) {
            this.xPosition = xPosition;
            this.yPosition = yPosition;
        }

        function generateGameObjects() {
            for (var i = 0; i < gameObjectsCount; i++) {
                rocks.push(new Rock());
                apples.push(new Apple());
            }
        }

        function drawElements(elements, color) {
            ctx.fillStyle = color;
            for (var i = 0; i < elements.length; i++) {
                ctx.fillRect(elements[i].xPosition, elements[i].yPosition, 10, 10);
            }
        }

        return {
            GameBlock: GameBlock,
            generateGameObjects: generateGameObjects,
            drawElements: drawElements
        }
    }());

    var snakeConstructor = (function () {
        function Snake(startLength, startX, startY) {
            this.head = new textures.GameBlock(startX, startY);
            snake = [startLength - 1];

            for (var i = 0; i < startLength - 1; i++) {
                snake[i] = new textures.GameBlock(startX - 10 * (i + 1), startY);
            }

            this.getSnake = function () {
                return snake;
            }
        }

        Snake.prototype.move = function () {
            snake.splice(snake.length - 1, 1);
            snake.unshift(new textures.GameBlock(this.head.xPosition, this.head.yPosition));
            this.head.xPosition += this.direction.x * 10;
            this.head.yPosition += this.direction.y * 10;
        }

        Snake.prototype.direction = {
            x: 1,
            y: 0
        }

        return {
            SnakeConstructor: Snake,
        }
    }());

    var Apple = (function () {
        function Apple() {
            var xPosition = Math.round((Math.random() * WIDTH - 10) / 10) * 10;
            var yPosition = Math.round((Math.random() * HEIGHT - 10) / 10) * 10;

            return new textures.GameBlock(xPosition, yPosition);
        }

        return Apple;
    }());

    var Rock = (function () {
        function Rock() {
            var xPosition = Math.round((Math.random() * WIDTH - 10) / 10) * 10;
            var yPosition = Math.round((Math.random() * HEIGHT - 10) / 10) * 10;

            return new textures.GameBlock(xPosition, yPosition);
        }

        return Rock;
    }());

    var movementController = (function snakeMovement() {
        var DIRECTION_KEYS = {
            LEFT: 37,
            UP: 38,
            RIGHT: 39,
            DOWN: 40
        };

        function movement() {
            window.addEventListener('keydown', function (e) {
                switch (e.keyCode) {
                    case DIRECTION_KEYS.LEFT:
                        if (playerSnake.direction.y === 1 || playerSnake.direction.y === -1) {
                            playerSnake.direction.x = -1;
                            playerSnake.direction.y = 0;
                        }
                        break;
                    case DIRECTION_KEYS.UP:
                        if (playerSnake.direction.x === 1 || playerSnake.direction.x === -1) {
                            playerSnake.direction.x = 0;
                            playerSnake.direction.y = -1;
                        }
                        break;
                    case DIRECTION_KEYS.RIGHT:
                        if (playerSnake.direction.y === 1 || playerSnake.direction.y === -1) {
                            playerSnake.direction.x = 1;
                            playerSnake.direction.y = 0;
                        }
                        break;
                    case DIRECTION_KEYS.DOWN:
                        if (playerSnake.direction.x === 1 || playerSnake.direction.x === -1) {
                            playerSnake.direction.x = 0;
                            playerSnake.direction.y = 1;
                        }
                        break;
                }
            }, false);
        }

        return {
            movement: movement,
        }
    }());

    var collisionController = (function () {
        var i = 0;
        var eatenApples = 0;

        function wallCollision() {
            var hitVerticalWall = (playerSnake.head.xPosition < 0 || playerSnake.head.xPosition > WIDTH);
            var hitHorizontalWall = (playerSnake.head.yPosition < 0 || playerSnake.head.yPosition > HEIGHT);

            if (hitVerticalWall || hitHorizontalWall) {
                return true;
            }
        }

        function snakeCollision() {
            for (i = 0; i < snake.length; i++) {
                if (playerSnake.head.xPosition === snake[i].xPosition && playerSnake.head.yPosition === snake[i].yPosition) {
                    return true;
                }
            }
        }
        
        function rockCollision() {
            for (i = 0; i < rocks.length; i++) {
                if (rocks[i].xPosition === playerSnake.head.xPosition && rocks[i].yPosition === playerSnake.head.yPosition) {
                    return true;
                }
            }
        }

        function appleCollision() {
            for (i = 0; i < apples.length; i++) {
                if (apples[i].xPosition === playerSnake.head.xPosition && apples[i].yPosition === playerSnake.head.yPosition) {
                    var newTailX = snake[snake.length - 1].xPosition * 2 - snake[snake.length - 2].xPosition;
                    var newTailY = snake[snake.length - 1].yPosition * 2 - snake[snake.length - 2].yPosition;

                    snake.push(new textures.GameBlock(newTailX, newTailY));
                    apples.splice(i, 1);
                    apples.push(new Apple());
                    score += 10;
                    eatenApples++;

                    if (eatenApples % 10 === 0) {
                        rocks.push(new Rock());
                    }
                }
            }
        }

        function detectCollision() {
            if (wallCollision() || snakeCollision() || rockCollision()) {
                return true;
            }

            appleCollision();
        }
        return {
            detectCollision: detectCollision
        }
    }());

    var gameEngine = (function () {
        var snakeSize = 6,
            snakeX = 40,
            snakeY = 20;

        function start() {
            playerSnake = new snakeConstructor.SnakeConstructor(snakeSize, snakeX, snakeY);
            movementController.movement();
            textures.generateGameObjects();

            var gameLoopControl = setInterval(function () {
                ctx.clearRect(1, 1, WIDTH - 2, HEIGHT - 2);
                textures.drawElements(snake, 'black');
                textures.drawElements(apples, 'red');
                textures.drawElements(rocks, 'gray');
                if (collisionController.detectCollision()) {
                    clearInterval(gameLoopControl);
                    alert("Your score is: " + score);
                }
                playerSnake.move();
                score += 1;
            }, 100);
        }

        return {
            start: start
        }
    }());
    
    gameEngine.start();
}());