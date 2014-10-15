var result,
    numbers = [];

for (var i = 0; i < 20; i++) {
    numbers.push(i * 5);
}

result = document.getElementById("result");

result.innerHTML = numbers.join(", ");