using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.Notifications;
using PSPublicMessagingAPI.Domain.UserRoles;

namespace PSPublicMessagingAPI.Infrastructure.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRole");

        builder.HasKey(p => p.Id);



        builder.Property(p => p.RoleName)
            .HasMaxLength(200);

        builder.Property(p => p.UserName)
            .HasMaxLength(200);

    }
}
