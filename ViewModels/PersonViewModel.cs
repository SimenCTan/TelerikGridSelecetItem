using System.Collections.ObjectModel;
using TelerikDataGridDemo.Models;

namespace TelerikDataGridDemo.ViewModels;

public class PersonViewModel
{
    public ObservableCollection<Person> PersonCollection { get; set; }

    public PersonViewModel()
    {
        PersonCollection = new ObservableCollection<Person>()
        {
            new Person { Name = "Kiko", Age = 23, Department = "Production" },
            new Person { Name = "Jerry", Age = 23, Department = "Accounting & Finance"},
            new Person { Name = "Ethan", Age = 51, Department = "Marketing" },
            new Person { Name = "Isabella", Age = 25, Department = "Marketing" },
            new Person { Name = "Joshua", Age = 45, Department = "Production" },
            new Person { Name = "Logan", Age = 26, Department = "Production"},
            new Person { Name = "Aaron", Age = 32, Department = "Production" },
            new Person { Name = "Elena", Age = 37, Department = "Accounting & Finance"},
            new Person { Name = "Ross", Age = 30, Department = "Marketing" }
        };
    }
}
