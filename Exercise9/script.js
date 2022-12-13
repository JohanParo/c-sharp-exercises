
const btn1 = document.querySelector('#btn1');
const formBtn = document.querySelector('#form-submit');
const form = document.querySelector('#bishbosh-form');
const bishNumber = document.querySelector('#bish-number');
const boshNumber = document.querySelector('#bosh-number');
const totalCount = document.querySelector('#count-number');
const results = document.querySelector('#results');

function checkIfBish(input, bishnumber) {
    if ((input%bishnumber) === 0) {
        return true;
    }
    else {
        return false;
    }
};

function checkIfBosh(input, boshnumber) {
    if ((input%boshnumber) === 0) {
        return true;
    }
    else {
        return false;
    }
};

btn1.addEventListener('click', function(e){
    for (let i = 100; i > 0; i--) {
        
        if(checkIfBish(i, 3)) {
            if (checkIfBosh(i, 4)) {
                console.log('Bish-Bosh');
            }
            else {
                console.log('Bish');
            }
        }
        else if (checkIfBosh(i, 4)) {
            console.log('Bosh');
        }
        else {
            console.log(i);
        }
    }
});

formBtn.addEventListener('click', function(e) {
    for (let i = totalCount.value; i > 0; i--) {
        if (checkIfBish(i, bishNumber.value)) {
            if (checkIfBosh(i, boshNumber.value)) {
                const tmp = document.createElement("p");
                tmp.innerText = 'Bish-Bosh';
                results.appendChild(tmp);
            }
            else {
                const tmp = document.createElement("p");
                tmp.innerText = 'Bish';
                results.appendChild(tmp);
            }
        }
        else if (checkIfBosh(i, boshNumber.value)) {
            const tmp = document.createElement("p");
            tmp.innerText = 'Bosh';
            results.appendChild(tmp);
        }
        else {
            const tmp = document.createElement("p");
            tmp.innerText = i;
            results.appendChild(tmp);
        }
    }
});