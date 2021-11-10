baseModel.baseURL = '/api/user/';
baseModel.postedData = function () {
    let form = baseModel.getForm();
    let json = JSON.stringify(
        {
            id: baseModel.getId() | 0,
            email: form.find('input[name=email]').val(),
            password: form.find('input[name=password]').val()
        }
    );

    return json;
}

function edit(id) {
    retrieve(id, function (response) {
        let form = baseModel.getForm();
        form.find('input[type=hidden][name=id]').val(response.id);
        form.find('input[name=email]').val(response.email);
        form.find('input[name=password]').val(response.password);

        baseModel.getModal().modal('show');
    });
}