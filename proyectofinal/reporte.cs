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
        List<meses> lmeses = new List<meses>();
        List<vendedor> lvendedor = new List<vendedor>();
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
                if (ltrastienda[i].Nombre == textBox1.Text)
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

            MessageBox.Show("la benta mas vendiada es de : electronica ");
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
                meses productotemp = new meses();
                productotemp.Mes = reader.ReadLine();
                productotemp.Nombre = reader.ReadLine();
                productotemp.Total = reader.ReadLine();
                
                productotemp.N2 = reader.ReadLine();
                productotemp.T2 = reader.ReadLine();
               
                productotemp.N3 = reader.ReadLine();
                productotemp.T3 = reader.ReadLine();
               
                productotemp.N4 = reader.ReadLine();
                productotemp.T4 = reader.ReadLine();



                //Agregar a la lista el temporal
                lmeses.Add(productotemp);
            }
            reader.Close();

            //Se recorre la lista de clientes
            for (int i = 0; i < lmeses.Count; i++)
            {
                //Si se el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (lmeses[i].Mes == textBox1.Text)
                {
                    textBox3.Text = lmeses[i].Mes;
                    textBox4.Text = lmeses[i].Nombre;
                    textBox5.Text = lmeses[i].Total;
                    textBox6.Text = lmeses[i].N2;
                    textBox7.Text = lmeses[i].T2;
                    textBox8.Text = lmeses[i].N3;
                    textBox9.Text = lmeses[i].T3;
                    textBox10.Text = lmeses[i].N4;
                    textBox11.Text = lmeses[i].T4;
                  


                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;

                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //temporal
            meses personatemp = new meses();
            personatemp.Mes = textBox3.Text;
            personatemp.Nombre = textBox4.Text;
            personatemp.Total = textBox5.Text;
            personatemp.N2 = textBox6.Text;
            personatemp.T2 = textBox7.Text;
            personatemp.N3 = textBox8.Text;
            personatemp.T3 = textBox9.Text;
            personatemp.N4 = textBox10.Text;
            personatemp.T4 = textBox11.Text;
          
           
            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lmeses;
            dataGridView1.Refresh();
        }

        private void reporte_Load(object sender, EventArgs e)
        {

        }

        private void reporte_Load_1(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
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
                if (ltrastienda[i].Nombre == textBox1.Text)
                {
                    textBox2.Text = ltrastienda[i].Nombre;

                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;

                }

            }
            MessageBox.Show("los productos de electronica se estan agotando");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Margarito Hernandez\source\repos\proyectofinal\proyectofinal\bin\Debug\listados\ventas.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Se cargan los datos del archivo a la lista de clientes
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                vendedor productotemp = new vendedor();
                productotemp.Nombre = reader.ReadLine();
                productotemp.Categoria = reader.ReadLine();
                productotemp.Cantidad = reader.ReadLine();
                productotemp.Horas = reader.ReadLine();


                //Agregar a la lista el temporal
                lvendedor.Add(productotemp);
            }
            reader.Close();
            //temporal
            vendedor personatemp = new vendedor();
            
            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = lvendedor;
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ismael realizo 1000 dventas");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Form2 = new Form1();
            Form2.Show();
        }
    }
}
