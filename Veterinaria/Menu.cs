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
                MenuMascota mascota = new MenuMascota();
                mascota.Show();

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
