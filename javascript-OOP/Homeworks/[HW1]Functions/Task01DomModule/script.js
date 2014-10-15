var domModule = (function () {
    var buffer = {};
    
    function appendToParent(element, selector) {
        var parentElement = document.querySelectorAll(selector);

        for (var i = 0, len = parentElement.length; i < len ; i++) {
            parentElement[i].appendChild(element);
        }
    }

    function removeElement(element, selector) {
        var selectedElement = document.querySelectorAll(element);

        for (var i = 0, len = selectedElement.length; i < len; i++) {
            var currentElement = selectedElement[i].querySelector(selector);

            selectedElement[i].removeChild(currentElement);
        }
    }

    function attachEvent(selector, eventType, handler) {
        var elements = document.querySelectorAll(selector);

        for (var i = 0, len = elements.length; i < len; i++) {
            elements[i].addEventListener(eventType, handler);
        }
    }
    
    function appendToBuffer(selector, element) {
        var hasContainer = document.querySelector(selector);

        if (hasContainer) {
            buffer[selector] = buffer[selector] || [];
            buffer[selector].push(element);
        } else {
            throw 'No such element in DOM'; // If there is no such container to append items
        }

        if (buffer[selector].length === 100) {
            var selectedContainers = document.querySelectorAll(selector);  // Get all containers

            buffer[selector].forEach(function (el, index, array) {
                for (var i = 0, len = selectedContainers.length; i < len; i++) {
                    selectedContainers[i].appendChild(el); // Append buffered elements to all containers
                }
            });

            delete buffer[selector]; // Delete specific element by selector
        }
    } 

    return {
        appendChild: appendToParent,
        removeChild: removeElement,
        addHandler: attachEvent,
        appendToBuffer: appendToBuffer
    }
}());