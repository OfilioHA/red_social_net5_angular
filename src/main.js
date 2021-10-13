$(function () {
    $("body").on("submit", "#form-buscador", async (event) => {
        event.preventDefault();
        if ($("#username").val() === "") { return; }
        const username = $("#username").val();
        const userList = await $.post('/user/find', { username });
        if (userList.length > 0) {
            $("#search-box").removeClass('d-none');
            $("#search-box").append(userList);
            $("html").one('click', function (e) {
                if (!$(e.target).is('#search-box')) {
                    $("#search-box").addClass('d-none');
                    $("#search-box").children().remove();
                }
            });
        }
    })
})