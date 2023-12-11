using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.PossibleActions;
using PSPublicMessagingAPI.Infrastructure.Outbox;

namespace PSPublicMessagingAPI.Infrastructure.Configurations;

internal sealed class OutboxMessageConfiguration : IEntityTypeConfiguration<OutboxMessage>
{
    public void Configure(EntityTypeBuilder<OutboxMessage> builder)
    {
        builder.ToTable("OutboxMessage");

        builder.HasKey(p => p.Id);



       

    }
}