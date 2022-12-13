let counter = 0;

const btn1 = document.querySelector('#btn-add');
const item = document.querySelector('#add-to-list');
const list = document.querySelector('#the-list');

const addToList = function(newItem) {
    
    const tmp = document.createElement("p");
    tmp.innerText = newItem;
    list.appendChild(tmp);
    counter++;
}


btn1.addEventListener('click', function(e) {
    console.log(item.value);
    addToList(item.value);
});