namespace ExamenFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_monopatin = new System.Windows.Forms.ListBox();
            this.lb_cliente = new System.Windows.Forms.ListBox();
            this.btn_toForm2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_alquilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_monopatin
            // 
            this.lb_monopatin.FormattingEnabled = true;
            this.lb_monopatin.ItemHeight = 20;
            this.lb_monopatin.Location = new System.Drawing.Point(106, 39);
            this.lb_monopatin.Name = "lb_monopatin";
            this.lb_monopatin.Size = new System.Drawing.Size(231, 204);
            this.lb_monopatin.TabIndex = 0;
            this.lb_monopatin.SelectedIndexChanged += new System.EventHandler(this.lb_monopatin_SelectedIndexChanged);
            // 
            // lb_cliente
            // 
            this.lb_cliente.BackColor = System.Drawing.Color.White;
            this.lb_cliente.FormattingEnabled = true;
            this.lb_cliente.ItemHeight = 20;
            this.lb_cliente.Location = new System.Drawing.Point(490, 39);
            this.lb_cliente.Name = "lb_cliente";
            this.lb_cliente.Size = new System.Drawing.Size(231, 204);
            this.lb_cliente.TabIndex = 1;
            // 
            // btn_toForm2
            // 
            this.btn_toForm2.Location = new System.Drawing.Point(351, 316);
            this.btn_toForm2.Name = "btn_toForm2";
            this.btn_toForm2.Size = new System.Drawing.Size(120, 78);
            this.btn_toForm2.TabIndex = 2;
            this.btn_toForm2.Text = "Eliminiar monopatin";
            this.btn_toForm2.UseVisualStyleBackColor = true;
            this.btn_toForm2.Click += new System.EventHandler(this.btn_toForm2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_alquilar
            // 
            this.btn_alquilar.Location = new System.Drawing.Point(128, 316);
            this.btn_alquilar.Name = "btn_alquilar";
            this.btn_alquilar.Size = new System.Drawing.Size(120, 78);
            this.btn_alquilar.TabIndex = 4;
            this.btn_alquilar.Text = "Alquilar";
            this.btn_alquilar.UseVisualStyleBackColor = true;
            this.btn_alquilar.Click += new System.EventHandler(this.btn_alquilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_alquilar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_toForm2);
            this.Controls.Add(this.lb_cliente);
            this.Controls.Add(this.lb_monopatin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_monopatin;
        private System.Windows.Forms.ListBox lb_cliente;
        private System.Windows.Forms.Button btn_toForm2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_alquilar;
    }
}

