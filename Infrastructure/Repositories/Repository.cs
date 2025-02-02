﻿using Microsoft.EntityFrameworkCore;
using PSPublicMessagingAPI.Domain.Abstractions;

namespace PSPublicMessagingAPI.Infrastructure.Repositories;

internal abstract class Repository<T>
    where T : Entity
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<T?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<T>()
            .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public void Add(T entity)
    {
        DbContext.Add(entity);
    }

    public async Task<T> Update(T entity)
    {
        DbContext.Set<T>().Attach(entity);
        DbContext.Entry(entity).State = EntityState.Modified;
        return entity;
    }
}