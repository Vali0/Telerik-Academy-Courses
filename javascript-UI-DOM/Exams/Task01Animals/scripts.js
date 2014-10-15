function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    container.style.cssFloat = 'left';
    container.style.padding = '50px 15px 50px 50px';
    container.style.border = '1px solid black';

    var previewContainer = document.createElement('div');
    previewContainer.id = 'preview-container';
    previewContainer.style.cssFloat = 'left';
    previewContainer.style.display = 'inline-block';
    previewContainer.style.height = '400px';
    previewContainer.style.marginRight = '50px';

    var animalsAsideList = document.createElement('div');
    animalsAsideList.style.width = '155px';
    animalsAsideList.style.height = '400px';
    animalsAsideList.style.cssFloat = 'left';
    animalsAsideList.style.overflowX = 'auto';
    animalsAsideList.style.paddingLeft = '10px';

    var filterBox = document.createElement('div');
    var filter = document.createElement('input');
    var filterTitle = document.createElement('div');

    filterTitle.innerHTML = 'Filter';
    filterTitle.style.marginLeft = '55px';
    filter.type = 'text';
    filter.style.width = '110px';
    filter.style.marginLeft = '10px';
    filter.addEventListener('change', filterAnimals);

    filterBox.appendChild(filterTitle)
    filterBox.appendChild(filter);
    animalsAsideList.appendChild(filterBox);

    function filterAnimals() {
        var inputFieldValue = this.value;
        var animals = document.getElementsByClassName('animal-container');
        var fileredElements = document.createDocumentFragment();

        var pattern = new RegExp(inputFieldValue, 'i');

        for (var i = 0, aLen = animals.length; i < aLen; i++) {
            if (animals[i].firstChild.innerHTML.search(pattern) !== -1) {
                fileredElements.appendChild(animals[i].cloneNode(true));
            }
        }

        removeAnimals();
        animalsAsideList.appendChild(fileredElements);
        container.appendChild(animalsAsideList);
    }

    var animalKind = document.createElement('div');
    animalKind.align = 'center';
    animalKind.style.fontWeight = 'bold';

    var picture = document.createElement('img');
    picture.style.width = '120px';
    picture.style.height = '100px';
    picture.style.borderRadius = '10px';
    picture.style.display = 'block';
    picture.style.paddingBottom = '5px';
    picture.style.marginLeft = '10px';

    var singleAnimalContainer = document.createElement('div');
    singleAnimalContainer.className = 'animal-container';

    for (var i = 0, len = items.length; i < len; i++) {
        animalKind.innerHTML = items[i].title;
        picture.alt = items[i].title;
        picture.src = items[i].url;

        picture.addEventListener('click', previewAnimal);
        singleAnimalContainer.addEventListener('mouseover', onMouseOverAnimalanimalsAsideList);
        singleAnimalContainer.addEventListener('mouseout', onMouseOutAnimalanimalsAsideList);

        singleAnimalContainer.appendChild(animalKind);
        singleAnimalContainer.appendChild(picture);
        animalsAsideList.appendChild(singleAnimalContainer);

        animalKind = animalKind.cloneNode(false);
        picture = picture.cloneNode(false);
        singleAnimalContainer = singleAnimalContainer.cloneNode();
    }

    function onMouseOverAnimalanimalsAsideList() {
        this.style.background = '#ccc';
    }
    function onMouseOutAnimalanimalsAsideList() {
        this.style.background = '#fff';
    }

    function previewAnimal() {
        var selectedPicture = this.cloneNode(false);
        var title = document.createElement('div');

        selectedPicture.style.width = '400px';
        selectedPicture.style.height = '300px';
        selectedPicture.style.marginLeft = 0;

        title.innerHTML = selectedPicture.alt;
        title.align = 'center';
        title.style.marginBottom = '10px';
        title.style.fontSize = '2em';
        title.style.fontWeight = 'bold';

        previewContainer.innerHTML = '';
        previewContainer.appendChild(title);
        previewContainer.appendChild(selectedPicture);
    }

    function removeAnimals() {
        var animals = document.getElementsByClassName('animal-container');

        while (animals.length!==0) {
            animals[0].parentNode.removeChild(animals[0]);
        }
    }
    
    function initializePreviewContainer() {
        var selectedPicture = document.createElement('img');
        selectedPicture.src = items[0].url;
        selectedPicture.style.borderRadius = '10px';
        var title = document.createElement('div');

        title.innerHTML = items[0].title;
        title.align = 'center';
        title.style.marginBottom = '10px';
        title.style.fontSize = '2em';
        title.style.fontWeight = 'bold';

        selectedPicture.style.width = '400px';
        selectedPicture.style.height = '300px';

        previewContainer.innerHTML = '';
        previewContainer.appendChild(title);
        previewContainer.appendChild(selectedPicture);
    }

    initializePreviewContainer();

    container.appendChild(previewContainer);
    container.appendChild(animalsAsideList);
}