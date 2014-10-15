function onClickClearStorage() {
    localStorage.clear();

    while (results.firstChild) {
        results.removeChild(results.firstChild);
    }
}

function onClickStartGame() {
    var results = document.getElementById('results'),
        canvas = document.getElementById('the-canvas'),
        WIDTH = canvas.width,
        HEIGHT = canvas.height,
        ctx = canvas.getContext('2d'),
        playerSnake = new Snake(6, 40, 20),
        apples = [],
        score = 0;

    ctx.strokeRect(0, 0, WIDTH, HEIGHT);
    snakeMovement();

    for (var j = 0; j < 10; j++) {
        apples.push(generateApple());
    }

    gameLoopControl = setInterval(function () {
        ctx.clearRect(1, 1, WIDTH - 2, HEIGHT - 2);
        drawElements(snake, 'black');
        drawElements(apples, 'red');
        detectCollision();
        playerSnake.move();
        score += 1;
    }, 100);

    function detectCollision() {
        var hitVerticalWall = (playerSnake.head.xPosition < 0 || playerSnake.head.xPosition > WIDTH);
        var hitHorizontalWall = (playerSnake.head.yPosition < 0 || playerSnake.head.yPosition > HEIGHT);

        if (hitVerticalWall || hitHorizontalWall) {
            endGame();
            return;
        }

        for (var i = 0; i < snake.length; i++) {
            if (playerSnake.head.xPosition === snake[i].xPosition && playerSnake.head.yPosition === snake[i].yPosition) {
                endGame();
                return;
            }
        }

        for (var i = 0; i < apples.length; i++) {
            if (apples[i].xPosition === playerSnake.head.xPosition && apples[i].yPosition === playerSnake.head.yPosition) {
                var newTailX = snake[snake.length - 1].xPosition * 2 - snake[snake.length - 2].xPosition;
                var newTailY = snake[snake.length - 1].yPosition * 2 - snake[snake.length - 2].yPosition;
                snake.push(new GameBlock(newTailX, newTailY));
                apples.splice(i, 1);
                apples.push(generateApple());
                score += 10;
            }
        }
    }

    function endGame() {
        clearInterval(gameLoopControl);
        var playerName = prompt("Your score is: " + score + "Enter your name: ");

        if (!playerName) {
            playerName = 'unknown';
        }
        
        localStorage.setItem(score, playerName);
        showScore();
    }

    function showScore() {
        while (results.firstChild) {
            results.removeChild(results.firstChild);
        }
        var div = document.createElement('div');
        var docFragment = DocumentFragment();
    
        for (var storedScore in localStorage) {
            div = div.cloneNode(false);
            div.innerHTML = localStorage[storedScore] + " - " + storedScore;
            docFragment.appendChild(div);
        }

        results.appendChild(docFragment);
    }

    function Snake(startLength, startX, startY) {
        this.head = new GameBlock(startX, startY);
        snake = new Array(startLength - 1);

        for (var i = 0; i < startLength - 1; i++) {
            snake[i] = new GameBlock(startX - 10 * (i + 1), startY);
        }

        this.getSnake = function () {
            return snake;
        }
    }

    Snake.prototype.move = function () {
        snake.splice(snake.length - 1, 1);
        snake.unshift(new GameBlock(this.head.xPosition, this.head.yPosition));
        this.head.xPosition += this.direction.x * 10;
        this.head.yPosition += this.direction.y * 10;
    }

    Snake.prototype.direction = {
        x: 1,
        y: 0
    }

    function generateApple() {
        var appleXPosition = Math.round((Math.random() * WIDTH - 10) / 10) * 10;
        var appleYPosition = Math.round((Math.random() * HEIGHT - 10) / 10) * 10;
        return new GameBlock(appleXPosition, appleYPosition);
    }

    function drawElements(elements, color) {
        ctx.fillStyle = color;
        for (var i = 0; i < elements.length; i++) {
            ctx.fillRect(elements[i].xPosition, elements[i].yPosition, 10, 10);
        }
    }

    function GameBlock(xPosition, yPosition) {
        this.xPosition = xPosition;
        this.yPosition = yPosition;
    }

    function snakeMovement() {
        window.addEventListener('keydown', function (e) {
            switch (e.key) {
                case "Up":
                    if (playerSnake.direction.x !== 0 && playerSnake.direction.y !== 1) {
                        playerSnake.direction.x = 0;
                        playerSnake.direction.y = -1;
                    }
                    break;
                case "Right":
                    if (playerSnake.direction.x !== -1 && playerSnake.direction.y !== 0) {
                        playerSnake.direction.x = 1;
                        playerSnake.direction.y = 0;
                    }
                    break;
                case "Down":
                    if (playerSnake.direction.x !== 0 && playerSnake.direction.y !== -1) {
                        playerSnake.direction.x = 0;
                        playerSnake.direction.y = 1;
                    }
                    break;
                case "Left":
                    if (playerSnake.direction.x !== 1 && playerSnake.direction.y !== 0) {
                        playerSnake.direction.x = -1;
                        playerSnake.direction.y = 0;
                    }
                    break;
            }
        }, false);
    }
}