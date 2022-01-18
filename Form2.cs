using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textreader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string filename1;

        private void Form2_Load(object sender, EventArgs e)
        {
            saveFileDialog1.Filter =
            "Текстовые файлы (*.txt)|*.txt|All files (*.*)|*.*";
        }
    }
}
