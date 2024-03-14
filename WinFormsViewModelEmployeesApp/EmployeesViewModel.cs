using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsViewModelEmployeesApp
{
    class EmployeesViewModel : INotifyPropertyChanged
    {
        // global id
        static int id = 0;

        // name and Name
        string name = "";
        public string Name
        {
            get => name;
            set
            {
                if(name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        // age and Age
        int age;
        public int Age
        {
            get => age;
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged();
                }
            }
        }

        // selected index
        int selectedIndex;

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }

        // employees full list
        public BindingList<Employee>? Employees { get; set; }

        public EmployeesViewModel()
        {
            Employees = new()
            {
                new(){ Id = ++id, Name = "Bobby", Age = 27 },
                new(){ Id = ++id, Name = "Tommy", Age = 19 },
                new(){ Id = ++id, Name = "Jimmy", Age = 34 },
            };

            SelectedIndex = 0;

            AddCommand = new AppCommand(_ =>
            {
                if(this.Name.Trim().Length > 0)
                {
                    Employees.Add
                    (new Employee() { Id = ++id, 
                                     Name = this.Name, 
                                     Age = this.Age });
                    this.Name = "";
                    this.Age = 0;
                }
                
            });

            RemoveCommand = new AppCommand(
            obj =>
            {
                if(obj is int id)
                {
                    var employee = Employees.FirstOrDefault(e => e.Id == id);
                    if (employee is not null)
                    {
                        int position = SelectedIndex;
                        Employees.Remove(employee);
                        if(position >= Employees.Count) 
                            position = Employees.Count - 1;
                        SelectedIndex = position;
                    }
                        
                }
            },
            _ => Employees.Count > 0);
        }

        // command add employee
        public ICommand AddCommand { get; set; }
        public ICommand RemoveCommand { set; get; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
