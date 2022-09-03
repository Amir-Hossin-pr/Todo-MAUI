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

    async void SetupConnection()
    {
        if (_db == null)
        {
            var cnn = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Todo.db");
          
            _db = new(cnn);
            
            await _db.CreateTableAsync<Todo>();
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

    public async Task<Todo> GetAsync(int id)
        => await _db.Table<Todo>().FirstOrDefaultAsync(t=> t.Id == id);

    public async Task<bool> UpdateAsync(Todo todo)
    {
        try
        {
            await _db.UpdateAsync(todo);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(Todo todo)
    {
        try
        {
            await _db.DeleteAsync(todo);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(int id)
        => await DeleteAsync(await GetAsync(id));
}
