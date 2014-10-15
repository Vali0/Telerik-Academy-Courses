/// <reference path="/Exam17JuneEvening\Task02Gallery\jquery.min.js" />
/// <reference path="C:\Users\Valentin\Desktop\JS UI & DOM Exams\Exam17JuneEvening\Task02Gallery\jquery.min.js" />


$.fn.gallery = function () {
    var $gallery = $(this);
    $gallery.addClass('gallery');
    var columns = arguments[0] || 4;
    $gallery.width((250 + 10) * columns + 'px');

    $selectedItems = $('.selected');
    $selectedItems.children().remove();

    var $galleryList = $gallery.find('.gallery-list');
    $galleryList.on('click', '.image-container', enlargeImages);

    function previousImage() {
        $selectedImage = $(this);
        var dataInfo = $selectedImage.attr('data-info') | 0;
      
        $('img#previous-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo - 1) + '"]').attr('src'));
        $('img#previous-image').attr('data-info', (dataInfo - 1));
        $('img#current-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo) + '"]').attr('src'));
        $('img#current-image').attr('data-info', (dataInfo));
        $('img#next-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo + 1) + '"]').attr('src'));
        $('img#next-image').attr('data-info', (dataInfo + 1));
    }

    function nextImage() {
        $selectedImage = $(this);
        var dataInfo = $selectedImage.attr('data-info') | 0;
        $('img#previous-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo - 1) + '"]').attr('src'));
        $('img#previous-image').attr('data-info', (dataInfo - 1))
        $('img#current-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo) + '"]').attr('src'));
        $('img#current-image').attr('data-info', (dataInfo));
        $('img#next-image').attr('src', $galleryList.find('img[data-info="' + (dataInfo + 1) + '"]').attr('src'));
        $('img#next-image').attr('data-info', (dataInfo + 1));
    }

    function exitEnlargeView() {
        $selectedItems.children().remove();
        $galleryList.on('click', '.image-container', enlargeImages);
        $galleryList.css('opacity', 1);
    }

    function enlargeImages() {
        $selectedItems.children().remove();
        var $this = $(this);
        // previous
        var $prevDiv = $('<div />');
        $prevDiv.addClass('previous-image');
        var $previousImage = $this.prev().children().clone();
        $previousImage.attr('id', 'previous-image');
        $prevDiv.append($previousImage);
        $selectedItems.append($prevDiv);

        // current
        var $currentDiv = $('<div />');
        $currentDiv.addClass('current-image');
        var $currentImage = $this.children().clone();
        $currentImage.attr('id', 'current-image');
        $currentDiv.append($currentImage);
        $selectedItems.append($currentDiv);

        // next
        var $nextDiv = $('<div />');
        $nextDiv.addClass('next-image');
        var $nextImage = $this.next().children().clone();
        $nextImage.attr('id', 'next-image');
        $nextDiv.append($nextImage);
        $selectedItems.append($nextDiv);

        $('#previous-image').on('click', previousImage);
        
        $('#next-image').on('click', nextImage);

        $('#current-image').on('click', exitEnlargeView);

        $galleryList.css('opacity', 0.2);
        //$galleryList.off('click',enlargeImages);
        $galleryList.unbind('click', enlargeImages);
    }
}