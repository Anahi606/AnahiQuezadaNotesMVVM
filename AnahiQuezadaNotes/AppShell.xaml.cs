namespace AnahiQuezadaNotes
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.AQNotePage), typeof(Views.AQNotePage));
        }
    }
}
