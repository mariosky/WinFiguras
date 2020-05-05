namespace WindowsFigura
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse = new System.Windows.Forms.Button();
            this.Rectangulo = new System.Windows.Forms.Button();
            this.Seleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // Elipse
            // 
            this.Elipse.Location = new System.Drawing.Point(619, 3);
            this.Elipse.Name = "Elipse";
            this.Elipse.Size = new System.Drawing.Size(75, 23);
            this.Elipse.TabIndex = 1;
            this.Elipse.Text = "Elipse";
            this.Elipse.UseVisualStyleBackColor = true;
            this.Elipse.Click += new System.EventHandler(this.elipse_Click);
            // 
            // Rectangulo
            // 
            this.Rectangulo.Location = new System.Drawing.Point(700, 3);
            this.Rectangulo.Name = "Rectangulo";
            this.Rectangulo.Size = new System.Drawing.Size(75, 23);
            this.Rectangulo.TabIndex = 2;
            this.Rectangulo.Text = "Rectángulo";
            this.Rectangulo.UseVisualStyleBackColor = true;
            this.Rectangulo.Click += new System.EventHandler(this.rectangulo_Click);
            // 
            // Seleccion
            // 
            this.Seleccion.Location = new System.Drawing.Point(538, 3);
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Size = new System.Drawing.Size(75, 23);
            this.Seleccion.TabIndex = 0;
            this.Seleccion.Text = "Selección";
            this.Seleccion.UseVisualStyleBackColor = true;
            this.Seleccion.Click += new System.EventHandler(this.seleccion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seleccion);
            this.Controls.Add(this.Rectangulo);
            this.Controls.Add(this.Elipse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Elipse;
        private System.Windows.Forms.Button Rectangulo;
        private System.Windows.Forms.Button Seleccion;
    }
}

