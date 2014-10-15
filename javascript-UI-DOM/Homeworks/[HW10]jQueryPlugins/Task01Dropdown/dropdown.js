/// <reference path="/libraries/jquery-2.1.1.min.js" />

// This is how I understand this task. I get the old dropdown and hide it, after that I create new dropdown by the original one.
// I've used some styles but just to practice them so they're very ugly ;)
(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this);
        $this.css('display', 'none'); // hide the original dropdown

        var $container = $('<div />');
        $container.addClass('dropdown-list-container');
        $container.css('width', '100px');
        $container.css('border', '1px solid black');
        $container.css('cursor', 'context-menu');
    
        var $selectedItem = $('<div />');
        $selectedItem.css('padding-left', '5px');
        $selectedItem.css('background', '#43609C');
        $selectedItem.text('Select country');
        $container.append($selectedItem);

        var $ul = $('<ul />');
        $ul.css('list-style-type', 'none');
        $ul.css('padding', 0);
        $ul.css('margin', 0);
        $ul.css('display', 'none');
        $ul.css('background', 'yellow');

        var $li = $('<li />');
        $li.addClass('drop-down-list-option');
        $li.css('padding-left', '5px');
    
        var $options = $('option', $this);
        $options.each(function (index, value) {
            $li.text($(value).text());
            $li.attr('data-value', index + 1); // indexes in <select> starts from 1, and index from callback starts from 0
            $ul.append($li);
            $li = $li.clone();
        });

        $container.append($ul);
        $(document.body).append($container);
    
        $selectedItem.on('click', function () {
            $selectedItem.css('border-bottom', '1px solid black');
            $ul.css('display', 'block');
        });
    
        $ul.on('click', 'li.drop-down-list-option', function () {
            var $hasSelected = $('#dropdown :selected'); // Is there previously selected item
            if ($hasSelected) {
                $hasSelected.removeAttr('selected');
            }
            
            $this.find('option[value="' + $(this).attr('data-value') + '"]').attr('selected', 'selected'); // set the new selected item
            $ul.css('display', 'none');
            $selectedItem.css('border-bottom', 'none');
            $selectedItem.text($('#dropdown :selected').html());
            // Or this
            //$selectedItem.text($(this).html());
        })
        $ul.on('mouseover', 'li.drop-down-list-option', function () {
            $(this).css('background', 'green');
        })
        $ul.on('mouseout', 'li.drop-down-list-option', function () {
            $(this).css('background', 'yellow');
        })
    }
}(jQuery));