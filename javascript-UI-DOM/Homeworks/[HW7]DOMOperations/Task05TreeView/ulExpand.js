var liTags = document.getElementsByTagName("li");

for (var i = 0; i < liTags.length; i++) {
    liTags[i].addEventListener("click", expandList, false);
}

function expandList(event) {
    if (typeof this.getElementsByTagName("ul")[0] === "undefined") {
        return 0;
    }
    
    if (this === event.target && this.getElementsByTagName("ul")[0].style.display === "block") {
        this.getElementsByTagName("ul")[0].style.display = "none";
    } else {
        this.getElementsByTagName("ul")[0].style.display = "block";
    }
}