using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DigitalSignageGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IEnumerable<string> file = System.IO.Directory.EnumerateDirectories("C:\\Users\\Josh31\\pp_home\\pp_profiles", "*.*", System.IO.SearchOption.AllDirectories);
            foreach (var f in file)
            {
                pphomeList.Items.Add(f.Substring(36));
            }
        }

        private void exitDropDown_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}