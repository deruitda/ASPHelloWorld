function getHelloWorld() {
    for (i = 0; i <= 9; i++) {
        $.ajax({
            type: 'GET',
            url: 'api/HelloWorld',
            success: function (data) {
                $('#pTest').append(data + ', ');
            }
        });   
    }
}