using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Todo_Maui.Models;

namespace Todo_Maui.ViewModels;

public class TodoViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private ObservableCollection<Todo> _todos;

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

}
