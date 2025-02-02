﻿using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Services;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net.Http.Json;
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
using System.Windows.Threading;

namespace PSPublicMessagingAPI.DesktopWinforms.Controllers;

public class CommunicationApplicationController : ICommunicationApplicationController
{
    //private object Uow;
    public IList<object> GetUserActions(string user)
    {
        throw new NotImplementedException();
    }

    public List<object> ClientActions { get; set; }

    #region Notifications
    

    public async Task<Guid> SetNotificationStatusAsync(NotificationDto notification)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(notification),
                Encoding.UTF8,
                "application/json");


            var response = await client.PutAsync($"api/publicnotifications", jsonContent);


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<Guid>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return Guid.Empty;
    }

    public NotificationDto GetNotificationByIdAsync(Guid notificationId)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = client.GetAsync($"api/publicnotifications/{notificationId.ToString()}").Result;


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
    public NotificationDto GetNotificationById(Guid notificationId)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = client.GetAsync($"api/publicnotifications/{notificationId.ToString()}").Result;


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

    public async Task<List<NotificationDto>> GetAllNotificationsByOUAsync(string OU)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/publicnotifications/{OU}");


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

    public async Task<List<NotificationDto>> GetNotificationsByStatusAsync(string OU, NotificationStatus status)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/publicnotifications/{OU}/{(int)status}");


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

    public async Task<Guid> SaveNotificationAsync(NotificationDto notification)
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            using StringContent jsonContent = new(
                JsonSerializer.Serialize(notification),
                Encoding.UTF8,
                "application/json");


            var response = await client.PostAsync($"api/publicnotifications", jsonContent);


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<Guid>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return Guid.Empty;
    }
    public async Task<List<NotificationDto>> GetAllNotificationsAsync()
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/publicnotifications/");


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

    public async Task<UserRole> GetUserRoleAsync(string userName)
    {

        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/user-roles/{userName}");


            if (response.IsSuccessStatusCode)
            {
                var data = JsonSerializer.Deserialize<UserRole>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions
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

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.DeleteAsync($"api/publicnotifications/{notificationId}");


            if (response.IsSuccessStatusCode)
            {

                return notificationId;

            }

        }

        return Guid.Empty;
    }
    #endregion
    #region Possible Actions
    public async Task<List<PossibleActionDto>> GetAllPossibleActionsAsync()
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/possibleactions/");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<PossibleActionDto>>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }
    #endregion
    #region Client Actions
    public async Task<List<ClientActionDto>> GetAllClientActionsAsync()
    {
        using (var client = new HttpClient())
        {

            client.BaseAddress = new Uri($"http://{_configurationManager.Host}:{_configurationManager.Port}/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            var response = await client.GetAsync($"api/clientactions/");


            if (response.IsSuccessStatusCode)
            {
                var t = await response.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<List<ClientActionDto>>(t, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                return data;

            }

        }

        return null;
    }
    #endregion


    IToastService _toastService;
    private readonly IServiceProvider _services;
    public IConfigurationManagerService _configurationManager;
    private readonly Dispatcher _dispatcher;

    public CommunicationApplicationController(IToastService toastService, IServiceProvider services, Dispatcher dispatcher)
    {
        _toastService = toastService;
        _services = services;
        _configurationManager = _services.GetRequiredService<IConfigurationManagerService>();
        _dispatcher = dispatcher;
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