$(function () {

    var baseUri = "https://localhost:44334/api/persons";
    $(document).ready(function () {

        $('#addNewBtn').on('click', postPerson);
        $('#changeBtn').on('click', putPerson);
        $('#deleteBtn').on('click', deletePerson);
    });
    function postPerson() {
        alert('cccc');
    }
    function putPerson() {

        var id = $("#numberOfElement").val(),
            newValue = $("#changeName").val();

        var value = {
            id: 1,
            firstName: newValue,
            lastName: newValue,
            age: 21,
            city: "London"
        };

        var dfdfdfd = JSON.stringify(value);

        $.ajax({
            uri: baseUri + "/" + id,
            type: 'PUT',
            data: dfdfdfd,
            dataType: 'json',
            contentType: 'application/json',

            success: function (data, status, xhr) {
                alert('Элемент' + id + 'изменен');
                //loadList();  
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert(xhr.status);
                alert(thrownError);
            }
        });
    }
});