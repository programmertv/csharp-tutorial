baseModel.baseURL = '/api/hero/';
baseModel.postedData = function () {
    let form = baseModel.getForm();
    let json = JSON.stringify(
        {
            id: baseModel.getId() | 0,
            name: form.find('input[name=name]').val(),
            age: parseInt(form.find('input[name=age]').val())
        }
    );

    return json;
}

function edit(id) {
    retrieve(id, function (response) {
        let form = baseModel.getForm();
        form.find('input[type=hidden][name=id]').val(response.id);
        form.find('input[name=name]').val(response.name);
        form.find('input[name=age]').val(response.age);

        baseModel.getModal().modal('show');
    });
}