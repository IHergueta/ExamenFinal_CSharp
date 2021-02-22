namespace ExamenFinal
{
    partial class Form2
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
            this.cb_clientes = new System.Windows.Forms.ComboBox();
            this.lb_monopatines = new System.Windows.Forms.ListBox();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_clientes
            // 
            this.cb_clientes.FormattingEnabled = true;
            this.cb_clientes.Location = new System.Drawing.Point(287, 289);
            this.cb_clientes.Name = "cb_clientes";
            this.cb_clientes.Size = new System.Drawing.Size(258, 28);
            this.cb_clientes.TabIndex = 0;
            this.cb_clientes.SelectedIndexChanged += new System.EventHandler(this.cb_clientes_SelectedIndexChanged);
            // 
            // lb_monopatines
            // 
            this.lb_monopatines.FormattingEnabled = true;
            this.lb_monopatines.ItemHeight = 20;
            this.lb_monopatines.Location = new System.Drawing.Point(287, 23);
            this.lb_monopatines.Name = "lb_monopatines";
            this.lb_monopatines.Size = new System.Drawing.Size(258, 204);
            this.lb_monopatines.TabIndex = 1;
            this.lb_monopatines.SelectedIndexChanged += new System.EventHandler(this.lb_monopatines_SelectedIndexChanged);
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(346, 355);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(152, 63);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lb_monopatines);
            this.Controls.Add(this.cb_clientes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_clientes;
        private System.Windows.Forms.ListBox lb_monopatines;
        private System.Windows.Forms.Button btn_volver;
    }
}