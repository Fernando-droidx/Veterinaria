namespace Veterinaria
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTnombre = new System.Windows.Forms.Panel();
            this.BTNguardar = new System.Windows.Forms.Button();
            this.TXTdireccion = new System.Windows.Forms.TextBox();
            this.TXTtelefono = new System.Windows.Forms.TextBox();
            this.TXTnombremascota = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTnombre.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTnombre
            // 
            this.TXTnombre.Controls.Add(this.BTNguardar);
            this.TXTnombre.Controls.Add(this.TXTdireccion);
            this.TXTnombre.Controls.Add(this.TXTtelefono);
            this.TXTnombre.Controls.Add(this.TXTnombremascota);
            this.TXTnombre.Controls.Add(this.textBox1);
            this.TXTnombre.Controls.Add(this.label5);
            this.TXTnombre.Controls.Add(this.label4);
            this.TXTnombre.Controls.Add(this.label3);
            this.TXTnombre.Controls.Add(this.label2);
            this.TXTnombre.Controls.Add(this.label1);
            this.TXTnombre.Location = new System.Drawing.Point(1, 1);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(798, 449);
            this.TXTnombre.TabIndex = 0;
            // 
            // BTNguardar
            // 
            this.BTNguardar.Location = new System.Drawing.Point(385, 341);
            this.BTNguardar.Name = "BTNguardar";
            this.BTNguardar.Size = new System.Drawing.Size(75, 23);
            this.BTNguardar.TabIndex = 9;
            this.BTNguardar.Text = "Guardar";
            this.BTNguardar.UseVisualStyleBackColor = true;
            this.BTNguardar.Click += new System.EventHandler(this.BTNguardar_Click);
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.Location = new System.Drawing.Point(565, 154);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.Size = new System.Drawing.Size(100, 23);
            this.TXTdireccion.TabIndex = 8;
            this.TXTdireccion.TextChanged += new System.EventHandler(this.TXTdireccion_TextChanged);
            // 
            // TXTtelefono
            // 
            this.TXTtelefono.Location = new System.Drawing.Point(565, 207);
            this.TXTtelefono.Name = "TXTtelefono";
            this.TXTtelefono.Size = new System.Drawing.Size(100, 23);
            this.TXTtelefono.TabIndex = 7;
            this.TXTtelefono.TextChanged += new System.EventHandler(this.TXTtelefono_TextChanged);
            // 
            // TXTnombremascota
            // 
            this.TXTnombremascota.Location = new System.Drawing.Point(565, 253);
            this.TXTnombremascota.Name = "TXTnombremascota";
            this.TXTnombremascota.Size = new System.Drawing.Size(100, 23);
            this.TXTnombremascota.TabIndex = 6;
            this.TXTnombremascota.TextChanged += new System.EventHandler(this.TXTnombremascota_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de la mascota";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos a la veterinaria";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TXTnombre);
            this.Name = "Menu";
            this.Text = "Menu";
            this.TXTnombre.ResumeLayout(false);
            this.TXTnombre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel TXTnombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TXTdireccion;
        private TextBox TXTtelefono;
        private TextBox TXTnombremascota;
        private TextBox textBox1;
        private Button BTNguardar;
    }
}