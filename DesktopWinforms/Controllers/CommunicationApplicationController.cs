using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using PSPublicMessagingAPI.Desktop.ViewModels;
using DesktopWinforms.Models;
using PSPublicMessagingAPI.SharedToastMessage.Services;
using DevExpress.Utils.MVVM.Services;
using System.Text.Json;
using AutoMapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Views;
using Microsoft.Extensions.DependencyInjection;

namespace PSPublicMessagingAPI.DesktopWinforms.Controllers;

public class CommunicationApplicationController : ICommunicationApplicationController
{
    //private object Uow;
    public IList<object> GetUserActions(string user)
    {
        throw new NotImplementedException();
    }

    public List<object> ClientActions { get; set; }
    public async Task<List<NotificationDto>> GetUserUnreadNotificationsAsync(string user, string OU)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/notifications/{user}");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<NotificationDto>>(t,new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<NotificationDto> SetNotificationStatusAsync(NotificationDto notification)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using StringContent jsonContent = new (
                JsonSerializer.Serialize(notification),
                Encoding.UTF8,
                "application/json");


            var response = await client.PostAsync($"api/notifications", jsonContent);


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<NotificationDto>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async  Task<NotificationDto> GetNotificationByIdAsync(Guid notificationId)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/notifications/{notificationId.ToString()}");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<NotificationDto>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }
    public NotificationDto GetNotificationById(Guid notificationId)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = client.GetAsync($"api/notifications/{notificationId.ToString()}").Result;


            if (response.IsSuccessStatusCode)
            {
                var t = response.Content.ReadAsStringAsync().Result;
                var data = JsonSerializer.Deserialize<NotificationDto>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<List<NotificationDto>> GetAllNotificationsByUsernameAsync(string user, string OU)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/notifications/{user}");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<NotificationDto>>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<List<NotificationDto>> GetNotificationsByStatusAsync(string user, string OU, NotificationStatus status)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/notifications/{user}/{(int)status}");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<NotificationDto>>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<NotificationDto> SaveNotificationAsync(NotificationDto notification)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(notification),
                Encoding.UTF8,
                "application/json");


            var response = await client.PostAsync($"api/notifications", jsonContent);


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<NotificationDto>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<List<NotificationDto>> GetAllNotificationsAsync()
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/notifications/");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<NotificationDto>>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public async Task<List<UserRole>> GetUserRoleAsync(string userName)
    {

        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

           
          
            var response = await client.GetAsync("api/userroles");


            if (response.IsSuccessStatusCode)
            {
                var data = JsonSerializer.Deserialize<List<UserRole>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }

    public void RunCreateNewNotification()
    {
        var view = new NewNotification(_toastService, _services.GetRequiredService<IActiveDirectoryService>(), _services.GetRequiredService<IMapper>());

        var presenter = new NewNotificationPresenter(view, this);
        presenter.Run();
    }

    public async Task<Guid> RemoveNotificationAsync(Guid notificationId)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:5000/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           


            var response = await client.DeleteAsync($"api/notifications/{notificationId}");


            if (response.IsSuccessStatusCode)
            {
                
                return notificationId;

            }

        }

        return Guid.Empty;
    }

    IToastService _toastService;
    private readonly IServiceProvider _services;
    public IConfigurationManagerService _configurationManager;

    public CommunicationApplicationController(IToastService toastService, IServiceProvider services)
    {
        _toastService = toastService;
        _services = services;
        _configurationManager = _services.GetRequiredService<IConfigurationManagerService>();

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