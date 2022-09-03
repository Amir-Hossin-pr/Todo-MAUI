using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_Maui_Blazor.Models;

namespace Todo_Maui_Blazor.Services;

public interface ITodoService : IDisposable
{
    Task<bool> InseretAsync(Todo todo);

    Task<IEnumerable<Todo>> GetAllAsync();

    Task<Todo> GetAsync(int id);

    Task<bool> UpdateAsync(Todo todo);

    Task<bool> DeleteAsync(Todo todo);

    Task<bool> DeleteAsync(int id);
}
