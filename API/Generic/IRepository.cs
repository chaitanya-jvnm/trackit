namespace API.Generic;

public interface IRepository<T> where T : class
{
    Task<T> GetOneAsync(int id);

    Task<List<T>> GetAllAsync();
    
    

}