using Dalidikes.RequestModels;

namespace Dalidikes.Interfaces
{
    public interface IAsyncRepository<T> where T: class
    {
        public Task<T> GetAsync(int id);
        public Task<IEnumerable<T>> GetAllAsync(PageLimit limits);
        public Task<int> CreateAsync (T model);
        public Task UpdateAsync(int id, T model);
        public Task DeleteAsync(int id);
    }
}