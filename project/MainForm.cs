using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poeBot
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Initialize components...");
        }
        
        private void MainWindow_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Main window Loading...");
        }
       
        private void btnSayHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
