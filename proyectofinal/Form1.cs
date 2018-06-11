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
        //private void button1_Click(object sender, EventArgs e)  { }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "ismael" && double.Parse(textBox2.Text) == 1234)
            {
                this.Hide();
                Administrador Form2 = new Administrador();
                Form2.Show();

            }
            else
            {
                MessageBox.Show("Nombre o Contraseña Invalido ");
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "ismael" && double.Parse(textBox2.Text) == 1234)
            {
                this.Hide();
                cajero Form2 = new cajero();
                Form2.Show();

            }
            else
            {
                MessageBox.Show("Nombre o Contraseña Invalido ");
            }
        }
    }
}
