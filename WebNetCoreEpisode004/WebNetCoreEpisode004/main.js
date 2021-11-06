//alert('Hello world from external');
/*
document.addEventListener('DOMContentLoaded', function () {
    
});

let btn = document.getElementById('btnAdd');
let btnRed = document.getElementById('btnRedAll');
let btnBlue = document.getElementById('btnBlueEven');

let list = document.querySelector('.main ul');

btn.onclick = function (e) {
    let item = document.createElement('li');
    item.textContent = `Item ${list.children.length + 1}`;
    list.appendChild(item);
};

btnRed.onclick = function (e) {
    let items = document.querySelectorAll('.main ul li');
    items.forEach((value, index) => {
        value.style.color = 'red';
        if ((index + 1) % 2 == 0) {
            value.style.color = 'green';
        }
    });
};

btnBlue.onclick = function (e) {
    let items = document
        .querySelectorAll('.main ul li:nth-child(even)');
    items.forEach((value, index) => {
        value.style.color = 'blue';
    });
};
*/

/*
let calculateBtn = document
    .querySelector('.computation form button[type=button]');
let num1 = document.getElementById('num1');
let num2 = document.getElementById('num2');
let resultContainer = document
    .getElementsByClassName('result')[0];

calculateBtn.addEventListener('click', function (e) {
    let value1 = Number(num1.value);
    let value2 = Number(num2.value);

    if (!isNaN(value1) && !isNaN(value2)) {
        let computedValue = value1 + value2;
        if (document.querySelector('select').value === '-') {
            computedValue = value1 - value2;
        }        
        resultContainer.innerHTML = `<p>Result: ${computedValue}</p>`;
    } else {
        resultContainer.innerHTML = 'Invalid operation';
    }
}, false);
*/
/*
let container = document.querySelector('ul');
for (let index = 1; index <= 10; index++) {
    let a = document.createElement('a');
    a.href = '#';
    a.text = '[X]';
    a.onclick = function(){
        container.removeChild(a.parentElement.parentElement);
    };
    let text = document.createElement('span');
    text.style.display = 'block';
    text.append('Item ' + index);
    text.append(a);
    let li = document.createElement('li')
    li.appendChild(text)
    container.appendChild(li);
}
*/
/*
let div = document.getElementById('testDiv');
document.querySelector('select')
    .addEventListener('change', function () {
        let value = this.value;
        switch (value) {
            case 'show':
                div.style.display = 'block';
                break;
            case 'hide':
                div.style.display = 'none';
                break;
            case 'colored':
                setDivClass('colored');
                break;
            case 'bordered':
                setDivClass('bordered');
                break;
        }
    });

document.querySelector('button')
    .addEventListener('click', function () {
        div.classList.toggle('bordered');
    });

function setDivClass(className) {
    if (!div.classList.contains(className)) {
        div.classList.add(className);
    }
}
*/
/*
document.getElementById('btn1')
    .addEventListener('click', commonClickEvent);
document.getElementById('btn2')
    .addEventListener('click', commonClickEvent);
document.getElementById('btn3')
    .addEventListener('click', (e) => {
        let number1 = Number(prompt('Input num1'));
        let number2 = Number(prompt('Input num2'));
        alert('Result: ' + AddNumbers(number1, number2));
        //alert(this);
    });

function commonClickEvent(e) {
    alert('Button Clicked ' + this.textContent);
}

function AddNumbers(num1, num2) {
    return num1 + num2;
}
*/

function Tao(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    let isDisabled = false;

    this.isAdult = function()  {
        return this.age >= 18;
    }
    this.getFullName = function() {
        return this.firstName + ' ' + this.lastName;
    }
    this.setDisabled = function (disabled) {
        isDisabled = disabled;
    }
}

let taoContainer = document.getElementsByClassName('container')[0];
document.getElementsByTagName("button")[0]
    .addEventListener('click', function () {
        var frace = new Tao('frace', 'marteja', 32);
        var programmerTV = new Tao();
        programmerTV.firstName = 'pro grammer';
        programmerTV['lastName'] = "TV";
        var test = new Object({
            firstName: 'frace', lastName: 'again',
            age: 100
        });
        var div1 = document.createElement('div');
        div1.innerHTML = `<p>${frace.getFullName()}</p>`;
        var div2 = document.createElement('div');
        div2.innerHTML = `<p>${programmerTV.getFullName()}</p>`;
        taoContainer.appendChild(div1);
        taoContainer.appendChild(div2);
    });
