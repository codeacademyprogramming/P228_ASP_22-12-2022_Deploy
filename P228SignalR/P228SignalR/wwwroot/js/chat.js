var connection = new signalR.HubConnectionBuilder().withUrl("/chathub").build();

connection.start();

//console.log(connection);

$(document).on("click", "#sendButton", function (e) {
    e.preventDefault();

    let name = $("#userInput").val();
    let message = $("#messageInput").val();

    //console.log(name + " " + message);

    //let li = `<li>${name} Says, ${message}</li>`;

    //$("#messagesList").append(li);

    connection.invoke("MesajGonder", name, message);
})


connection.on("MesajQebulEt", function (userName, message) {
    let li = `<li>${userName} Says, ${message}</li>`;

    $("#messagesList").append(li);

    //console.log(userName + " " + message);
})