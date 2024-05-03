namespace JyE
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.botonEliminar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.textoDireccion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textoTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textoApellidoMaterno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textoApellidoPaterno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textoNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caja1 = new System.Windows.Forms.GroupBox();
            this.textoCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textoDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.caja2 = new System.Windows.Forms.GroupBox();
            this.botonCargar = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.caja1.SuspendLayout();
            this.caja2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.DarkCyan;
            this.botonEliminar.ForeColor = System.Drawing.Color.White;
            this.botonEliminar.Location = new System.Drawing.Point(28, 358);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(97, 23);
            this.botonEliminar.TabIndex = 4;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(28, 91);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(793, 210);
            this.dgvClientes.TabIndex = 3;
            // 
            // botonActualizar
            // 
            this.botonActualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.botonActualizar.ForeColor = System.Drawing.Color.White;
            this.botonActualizar.Location = new System.Drawing.Point(244, 390);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(75, 23);
            this.botonActualizar.TabIndex = 16;
            this.botonActualizar.Text = "Actualizar";
            this.botonActualizar.UseVisualStyleBackColor = false;
            this.botonActualizar.Click += new System.EventHandler(this.botonActualizar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.BackColor = System.Drawing.Color.DarkCyan;
            this.botonGuardar.ForeColor = System.Drawing.Color.White;
            this.botonGuardar.Location = new System.Drawing.Point(89, 390);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 15;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // textoDireccion
            // 
            this.textoDireccion.Location = new System.Drawing.Point(142, 329);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(140, 20);
            this.textoDireccion.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dirección:";
            // 
            // textoTelefono
            // 
            this.textoTelefono.Location = new System.Drawing.Point(142, 270);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(140, 20);
            this.textoTelefono.TabIndex = 11;
            this.textoTelefono.TextChanged += new System.EventHandler(this.textoTelefono_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefóno:";
            // 
            // textoApellidoMaterno
            // 
            this.textoApellidoMaterno.Location = new System.Drawing.Point(142, 225);
            this.textoApellidoMaterno.Name = "textoApellidoMaterno";
            this.textoApellidoMaterno.Size = new System.Drawing.Size(140, 20);
            this.textoApellidoMaterno.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Apellido Materno:";
            // 
            // textoApellidoPaterno
            // 
            this.textoApellidoPaterno.Location = new System.Drawing.Point(142, 180);
            this.textoApellidoPaterno.Name = "textoApellidoPaterno";
            this.textoApellidoPaterno.Size = new System.Drawing.Size(140, 20);
            this.textoApellidoPaterno.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido Paterno:";
            // 
            // textoNombres
            // 
            this.textoNombres.Location = new System.Drawing.Point(142, 141);
            this.textoNombres.Name = "textoNombres";
            this.textoNombres.Size = new System.Drawing.Size(140, 20);
            this.textoNombres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // caja1
            // 
            this.caja1.Controls.Add(this.textoCodigo);
            this.caja1.Controls.Add(this.label1);
            this.caja1.Controls.Add(this.botonActualizar);
            this.caja1.Controls.Add(this.botonGuardar);
            this.caja1.Controls.Add(this.textoDireccion);
            this.caja1.Controls.Add(this.label8);
            this.caja1.Controls.Add(this.textoTelefono);
            this.caja1.Controls.Add(this.label6);
            this.caja1.Controls.Add(this.textoApellidoMaterno);
            this.caja1.Controls.Add(this.label5);
            this.caja1.Controls.Add(this.textoApellidoPaterno);
            this.caja1.Controls.Add(this.label4);
            this.caja1.Controls.Add(this.textoNombres);
            this.caja1.Controls.Add(this.label3);
            this.caja1.Controls.Add(this.textoDni);
            this.caja1.Controls.Add(this.label2);
            this.caja1.ForeColor = System.Drawing.Color.Blue;
            this.caja1.Location = new System.Drawing.Point(8, 94);
            this.caja1.Name = "caja1";
            this.caja1.Size = new System.Drawing.Size(410, 435);
            this.caja1.TabIndex = 22;
            this.caja1.TabStop = false;
            this.caja1.Text = "Datos";
            // 
            // textoCodigo
            // 
            this.textoCodigo.Location = new System.Drawing.Point(142, 54);
            this.textoCodigo.Name = "textoCodigo";
            this.textoCodigo.Size = new System.Drawing.Size(140, 20);
            this.textoCodigo.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Codigo:";
            // 
            // textoDni
            // 
            this.textoDni.Location = new System.Drawing.Point(142, 96);
            this.textoDni.Name = "textoDni";
            this.textoDni.Size = new System.Drawing.Size(140, 20);
            this.textoDni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // caja2
            // 
            this.caja2.Controls.Add(this.botonCargar);
            this.caja2.Controls.Add(this.botonEliminar);
            this.caja2.Controls.Add(this.dgvClientes);
            this.caja2.ForeColor = System.Drawing.Color.Blue;
            this.caja2.Location = new System.Drawing.Point(449, 94);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(840, 435);
            this.caja2.TabIndex = 23;
            this.caja2.TabStop = false;
            this.caja2.Text = "Listado de Clientes";
            // 
            // botonCargar
            // 
            this.botonCargar.BackColor = System.Drawing.Color.DarkCyan;
            this.botonCargar.ForeColor = System.Drawing.Color.White;
            this.botonCargar.Location = new System.Drawing.Point(360, 43);
            this.botonCargar.Name = "botonCargar";
            this.botonCargar.Size = new System.Drawing.Size(172, 23);
            this.botonCargar.TabIndex = 5;
            this.botonCargar.Text = "Mostrar Clientes";
            this.botonCargar.UseVisualStyleBackColor = false;
            this.botonCargar.Click += new System.EventHandler(this.botonCargar_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.Label7.Location = new System.Drawing.Point(203, 34);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(215, 29);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "Registro Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1301, 541);
            this.Controls.Add(this.caja1);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.caja1.ResumeLayout(false);
            this.caja1.PerformLayout();
            this.caja2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.TextBox textoDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoApellidoMaterno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textoApellidoPaterno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox caja1;
        private System.Windows.Forms.TextBox textoDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox caja2;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botonCargar;
        private System.Windows.Forms.TextBox textoCodigo;
        private System.Windows.Forms.Label label1;
    }
}