var pageDivs,
    result;

pageDivs = document.getElementsByTagName("div");
result = document.getElementById("result");

result.innerHTML = pageDivs.length;