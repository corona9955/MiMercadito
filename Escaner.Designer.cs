namespace Modelado_1_Mi_mercadito
{
    partial class Escaner
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
            this.nombre_empresa = new System.Windows.Forms.Label();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_slider = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_datosproducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // nombre_empresa
            // 
            this.nombre_empresa.AutoSize = true;
            this.nombre_empresa.BackColor = System.Drawing.Color.Transparent;
            this.nombre_empresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nombre_empresa.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_empresa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nombre_empresa.Location = new System.Drawing.Point(-5, 10);
            this.nombre_empresa.Name = "nombre_empresa";
            this.nombre_empresa.Size = new System.Drawing.Size(165, 27);
            this.nombre_empresa.TabIndex = 1;
            this.nombre_empresa.Text = "Mi Mercadito";
            this.nombre_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nombre_empresa.Click += new System.EventHandler(this.nombre_empresa_Click);
            // 
            // busqueda
            // 
            this.busqueda.BackColor = System.Drawing.Color.Black;
            this.busqueda.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.busqueda.Location = new System.Drawing.Point(166, 10);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(302, 26);
            this.busqueda.TabIndex = 2;
            this.busqueda.Text = "Buscar producto...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.nombre_empresa);
            this.groupBox1.Controls.Add(this.busqueda);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 370);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(483, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn_slider);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(6, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 324);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto Blanco de la Lista";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(6, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Total: $";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_slider
            // 
            this.btn_slider.BackColor = System.Drawing.Color.Transparent;
            this.btn_slider.ForeColor = System.Drawing.Color.Black;
            this.btn_slider.Location = new System.Drawing.Point(68, 134);
            this.btn_slider.Name = "btn_slider";
            this.btn_slider.Size = new System.Drawing.Size(46, 23);
            this.btn_slider.TabIndex = 6;
            this.btn_slider.Text = "Slider";
            this.btn_slider.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl_datosproducto);
            this.groupBox3.Location = new System.Drawing.Point(6, 377);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 118);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del producto escaneado";
            // 
            // lbl_datosproducto
            // 
            this.lbl_datosproducto.AutoSize = true;
            this.lbl_datosproducto.Location = new System.Drawing.Point(30, 29);
            this.lbl_datosproducto.Name = "lbl_datosproducto";
            this.lbl_datosproducto.Size = new System.Drawing.Size(522, 13);
            this.lbl_datosproducto.TabIndex = 0;
            this.lbl_datosproducto.Text = "Nombre del producto, marca, costo, contenido (azucares, sal, carbohidratos, grasa" +
    "s trans, etc) y el costo total\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar al carrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eliminar del carrito";
            // 
            // Escaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 507);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Escaner";
            this.Text = "Escaner";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nombre_empresa;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_slider;
        private System.Windows.Forms.Label lbl_datosproducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}