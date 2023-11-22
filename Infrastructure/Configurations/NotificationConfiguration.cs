using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.PossibleActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Infrastructure.Configurations;
internal sealed class NotificationConfiguration : IEntityTypeConfiguration<Notification>
{
    public void Configure(EntityTypeBuilder<Notification> builder)
    {
        builder.ToTable("Notification");

        builder.HasKey(p => p.Id);



        builder.Property(p => p.TargetGroup)
            .HasMaxLength(200)
            .HasConversion(name => name.Value, value => new ActiveDirectoryGroupName(value));

        builder.Property(p => p.ClientGroup)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ClientGroup(value));
        builder.Property(p => p.TargetClientGroup)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ClientGroup(value));

        builder.Property(p => p.PossibleActionId)
            .HasMaxLength(200);
        builder.Property(p => p.ClientUserName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new UserName(value));
        builder.Property(p => p.TargetClientUserName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new UserName(value));
        builder.Property(p => p.ClientFullName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ClientName(value));
        builder.Property(p => p.TargetClientFullName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ClientName(value));
        builder.Property(p => p.LastModifierUser)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new UserName(value));
        builder.Property(p => p.NotificationDate)
            .HasMaxLength(200);
        builder.Property(p => p.NotificationStatus);
        builder.Property(p => p.NotificationPriority);
        builder.Property(p => p.NotificationTitle)
            .HasMaxLength(2000)
            .HasConversion(m => m.Value, value => new NotificationTitle(value));
        builder.Property(p => p.NotificationText)
            .HasMaxLength(Int32.MaxValue)
            .HasConversion(m => m.Value, value => new NotificationText(value));
        builder.OwnsOne(m => m.MethodParameter);

    }
}
