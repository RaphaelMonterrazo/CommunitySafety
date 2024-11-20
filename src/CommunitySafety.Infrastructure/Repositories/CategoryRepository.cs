﻿
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;
using CommunitySafety.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CommunitySafety.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;
    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Category>> GetCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryByIdAsync(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task<Category> CreateAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task<Category> RemoveAsync(Category category)
    {
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        return category;
    }
}
