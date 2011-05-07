$('#Track').change(function (ev) {
    var url = "/sessions/" + $(this).val();

    document.location = url;

    return false;
});