using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;       // usimg Import Dll

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        [DllImport("Library.dll")]
        extern public static int Add(int x, int y);

        public Form1()
        {
            InitializeComponent();
        }

        private void OnClickButtonAdd(object sender, EventArgs e)
        {
            int result = Add(10, 23);

            MessageBox.Show(result.ToString());
        }
    }
}
