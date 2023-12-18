using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace repair_management_backend.Hubs
{
    //[Authorize(Policy = "ReadWritePolicy")]
    public class NotificationHub : Hub
    {
        public override async System.Threading.Tasks.Task OnConnectedAsync()
        {
            await base.OnConnectedAsync();
        }
        public async System.Threading.Tasks.Task JoinGroup(int orderId)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, $"order-{orderId}"); 
        }

        public async System.Threading.Tasks.Task LeaveGroup(int orderId)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"order-{orderId}");
        }
    }
}
