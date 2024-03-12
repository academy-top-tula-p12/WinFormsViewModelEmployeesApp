namespace WinFormsViewModelEmployeesApp
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();

            this.DataContext = new EmployeesViewModel();

            lstBoxEmployees.DataBindings.Add(
                new("DataSource", 
                    DataContext, 
                    "Employees", 
                    true, 
                    DataSourceUpdateMode.OnPropertyChanged));
            
            lstBoxEmployees.DisplayMember = "Name";
            lstBoxEmployees.ValueMember = "Id";
            //lstBoxEmployees.DataBindings.Add(
            //    new("SelectedValue",
            //    DataContext,
            //    "SelectedId",
            //    false,
            //    DataSourceUpdateMode.OnPropertyChanged));

            txtName.DataBindings.Add(
                new("Text",
                DataContext,
                "Name",
                true,
                DataSourceUpdateMode.OnPropertyChanged));
            
            txtAge.DataBindings.Add(
                new("Value",
                DataContext,
                "Age",
                true,
                DataSourceUpdateMode.OnPropertyChanged));

            btnAdd.DataBindings.Add(
                new("Command",
                DataContext,
                "AddCommand",
                true));
        }
    }
}
