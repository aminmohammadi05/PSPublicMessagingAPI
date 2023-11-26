using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;

namespace DesktopWinforms.Controllers;

public class CommunicationApplicationController : ICommunicationApplicationController
{
    //private object Uow;
    public IList<object> GetUserActions(string user)
    {
        throw new NotImplementedException();
    }

    public List<object> ClientActions { get; set; }
    public async Task<List<Notification>> GetUserUnreadNotifications(string user, string OU)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync("api/notifications");


            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<List<Notification>>(await response.Content.ReadAsStringAsync());
                return data;

            }

        }

        return null;
    }

    public Notification SetNotificationStatus(Guid notification, string lastModifierUser, NotificationStatus read)
    {
        throw new NotImplementedException();
    }

    public Notification GetNotificationById(Guid notificationId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Notification>> GetAllNotifications(string user, string OU)
    {
        throw new NotImplementedException();
    }

    public Task<List<Notification>> GetNotificationsByStatus(string user, string OU, NotificationStatus status)
    {
        throw new NotImplementedException();
    }

    public Task<Notification> SaveNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Task<List<Notification>> GetAllNotifications()
    {
        throw new NotImplementedException();
    }

    public async Task<List<UserRole>> GetUserRole(string userName)
    {

        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri("http://localhost:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

           
          
            var response = await client.GetAsync("api/userroles");


            if (response.IsSuccessStatusCode)
            {
                var data = JsonConvert.DeserializeObject<List<UserRole>>(await response.Content.ReadAsStringAsync());
                return data;

            }

        }

        return null;
    }

    public void RunCreateNewNotification()
    {
        throw new NotImplementedException();
    }

    public Task<int> RemoveNotification(Guid notificationId)
    {
        throw new NotImplementedException();
    }

    IToastService _toastService;
    IServiceProvider _services;
    public CommunicationApplicationController(IToastService toastService, IServiceProvider services)
    {
        _toastService = toastService;
        _services = services;
        #region Dispatcher Config

        // Ignore unhandled exceptions
        //Dispatcher.CurrentDispatcher.UnhandledException += CurrentDispatcherUnhandledException;

        //AppDomain.CurrentDomain.UnhandledException += CurrentDomainUnhandledException;
        //TaskScheduler.UnobservedTaskException += TaskSchedulerUnobservedTaskException;
        //  Uow = new CommunicationServiceReference.CommunicationServiceClient();

        //chats.ConnectionFailed += ConnectionFailedHandler;
        //chats.Connected += ConnectedHandler;
        //chats.UserConnected += UserConnectedHandler;
        //chats.Disconnected += DisconnectedHandler;
        //chats.UserDisconnected += UserDisconnectedHandler;
        //chats.Broadcasted += BroadcastedHandler;
        //chats.UserBroadcasted += UserBroadcastedHandler;
        //chats.Whispered += WhisperedHandler;
        //chats.UserWhispered += UserWhisperedHandler;

        #endregion
    }

}