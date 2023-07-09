using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class MenuMascota : Form
    {
        public MenuMascota()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Aves")
            {
                MessageBox.Show("Cita guardada en un txt son 150 mxn");
            }
            else if (comboBox1.Text == "Perros")
            {
                MessageBox.Show("Cita guardada en un txt son 100 mxn");
            }
            else if (comboBox1.Text == "Animales de granja")
            {
                MessageBox.Show("Cita guardada en un txt son 300 mxn");
            }
            else if (comboBox1.Text == "Gatos")
            {
                MessageBox.Show("Cita guardada en un txt son 100 mxn");
            }
            else if (comboBox1.Text == "Roedores")
            {
                MessageBox.Show("Cita guardada en un txt son 200 mxn");
            }
            
            string texto = TXTProblemas.Text; // Suponiendo que textBox1 es el nombre del campo de texto
            string rutaArchivo = "C:\\Users\\NORMA\\Desktop\\Fernando\\C#\\Entrevistas\\Problemas\\Veterinaria\\Veterinaria\\Cita.txt"; // Ruta y nombre del archivo de texto

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine($"El problema(s): {texto}");

                writer.Close();
                // Puedes escribir más líneas de texto si es necesario utilizando writer.WriteLine()
                MessageBox.Show("Cita guardada en el txt");
            }



        }
    }
}
