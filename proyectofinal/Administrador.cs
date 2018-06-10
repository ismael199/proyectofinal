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
       static List<agreproduc> lagregarproduc = new List<agreproduc>();

        static int posicionmodificar;
        public Administrador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //temporal
            agreproduc personatemp = new agreproduc();
            personatemp.Nombre1 = textBox2.Text;
            personatemp.Apellido1 = textBox3.Text;

            personatemp.Nit1 = textBox3.Text;
            personatemp.Direccion1 = textBox5.Text;

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
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox5.Enabled = true;
            button2.Enabled = true;
                  }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Margarito Hernandez\Documents\Visual Studio 2017.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                agreproduc clientetemp = new agreproduc();
                clientetemp.Nombre1 = reader.ReadLine();
                clientetemp.Apellido1 = reader.ReadLine();
                clientetemp.Nit1 = reader.ReadLine();
                clientetemp.Direccion1 = reader.ReadLine();

                //Agregar a la lista el temporal
                lagregarproduc.Add(clientetemp);
            }
            reader.Close();

            //Se recorre la lista de clientes
            for (int i = 0; i < lagregarproduc.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (lagregarproduc[i].Nombre1 == textBox1.Text)
                {
                    textBox2.Text = lagregarproduc[i].Nombre1;
                    textBox3.Text = lagregarproduc[i].Apellido1;
                    textBox4.Text = lagregarproduc[i].Nit1;
                    textBox5.Text = lagregarproduc[i].Direccion1;
                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;

                }

            }


        }
    }
}
