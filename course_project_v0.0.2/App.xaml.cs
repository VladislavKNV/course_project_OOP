using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace course_project_v0._0._2
{
    public partial class App : Application
    {
        public static Sing_In sing_In;
        public static MainWindow mainWindow;

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            sing_In = new Sing_In();
            sing_In.Show();
        }
    }
}
