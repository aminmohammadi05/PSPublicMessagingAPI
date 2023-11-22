using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.PossibleActions;
using PSPublicMessagingAPI.Domain.Shared;

namespace Infrastructure.Configurations;

internal sealed class PossibleActionConfiguration : IEntityTypeConfiguration<PossibleAction>
{
    public void Configure(EntityTypeBuilder<PossibleAction> builder)
    {
        builder.ToTable("PossibleAction");

        builder.HasKey(p => p.Id);

        

        builder.Property(p => p.FormName)
            .HasMaxLength(200)
            .HasConversion(name => name.Value, value => new FormName(value));

        builder.Property(p => p.MethodToCall)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new MethodToCall(value));

        builder.Property(p => p.ModuleName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ModuleName(value));
        builder.Property(p => p.TargetGroup)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new ActiveDirectoryGroupName(value));
        builder.Property(p => p.PossibleActionName)
            .HasMaxLength(200)
            .HasConversion(m => m.Value, value => new PossibleActionName(value));

    }
}