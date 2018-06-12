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
    public partial class cajero : Form
    {
        static List<caja> lcaja = new List<caja>();
        static List<cliente> clientela = new List<cliente>();
        List<total> totaltemp = new List<total>();
             List<int>preciotemp = new List<int>();
        static int posicionmodificar;
        public cajero()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //llamar el nombre del archivo 

            string fileName = @"C:\Users\Margarito Hernandez\source\repos\proyectofinal\proyectofinal\bin\Debug\cajero.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream); 

            //Se cargan los datos del archivo a la lista de cajero
            while (reader.Peek() > -1)
            {
                //Leer los datos y guardarlos en un temporal
                cliente clientetemp = new cliente();
                clientetemp.Nit = reader.ReadLine();
                clientetemp.Nombre = reader.ReadLine();
                clientetemp.Apellido = reader.ReadLine();
                clientetemp.Direccion = reader.ReadLine();

                //Agregar a la lista el temporal
                clientela.Add(clientetemp);
            }
            
            reader.Close();


            //Se recorre la lista de cajero
            for (int i = 0; i < clientela.Count; i++)
            {
                //Si es el dato a buscar es igual al dato de la lista mostrarlo en los textbox
                if (clientela[i].Nit == textBox1.Text)//busca los datos
                {
                    textBox2.Text = clientela[i].Nombre;
                    textBox3.Text = clientela[i].Apellido;
                    textBox4.Text = clientela[i].Direccion;

                    //Guardar en que posicion se encontró el dato para utilizarla mas adelante al momento de modificar
                    posicionmodificar = i;
                }
            }
            MessageBox.Show("no encontrado");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Nombre del archivo
            string fileName = @"C:\Users\Margarito Hernandez\source\repos\proyectofinal\proyectofinal\bin\Debug\cajero.txt";
            //Abrir el archivo
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //Crear un objeto para escribir el archivo
            StreamWriter writer = new StreamWriter(stream);
            //Usar el objeto para escribir al archivo, WriteLine, escribie linea por linea
            //Write escribe en la misma linea.
            for (int i = 0; i < clientela.Count; i++)
            {
                writer.WriteLine(clientela[i].Nit);
                writer.WriteLine(clientela[i].Nombre);
                writer.WriteLine(clientela[i].Apellido);
                writer.WriteLine(clientela[i].Direccion);

            }
            //Cerrar el archivo
            writer.Close();
            MessageBox.Show("Datos gusrdados exitosamente.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //temporal
            cliente personatemp = new cliente();
            personatemp.Nit = textBox5.Text;
            personatemp.Nombre= textBox6.Text;
            personatemp.Apellido = textBox7.Text;
            personatemp.Direccion = textBox8.Text;
           
            // el objeto temporal guardarlo en la lista 
            clientela.Add(personatemp);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //codigo de multiplicacion de canidad y precio
            textBox14.Text = (Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox12.Text)).ToString();
            textBox13.Text = (Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox12.Text)).ToString();
            textBox13.Text = (Convert.ToInt32(textBox11.Text) * Convert.ToInt32(textBox12.Text)).ToString();
            //temporal
            caja cajatemp = new caja();
            cajatemp.Nombreproduc = textBox9.Text;
            cajatemp.Categoria = textBox10.Text;
            cajatemp.Cantidad = textBox11.Text;
            cajatemp.Precio = textBox12.Text;
            cajatemp.SubTotal = textBox13.Text;
            cajatemp.Total = textBox14.Text;

            // el objeto temporal guardarlo en la lista 
            lcaja.Add(cajatemp);

            //mostrar la lista del datagridview

            dataGridView1.DataSource = null;
            dataGridView1.Refresh(); //es para refrescar el datagridviw
            dataGridView1.DataSource = lcaja;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //el el resultado del vuelto del cliente
            textBox17.Text = (Convert.ToInt32(textBox13.Text)-Convert.ToInt32(textBox16.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {//regrear al menu prinsipal
            this.Hide();
            Form1 Form2 = new Form1();
            Form2.Show();
        }
    }
}
