using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.PossibleActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PSPublicMessagingAPI.Domain.ClientActions;
using PSPublicMessagingAPI.Domain.Shared;

namespace PSPublicMessagingAPI.Infrastructure.Configurations;
internal sealed class ClientActionConfiguration : IEntityTypeConfiguration<ClientAction>
{
    public void Configure(EntityTypeBuilder<ClientAction> builder)
    {
        builder.ToTable("ClientAction");

        builder.HasKey(p => p.Id);



        builder.Property(p => p.ClientUserName)
            .HasMaxLength(200)
            .HasConversion(name => name.Value, value => new UserName(value));

        builder.Property(p => p.PossibleActionId)
            .HasMaxLength(200);

        builder.Property(p => p.TargetClientUserName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new UserName(value));
        

    }
}
