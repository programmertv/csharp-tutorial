let baseModel = {
    baseURL: '',
    getModal: function () {
        return $('#dataModal');
    },
    getTable: function () {
        return $('#dataTable');
    },
    getCreateButton: function () {
        return $('.card-body button:first-child');
    },
    getSaveButton: function () {
        return $('#dataModal .modal-footer button:nth-child(2)');
    },
    getForm: function () {
        return $('#dataModal form');
    },
    getId: function () {
        return this.getForm().find('input[type=hidden][name=id]').val() | 0;
    }
};

function ajax_post(options) {
    options.contentType = 'application/json';
    options.error = function (e) {
        alert('May error while processing your request!');
    }
    $.ajax(options);
}

function ajax_get(options) {
    $.get(options);
}

function editDeleteButtonFormatter(el, row) {
    return `<button type='button' class='btn btn-warning' onclick='edit(${row.id})'><i class='fa fa-edit'></i> Edit</button>&nbsp` +
        `<button type='button' class='btn btn-danger' onclick='deleteRow(${row.id})'><i class='fa fa-trash'></i> Delete</button>&nbsp`;
}

$(function () {
    baseModel.getCreateButton().click(function () {
        baseModel.getForm().trigger('reset');
        baseModel.getForm().find('input[type=hidden][name=id]').val('');
    });
    baseModel.getSaveButton().click(function () {
        let data = baseModel.postedData();
        if (baseModel.getId() == 0)
            create(data);
        else
            update(data);
    });
});

function save(data, type) {
    ajax_post({
        url: baseModel.baseURL,
        data: data,
        type: type,
        success: function () {
            baseModel.getTable().bootstrapTable('refresh');
            baseModel.getModal().modal('hide');
        }
    });
}

//CRUD Operations

function create(data) {
    save(data, 'post');
}

function retrieve(id, callback) {
    console.log(id);
    ajax_get({ url: baseModel.baseURL + id, success: callback });
}

function update(data) {
    save(data, 'put');
}

function deleteRow(id) {
    if (!confirm('Are you sure you want to delete this record?'))
        return;

    ajax_post({
        url: baseModel.baseURL + id,
        type: 'delete',
        success: function () {
            baseModel.getTable().bootstrapTable('refresh');
        }
    });
}