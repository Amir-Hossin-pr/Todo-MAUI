using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_Maui.Models;

public record Todo
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Text { get; set; }
}
