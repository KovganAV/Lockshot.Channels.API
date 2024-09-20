const connection = new signalR.HubConnectionBuilder()
    .withUrl("/chatHub")
    .build();

connection.on("ReceiveMessage", (userId, message) => {
    console.log(`Message from ${userId}: ${message}`);
});

connection.start().catch(err => console.error(err));

function sendMessage(serverId, userId, message) {
    connection.invoke("SendMessage", serverId, userId, message)
        .catch(err => console.error(err));
}
