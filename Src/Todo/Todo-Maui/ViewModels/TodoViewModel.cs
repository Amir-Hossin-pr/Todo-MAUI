using Microsoft.Maui.Controls;
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

    private string _title;

    private string _text;

    private Command _save;

    public string Title
    {
        get => _title; set
        {
            _title = value;
            OnPropertyChanged(nameof(Title));
        }
    }

    public string Text
    {
        get => _text; set
        {
            _text = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    public TodoViewModel()
    {
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
        });
    }

    public  Command Save
    {
        get => _save; set
        {
            _save = value;
            OnPropertyChanged(nameof(Save));
        }
    } 
}
