using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class MySubClass:MyBaseClass
    {
        public MySubClass(string baseClassNeedsThis, int anotherValue):base(baseClassNeedsThis)
        {
            MessageBox.Show($"This is the subClass: {baseClassNeedsThis} and {anotherValue}");
        }
    }
}
