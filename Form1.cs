using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MyBaseClass myBaseClass;
        private void baseClassButton_Click(object sender, EventArgs e)
        {
            myBaseClass = new MyBaseClass("parameter to baseClass");
        }
        MySubClass mySubClass;
        private void subClassButton_Click(object sender, EventArgs e)
        {
            mySubClass = new MySubClass("subClass & baseClass", 24);
        }
    }
}
