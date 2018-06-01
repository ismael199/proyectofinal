using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace proyectofinal
{
    public partial class Administrador : Form
    {
        List<agreproduc> lagregarproduc = new List<agreproduc>();
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //temporal
            agreproduc personatemp = new agreproduc();
            personatemp.Nombre = textBox1.Text;
            personatemp.Precio = textBox2.Text;

            personatemp.Cantidad = textBox3.Text;
            personatemp.Categoria = textBox4.Text;

            // el objeto temporal guardarlo en la lista 
            lagregarproduc.Add(personatemp);
            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lagregarproduc;
            dataGridView1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            button1.Enabled = true;

        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
        }
    }
}
