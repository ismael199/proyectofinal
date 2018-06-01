using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RadioButton.CheckForIllegalCrossThreadCalls == true)
            {
                Administrador falumno = new Administrador();
                falumno.Show();
            }
            else
            {
                if (RadioButton.CheckForIllegalCrossThreadCalls == true)
                {
                    Form1 falunnos = new Form1();
                    falunnos.Show();
                }
            }
        }
    }
}
