
using AutoMapper;
using CommunitySafety.Application.DTOs;
using CommunitySafety.Application.Interfaces;
using CommunitySafety.Domain.Entities;
using CommunitySafety.Domain.Interfaces;

namespace CommunitySafety.Application.Services;

public sealed class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategoriesAsync()
    {
        var categoriesEntity = await _categoryRepository.GetCategoriesAsync();
        return _mapper.Map<IEnumerable<CategoryDTO>>(categoriesEntity);
    }

    public async Task<CategoryDTO> GetByIdAsync(int id)
    {
        var categoryEntity = await _categoryRepository.GetCategoryByIdAsync(id);
        return _mapper.Map<CategoryDTO>(categoryEntity);
    }
    
    public async Task AddAsync(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryRepository.CreateAsync(categoryEntity);
    }
    
    public async Task UpdateAsync(CategoryDTO categoryDTO)
    {
        var categoryEntity = _mapper.Map<Category>(categoryDTO);
        await _categoryRepository.UpdateAsync(categoryEntity);
    }
    
    public async Task RemoveAsync(int id)
    {
        var productEntity = await _categoryRepository.GetCategoryByIdAsync(id);
        await _categoryRepository.RemoveAsync(productEntity);
    }
}
