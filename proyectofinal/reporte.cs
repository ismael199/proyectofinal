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
    public partial class reporte : Form
    {
        List<trastienda> ltrastienda = new List<trastienda>();
        static int posicionmodificar;
        public reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Margarito Hernandez\source\repos\proyectofinal\proyectofinal\bin\Debug\listados\vendidas.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                trastienda productotemp = new trastienda();
                productotemp.Nombre = reader.ReadLine();
                

                //Agregar a la lista el temporal
                ltrastienda.Add(productotemp);
            }
            reader.Close();

            //Se recorre la lista de clientes
            for (int i = 0; i < ltrastienda.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (ltrastienda[i].Nombre == textBox2.Text)
                {
                    textBox2.Text = ltrastienda[i].Nombre;
                   
                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //temporal
            agreproduc personatemp = new agreproduc();
            personatemp.Nombre1 = textBox2.Text;
            
            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ltrastienda;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Margarito Hernandez\source\repos\proyectofinal\proyectofinal\bin\Debug\listados\meses.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                trastienda productotemp = new trastienda();
                productotemp.Mes = reader.ReadLine();
                productotemp.Total = reader.ReadLine();


                //Agregar a la lista el temporal
                ltrastienda.Add(productotemp);
            }
            reader.Close();

            //Se recorre la lista de clientes
            for (int i = 0; i < ltrastienda.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (ltrastienda[i].Mes == textBox1.Text)
                {
                    textBox3.Text = ltrastienda[i].Nombre;
                    textBox4.Text = ltrastienda[i].Total;


                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //temporal
            trastienda personatemp = new trastienda();
            personatemp.Nombre = textBox3.Text;
            personatemp.Total = textBox4.Text;
            

            // el objeto temporal guardarlo en la lista 
            ltrastienda.Add(personatemp);
            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = ltrastienda;
            dataGridView1.Refresh();
        }
    }
}
