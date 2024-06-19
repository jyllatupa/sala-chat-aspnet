using Microsoft.AspNetCore.SignalR;

namespace SalaChat
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(int room, string user, string message)
        {
            //Enviar mensaje de forma asincrona
            await Clients.Group(room.ToString()).SendAsync("RecibirMensaje", user, message);
        }

        public async Task AddToGroup(string room)
        {
            //Añadimos a la persona a la sala (room) de chat
            await Groups.AddToGroupAsync(Context.ConnectionId, room);

            await Clients.Group(room).SendAsync("ShowWho", $"Alguien se conecto {Context.ConnectionId}");
        }
    }
}
