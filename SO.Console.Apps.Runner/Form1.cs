using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SO.Console.Apps.Runner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\REPOS\SO.Console.Apps.Runner\SOC.ConsoleApp01\bin\Debug\SOC.ConsoleApp01.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\REPOS\SO.Console.Apps.Runner\SOC.ConsoleApp02\bin\Debug\SOC.ConsoleApp02.exe");
        }
    }
}
