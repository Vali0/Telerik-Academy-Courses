/// <reference path="/Scripts/jquery-2.1.1.min.js" />

var slides = [
    '<img src="http://img2.wikia.nocookie.net/__cb20120727190507/villains/images/d/de/FOR_BRITIAN!!!.jpg" width=500px/>',

    '<section><article><h1>Lorem Ipsum</h1><p>some dummy text</p><span>I will be at Iron Maiden concert at 17.06.2014</span></article></section>',

    '<ul><li><a href="#">link</a></li><li><a href="#">link</a></li><li><a href="#">link</a></ul>',

    '<table><thead><tr><th>First name</th><th>Last name</th></tr></thead><tbody><tr><td>Bruce</td><td>Dickinson</td></tr><tr><td>Adrian</td><td>Smith</td></tr><tr><td>Steve</td><td>Harris</td</tr><tr><td>Dave</td><td>Murray</td></tr><tr><td>Nicko</td><td>McBrain</td></tr><tr><td>Janick</td><td>Gers</td></tr></tbody></table>'
];

(function () {
    var currentSlide = 0;
    setSlideToCurrent();
    $('#prev-slide').on('click', prevSlide);
    $('#next-slide').on('click', nextSlide);

    function nextSlide() {
        currentSlide++;
        currentSlide = currentSlide % slides.length;
        setSlideToCurrent();
        resetTimer();
    }

    function prevSlide() {
        currentSlide--;
        if (currentSlide < 0) {
            currentSlide = slides.length - 1;
        }

        setSlideToCurrent();
        resetTimer();
    }

    function setSlideToCurrent() {
        $('#current-slide').html(slides[currentSlide]);
    }

    function resetTimer() {
        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(nextSlide, 5000);
    }

    var autoSlideChanger = setInterval(nextSlide, 5000);
}());