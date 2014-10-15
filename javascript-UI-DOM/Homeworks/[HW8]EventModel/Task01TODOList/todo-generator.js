var list = document.getElementById('todo-list');

list.addEventListener('click', removeSelected, false);

function addTODO() {
    var todo = document.getElementById('todo-description').value;
    var todoTask = document.createTextNode(todo); // Escape all special symbol <,> e.c.
    var item = document.createElement('a');
    item.appendChild(todoTask);
    var li = document.createElement('li');
    li.appendChild(item);
    list.appendChild(li);
}

function removeTODO() {
    var selectedItems = document.getElementsByClassName('selected');
    
    while (selectedItems.length) {
        selectedItems[0].parentNode.removeChild(selectedItems[0]); // remove li tag
    }
}

function removeSelected(event) {
    var target = event.target;

    if (target.nodeName === 'A' && target.parentNode.className === 'selected') {
        target.parentNode.removeAttribute('class');
        target.style.backgroundColor = 'white';
    } else if (target.nodeName==='A') {
        target.parentNode.className = "selected"
        target.style.backgroundColor = 'red';
    }
}