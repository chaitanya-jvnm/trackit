using API.Generic;

namespace API.Categories;

public class CategoryRepositoryStorage : IRepository<Category>
{
    public async Task<List<Category>> GetAllAsync()
    {
        // add logic
        return await Task.CompletedTask;
    }

    public async Task<Category> GetOneAsync(int id)
    {
        // add logic
        return await Task.CompletedTask;
    }
}