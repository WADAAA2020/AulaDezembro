using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8Dezembro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            inputTela.AppendText("\r\n" + "Pressionou a tecla: " + e.KeyCode);
            inputTela.AppendText("\r\n" + "\t" + "Código da tecla: " + ((int)e.KeyCode));
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
