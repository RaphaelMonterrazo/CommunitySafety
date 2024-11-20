
using CommunitySafety.Domain.Entities;

namespace CommunitySafety.Domain.Interfaces;

public interface ICategoryRepository
{
    Task<IEnumerable<Category>> GetCategoriesAsync();
    Task<Category?> GetCategoryByIdAsync(int id);
    Task<Category> CreateAsync(Category incident);
    Task<Category> UpdateAsync(Category category);
    Task<Category> RemoveAsync(Category category);

}
