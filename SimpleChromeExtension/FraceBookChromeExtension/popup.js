$(function () {
    $('#btnCalculate').click(function () {        
        let num1 = parseInt($('#input1').val());
        let num2 = parseInt($('#input2').val());
        let op = $('#operator').val();
        let resultPlaceholder = $('#spanResult');
        switch (op) {
            case '+':
                resultPlaceholder.text(num1 + num2);
                break;
            case '-':
                resultPlaceholder.text(num1 - num2);
                break;
            case '*': resultPlaceholder.text(num1 * num2);
                break;
            case '/':
                resultPlaceholder.text(num1 / num2);
                break;
        }
    });
});