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

        // selected employee
        //public Employee SelectedEmployee 
        //{
        //    get => Employees.FirstOrDefault(e => e.Id == SelectedId);
        //}
        
        // selected id
        //public int SelectedId { set; get; }

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

            //SelectedId = 1;

            AddCommand = new AppCommand(_ =>
            {
                Employees.Add(
                    new Employee() { Id = ++id, Name = this.Name, Age = this.Age }
                    );
                this.Name = "";
                this.Age = 0;
            });
        }

        // command add employee
        public ICommand AddCommand { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
