﻿using System;
using System.Configuration;
using System.Windows.Threading;
using AutoMapper;
using Desktop.Views;
using DesktopWinforms.Models;
using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using PersianDate.Standard;
using PSPublicMessagingAPI.Contract;
using PSPublicMessagingAPI.Desktop.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.Presenter;
using PSPublicMessagingAPI.Desktop.Presenter.View;
using PSPublicMessagingAPI.Desktop.Services;
using PSPublicMessagingAPI.Desktop.ViewModels;
using PSPublicMessagingAPI.Desktop.Views;
using PSPublicMessagingAPI.DesktopWinforms.Controllers;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.SharedToastMessage.Services;


namespace PSPublicMessagingAPI.Desktop.Config;

public class IocConfig
{
    public static IServiceProvider CreateServiceProvider(IServiceCollection _services)
    {
      

        var mapperConfiguration = CreateConfiguration();

        IServiceCollection services = _services;
       
        
        services.AddSingleton<IMapper>(c => new Mapper(mapperConfiguration));
        services.AddSingleton<IToastService, ToastService>();

        services.AddSingleton<Dispatcher>(s => Dispatcher.CurrentDispatcher);
        services.AddSingleton<IFontService, FontService>();
        services.AddTransient<IMainView, MainWindow>();
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

        services.AddSingleton<ICommunicationApplicationController>(s =>
        {
            return new CommunicationApplicationController(s.GetRequiredService<IToastService>(), s, Dispatcher.CurrentDispatcher);
        });
        services.AddSingleton<IActiveDirectoryService>(s =>
        {
            return new ActiveDirectoryService(s.GetRequiredService<IConfigurationManagerService>()
                                             , s.GetRequiredService<ICommunicationApplicationController>());
        });

       


        services.AddSingleton<MainWindow>(s => new MainWindow(s.GetRequiredService<ICommunicationApplicationController>(),
                                                           s.GetRequiredService<IToastService>(),
                                                           s.GetRequiredService<IActiveDirectoryService>(),
                                                          
                                                           s.GetRequiredService<IMapper>(),
                                                          
                                                           s.GetRequiredService<IFontService>(),
                                                           s.GetRequiredService<IConfigurationManagerService>(),
                                                           Dispatcher.CurrentDispatcher));

        


        return services.BuildServiceProvider();
    }
    private static MapperConfiguration CreateConfiguration()
    {
        var config = new MapperConfiguration(cfg => {
            #region Notification
            cfg.CreateMap<NotificationViewModel, NotificationDto>();
            cfg.CreateMap<NotificationDto, NotificationViewModel>()
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
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))

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