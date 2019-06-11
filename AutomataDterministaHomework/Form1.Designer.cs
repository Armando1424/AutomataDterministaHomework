namespace AutomataDterministaHomework
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtCapturar = new System.Windows.Forms.TextBox();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.txtCaptar = new System.Windows.Forms.TextBox();
            this.lblCifrado = new System.Windows.Forms.Label();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnThinks = new System.Windows.Forms.Button();
            this.lblDessifrado = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(276, 39);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 25);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtCapturar
            // 
            this.txtCapturar.Location = new System.Drawing.Point(12, 44);
            this.txtCapturar.Name = "txtCapturar";
            this.txtCapturar.Size = new System.Drawing.Size(237, 20);
            this.txtCapturar.TabIndex = 1;
            // 
            // lblMostrar
            // 
            this.lblMostrar.AutoSize = true;
            this.lblMostrar.Location = new System.Drawing.Point(12, 88);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(55, 13);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.Text = "Resultado";
            // 
            // txtCaptar
            // 
            this.txtCaptar.Location = new System.Drawing.Point(12, 126);
            this.txtCaptar.Name = "txtCaptar";
            this.txtCaptar.Size = new System.Drawing.Size(237, 20);
            this.txtCaptar.TabIndex = 3;
            this.txtCaptar.Visible = false;
            // 
            // lblCifrado
            // 
            this.lblCifrado.AutoSize = true;
            this.lblCifrado.Location = new System.Drawing.Point(18, 163);
            this.lblCifrado.Name = "lblCifrado";
            this.lblCifrado.Size = new System.Drawing.Size(46, 13);
            this.lblCifrado.TabIndex = 4;
            this.lblCifrado.Text = "Se cifro ";
            this.lblCifrado.Visible = false;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(276, 119);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(122, 27);
            this.btnCifrar.TabIndex = 5;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Visible = false;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnThinks
            // 
            this.btnThinks.Location = new System.Drawing.Point(-3, -2);
            this.btnThinks.Name = "btnThinks";
            this.btnThinks.Size = new System.Drawing.Size(85, 26);
            this.btnThinks.TabIndex = 6;
            this.btnThinks.Text = "Other Thinks";
            this.btnThinks.UseVisualStyleBackColor = true;
            this.btnThinks.Click += new System.EventHandler(this.btnThinks_Click);
            // 
            // lblDessifrado
            // 
            this.lblDessifrado.AutoSize = true;
            this.lblDessifrado.Location = new System.Drawing.Point(21, 192);
            this.lblDessifrado.Name = "lblDessifrado";
            this.lblDessifrado.Size = new System.Drawing.Size(56, 13);
            this.lblDessifrado.TabIndex = 7;
            this.lblDessifrado.Text = "Se Desifro";
            this.lblDessifrado.Visible = false;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(88, -1);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(45, 25);
            this.btnHide.TabIndex = 8;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 223);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.lblDessifrado);
            this.Controls.Add(this.btnThinks);
            this.Controls.Add(this.btnCifrar);
            this.Controls.Add(this.lblCifrado);
            this.Controls.Add(this.txtCaptar);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.txtCapturar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCapturar;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.TextBox txtCaptar;
        private System.Windows.Forms.Label lblCifrado;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnThinks;
        private System.Windows.Forms.Label lblDessifrado;
        private System.Windows.Forms.Button btnHide;
    }
}

