using System;
using System.Configuration;
using System.Windows.Threading;
using AutoMapper;
using Desktop.Views;
using DesktopWinforms.Controllers;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using PersianDate.Standard;
using PSPublicMessagingAPI.Desktop.Consumers;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Desktop.Views;
using PSPublicMessagingAPI.Domain.Notifications;


namespace PSPublicMessagingAPI.Desktop.Config;

public class IocConfig
{
    public static IServiceProvider CreateServiceProvider()
    {
      

        var mapperConfiguration = CreateConfiguration();

        IServiceCollection services = new ServiceCollection();
        //services.AddMassTransit(busConfigurator =>
        //{
        //    busConfigurator.SetKebabCaseEndpointNameFormatter();
        //    busConfigurator.AddConsumer<NotificationCreatedConsumer>();
        //    busConfigurator.UsingRabbitMq((context, configurator) =>
        //    {
        //        configurator.Host(new Uri("amqp://guest:guest@localhost:5672/vhost"), h =>
        //        {
        //            //h.Username(ConfigurationManager.AppSettings["rabbitusername"]);
        //            //h.Password(ConfigurationManager.AppSettings["rabbitpassword"]);
        //        });
        //        configurator.ConfigureEndpoints(context);
        //    });

        //});
        services.AddSingleton<IMapper>(c => new Mapper(mapperConfiguration));
        services.AddSingleton<IToastService, ToastService>();
        services.AddSingleton<IFontService, FontService>();
        services.AddSingleton<IMainView, MainWindow>();
        services.AddSingleton<INewNotification>(s =>
        {
            return new NewNotification(s.GetRequiredService<IToastService>(),
                                       s.GetRequiredService<IActiveDirectoryService>(),
                                       s.GetRequiredService<IMapper>());
        });
        services.AddSingleton<IMainViewPresenter>(s =>
        {
            return new MainViewPresenter(new MainWindow(s.GetRequiredService<ICommunicationApplicationController>(),
                                                           s.GetRequiredService<IToastService>(),
                                                           s.GetRequiredService<IActiveDirectoryService>(),
                                                          
                                                           s.GetRequiredService<IMapper>(),
                                                           s.GetRequiredService<IFontService>(),
                                                           s.GetRequiredService<IConfigurationManagerService>(),
                                                           Dispatcher.CurrentDispatcher)
                , s.GetRequiredService<ICommunicationApplicationController>());
        });

        services.AddSingleton<IConfigurationManagerService, ConfigurationManagerService>();

        services.AddSingleton<ICommunicationApplicationController>(service =>
        {
            return new CommunicationApplicationController(service.GetRequiredService<IToastService>(), service);
        });
        services.AddSingleton<IActiveDirectoryService>(s =>
        {
            return new ActiveDirectoryService(s.GetRequiredService<IConfigurationManagerService>()
                                             , s.GetRequiredService<ICommunicationApplicationController>());
        });
        //services.AddSingleton<IPSMessangerMainController>(s =>
        //{
        //    return new PSMessangerMainController(s.GetRequiredService<ICommunicationApplicationController>(),
        //                                                   s.GetRequiredService<IToastService>(),
        //                                                   s.GetRequiredService<IActiveDirectoryService>(),
        //                                                   s.GetRequiredService<IMapper>(),
        //                                                   s.GetRequiredService<IFontService>(),
        //                                                   s.GetRequiredService<IConfigurationManagerService>(),
        //                                                   Dispatcher.CurrentDispatcher);
        //});

        //services.AddSingleton<IAuthenticationService>(service =>
        //{
        //    return new AuthenticationService(service.GetRequiredService<IToastService>());
        //});
        //services.AddSingleton<INotificationService>(service =>
        //{
        //    return new NotificationService();
        //});

        services.AddScoped<MainWindow>(s => new MainWindow(s.GetRequiredService<ICommunicationApplicationController>(),
                                                           s.GetRequiredService<IToastService>(),
                                                           s.GetRequiredService<IActiveDirectoryService>(),
                                                          
                                                           s.GetRequiredService<IMapper>(),
                                                           s.GetRequiredService<IFontService>(),
                                                           s.GetRequiredService<IConfigurationManagerService>(),
                                                           Dispatcher.CurrentDispatcher));

        //services.AddScoped<Message>();
        //services.AddScoped<About>();
        //services.AddScoped<LoginViewModel>();
        //services.AddScoped<HomeViewModel>();
        //services.AddScoped<ShellViewModel>(s => new ShellViewModel(s.GetRequiredService<ICommunicationApplicationController>(),
        //                                                            s.GetRequiredService<IMapper>(),
        //                                                            s.GetRequiredService<IConfigurationManagerService>()));
        ////services.AddScoped<MainViewModel>();

        //services.AddSingleton<CreateViewModel<LoginViewModel>>(service =>
        //{
        //    return () => new LoginViewModel(service.GetRequiredService<INavigator>());
        //});
        //services.AddSingleton<CreateViewModel<ShellViewModel>>(service =>
        //{
        //    return () => new ShellViewModel(service.GetRequiredService<IDispatcher>(), service.GetRequiredService<INotificationService>());
        //});
        //services.AddSingleton<CreateViewModel<HomeViewModel>>(service =>
        //{
        //    return () => new HomeViewModel(service.GetRequiredService<IAuthenticator>(), service.GetRequiredService<INotificationService>(),
        //        service.GetRequiredService<INavigator>(), service.GetRequiredService<ShellViewModel>());
        //});
        //services.AddSingleton<CreateViewModel<AboutViewModel>>(service =>
        //{
        //    return () => new AboutViewModel();
        //});
        //services.AddSingleton<CreateViewModel<MessageViewModel>>(service =>
        //{
        //    return () => new MessageViewModel(service.GetRequiredService<IAuthenticator>(), service.GetRequiredService<INotificationService>(),
        //        service.GetRequiredService<INavigator>());
        //});


        return services.BuildServiceProvider();
    }
    private static MapperConfiguration CreateConfiguration()
    {
        var config = new MapperConfiguration(cfg => {
            #region Notification
            cfg.CreateMap<NotificationViewModel, Notification>();
            cfg.CreateMap<Notification, NotificationViewModel>()
            .ForMember(dest => dest.NotificationStatusText, opt => opt.MapFrom(src => src.NotificationStatus == NotificationStatus.Expired ? "منقضی شده" :
                                  src.NotificationStatus == NotificationStatus.Read ? "خوانده شده" :
                                  src.NotificationStatus == NotificationStatus.ReadyToPublish ? "آماده ارسال" :
                                  src.NotificationStatus == NotificationStatus.New ? "جدید" : ""))
            .ForMember(dest => dest.NotificationPriorityIcon, opt => opt.MapFrom(src => src.NotificationPriority == NotificationPriority.Critical ? "SvgImages/Outlook%20Inspired/HighImportance.svg" :
                                    src.NotificationPriority == NotificationPriority.High ? "SvgImages/XAF/State_Task_WaitingForSomeoneElse.svg" :
                                    src.NotificationPriority == NotificationPriority.Medium ? "SvgImages/XAF/ModelEditor_Class_Object.svg" :
                                    src.NotificationPriority == NotificationPriority.Low ? "SvgImages/Outlook%20Inspired/LowImportance.svg" : ""))
            .ForMember(dest => dest.NotificationPriorityText, opt => opt.MapFrom(src => src.NotificationPriority == NotificationPriority.Critical ? "بحرانی" :
                                    src.NotificationPriority == NotificationPriority.High ? "بالا" :
                                    src.NotificationPriority == NotificationPriority.Medium ? "متوسط" :
                                    src.NotificationPriority == NotificationPriority.Low ? "پایین" : ""))
            .ForMember(dest => dest.NotificationStatusIcon, opt => opt.MapFrom(src => src.NotificationStatus == NotificationStatus.Expired ? "SvgImages/Business%20Objects/BO_Scheduler.svg" :
                                  src.NotificationStatus == NotificationStatus.Read ? "SvgImages/Icon%20Builder/Actions_EnvelopeOpen.svg" :
                                  src.NotificationStatus == NotificationStatus.ReadyToPublish ? "SvgImages/Business%20Objects/BO_Audit_ChangeHistory.svg" :
                                  src.NotificationStatus == NotificationStatus.New ? "SvgImages/Icon%20Builder/Actions_EnvelopeClose.svg" : ""))
            .ForMember(dest => dest.NotificationDatePersian, opt => opt.MapFrom(src => src.NotificationDate.ToFa("yyyy/MM/dd ")))
            .ForMember(dest => dest.NotificationTimePersian, opt => opt.MapFrom(src => src.NotificationDate.ToFa("t")))
            .ForMember(dest => dest.MethodParameter, opt => opt.MapFrom(src => src.MethodParameter))
            .ForMember(dest => dest.TargetClientGroup, opt => opt.MapFrom(src => src.TargetClientGroup))
            .ForMember(dest => dest.ClientGroup, opt => opt.MapFrom(src => src.ClientGroup))
            .ForMember(dest => dest.ClientFullName, opt => opt.MapFrom(src => src.ClientFullName))
            .ForMember(dest => dest.ClientUserName, opt => opt.MapFrom(src => src.ClientUserName))
            .ForMember(dest => dest.NotificationDate, opt => opt.MapFrom(src => src.NotificationDate))
            .ForMember(dest => dest.NotificationId, opt => opt.MapFrom(src => src.Id))

            .ForMember(dest => dest.TargetGroup, opt => opt.MapFrom(src => src.TargetGroup))
            .ForMember(dest => dest.TargetClientUserName, opt => opt.MapFrom(src => src.TargetClientUserName))
            .ForMember(dest => dest.TargetClientFullName, opt => opt.MapFrom(src => src.TargetClientFullName))
            //.ForMember(dest => dest.PossibleActionName, opt => opt.MapFrom(src => src.PossibleAction.PossibleActionName))
            //.ForMember(dest => dest.PossibleActionModuleName, opt => opt.MapFrom(src => src.PossibleAction.ModuleName))
            //.ForMember(dest => dest.PossibleActionMethodToCall, opt => opt.MapFrom(src => src.PossibleAction.MethodToCall))
            //.ForMember(dest => dest.PossibleActionFormName, opt => opt.MapFrom(src => src.PossibleAction.FormName))

            .ForMember(dest => dest.PossibleActionId, opt => opt.MapFrom(src => src.PossibleActionId))
            .ForMember(dest => dest.NotificationPriority, opt => opt.MapFrom(src => src.NotificationPriority))
            .ForMember(dest => dest.NotificationText, opt => opt.MapFrom(src => src.NotificationText))
            .ForMember(dest => dest.NotificationTitle, opt => opt.MapFrom(src => src.NotificationTitle))
            .ForMember(dest => dest.LastModifierUser, opt => opt.MapFrom(src => src.LastModifierUser))
            .ForMember(dest => dest.NotificationStatus, opt => opt.MapFrom(src => src.NotificationStatus));
            #endregion


        });
        return config;
    }
}