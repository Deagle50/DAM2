using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ListaProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            LlenarListView();
        }

        void LlenarListView()
        {
            //String[] procesos = { "uno", "dos", "tres" };
            Process[] procesos;
            procesos = Process.GetProcesses();
            foreach (Process nom in procesos)
            {
                ListViewItem it = listView1.Items.Add(nom.ProcessName);
                it.SubItems.Add(nom.Id.ToString());
                it.SubItems.Add(nom.BasePriority.ToString());
                it.SubItems.Add(nom.PagedSystemMemorySize64.ToString());
            }
        }


    }
}
