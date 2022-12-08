
const btn1 = document.querySelector('#btn1');

function checkIfBish(input) {
    if ((input%3) === 0) {
        return true;
    }
    else {
        return false;
    }
};

function checkIfBosh(input) {
    if ((input%4) === 0) {
        return true;
    }
    else {
        return false;
    }
};



btn1.addEventListener('click', function(e){
    for (let i = 100; i > 0; i--) {
        
        if(checkIfBish(i)) {
            if (checkIfBosh(i)) {
                console.log('Bish-Bosh');
            }
            else {
                console.log('Bish');
            }
        }
        else if (checkIfBosh(i)) {
            console.log('Bosh');
        }
        else {
            console.log(i);
        }
    }
});