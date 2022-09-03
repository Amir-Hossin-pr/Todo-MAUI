using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Todo_Maui.Models;
using Todo_Maui.Services;
using static Todo_Maui.Services.ServiceProvider;

namespace Todo_Maui.ViewModels;

public class TodoViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<Todo> _todos;

    //private readonly ITodoService _todoService;

    public TodoViewModel()
    {
        //_todoService = GetService<ITodoService>();
        Fetch();
    }

    public ObservableCollection<Todo> Todos
    {
        get
        {
            return _todos;
        }
        set
        {
            _todos = value;
            OnPropertyChanged(nameof(Todos));

        }
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    void Fetch()
    {
        Todos = new(new List<Todo>
        {
            new()
            {
                Id = 0,
                Title= "test 1",
                Text = "test for text"
            },
             new()
            {
                Id = 1,
                Title= "test 2",
                Text = "test for text"
            },
              new()
            {
                Id = 2,
                Title= "test 3",
                Text = "test for text"
            },
               new()
            {
                Id = 3,
                Title= "test 4",
                Text = "test for text"
            },
                new()
            {
                Id = 4,
                Title= "test 5",
                Text = "test for text"
            },
                 new()
            {
                Id = 5,
                Title= "test 6",
                Text = "test for text"
            }
        });
    }
}
