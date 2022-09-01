using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo_Maui_Blazor.Models;

namespace Todo_Maui_Blazor.Services;

public class TodoService : ITodoService
{
    private SQLiteAsyncConnection _db;

    public TodoService()
    {
        SetupConnection();
    }

    void SetupConnection()
    {
        if (_db == null)
        {
            var cnn = Path.Combine(FileSystem.Current.AppDataDirectory, "Todo.db");
            _db = new(cnn);
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
    }

    public async Task<bool> InseretAsync(Todo todo)
    {
        try
        {
            await _db.InsertAsync(todo);
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public async Task<IEnumerable<Todo>> GetAllAsync()
        => await _db.Table<Todo>().ToListAsync();
}
