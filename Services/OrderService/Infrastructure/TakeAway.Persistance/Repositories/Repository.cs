using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TakeAway.ApplicationLayer.Interfaces;
using TakeAway.PersistanceLayer.Settings.DbContexts;

namespace TakeAway.PersistanceLayer.Repositories;

public class Repository<T>(OrderContext  context) : IRepository<T> where T : class
{
    private readonly OrderContext context = context;

    public async Task CreateAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var value = await context.Set<T>().FindAsync(id);
        context.Set<T>().Remove(value);
        await context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAsync(T entity)
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByFilterAsync(Expression<Func<T, bool>> expression)
    {
        return await context.Set<T>().SingleOrDefaultAsync(expression);
    }


    public async Task<T> GetByIdAsync(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T entity)
    {
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
    }
}
