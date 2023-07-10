using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNguardar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty || TXTdireccion.Text == String.Empty || TXTtelefono.Text == String.Empty||TXTnombremascota.Text==String.Empty)
            {
                MessageBox.Show($"NO puede estar vacio ningun campo");
            }
            else
            {
                MessageBox.Show("Guardado exitoso");
                GenerarId();
                MenuMascota menuMascota = new MenuMascota();
                menuMascota.Show();

            }
            
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

            string nombre = textBox1.Text;
            string direccion = TXTdireccion.Text;
            string telefono = TXTtelefono.Text;
            string Nmascota = TXTnombremascota.Text;
            string rutaArchivo = "C:\\Users\\NORMA\\Desktop\\Fernando\\C#\\Entrevistas\\Problemas\\Veterinaria\\Veterinaria\\DocumentosDueños.txt";

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                writer.WriteLine($"ID: {id}");

                writer.WriteLine($"Dueño(s): {nombre}");
                writer.WriteLine($"Direccion: {direccion}");
                writer.WriteLine($"No. Telefono: {telefono}");
                writer.WriteLine($"Mascota: {Nmascota}");
                writer.WriteLine($"-------------------------------------------------------");
                writer.Close();

                // Actualizar el archivo de ID con el nuevo ID
                File.AppendAllText(rutaArchivoID, id.ToString() + Environment.NewLine);

                MessageBox.Show("Cita guardada en el txt");
                
            }

        }

        private void TXTdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTtelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTnombremascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
    }
}
