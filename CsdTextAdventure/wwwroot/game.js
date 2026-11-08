document.addEventListener("DOMContentLoaded", function () {
    var command = document.getElementById("command");
    command.focus();
    document.getElementById("commandForm").addEventListener("submit", function (event) {
        event.preventDefault();
        fetch("/command?command=" + encodeURIComponent(command.value))
            .then(function (response) { return response.text(); })
            .then(function (html) {
                document.getElementById("gameInfo").innerHTML = html;
                command.value = "";
            });
    });
});
