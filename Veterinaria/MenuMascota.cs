using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veterinaria
{
    public partial class MenuMascota : Form
    {
        static int precio = 0;
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
                precio = 150;
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

            GenerarId();

        }
        public void GenerarId()
        {
            string rutaArchivoID = "C:\\Users\\NORMA\\Desktop\\Fernando\\C#\\Entrevistas\\Problemas\\Veterinaria\\Veterinaria\\ID.txt";


            int id = 0;
            if (File.Exists(rutaArchivoID))
            {
                string[] lines = File.ReadAllLines(rutaArchivoID);
                if (lines.Length > 0)
                {
                    if (int.TryParse(lines[lines.Length - 1], out int lastId))
                    {
                        id = lastId;
                    }
                }
            }

            id++; // Incrementar el ID

            string texto = TXTProblemas.Text;
            string rutaArchivo = "C:\\Users\\NORMA\\Desktop\\Fernando\\C#\\Entrevistas\\Problemas\\Veterinaria\\Veterinaria\\Cita.txt";

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine($"El id es: {id}");
                writer.WriteLine($"El problema(s): {texto}");
                writer.WriteLine($"Y precio de: {precio}");
                writer.WriteLine($"-------------------------------------------------------");
                writer.Close();

                // Actualizar el archivo de ID con el nuevo ID
                File.AppendAllText(rutaArchivoID, id.ToString() + Environment.NewLine);

                MessageBox.Show("Cita guardada en el txt");
            }

        }
    }
}
