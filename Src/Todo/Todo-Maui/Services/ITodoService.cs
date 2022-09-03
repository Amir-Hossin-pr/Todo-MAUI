using Todo_Maui.Models;

namespace Todo_Maui.Services;

public interface ITodoService : IDisposable
{
    Task<bool> InseretAsync(Todo todo);

    Task<IEnumerable<Todo>> GetAllAsync();

    Task<Todo> GetAsync(int id);

    Task<bool> UpdateAsync(Todo todo);

    Task<bool> DeleteAsync(Todo todo);

    Task<bool> DeleteAsync(int id);
}
