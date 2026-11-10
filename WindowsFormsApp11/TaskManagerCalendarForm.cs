using System;
using System.Windows.Forms;

namespace TaskManagerApp
{
    public partial class TaskManagerCalendarForm : Form
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TaskManagerCalendarForm());
        }
    }
}