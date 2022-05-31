namespace Cliente_ConversionUnidades
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pulgadasAcentimetros = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_pulgadasAcentimetros = new System.Windows.Forms.Button();
            this.btn_centimetrosApulgadas = new System.Windows.Forms.Button();
            this.txt_centimetrosApulgadas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversión Unidades";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pulgadas a centimetros";
            // 
            // txt_pulgadasAcentimetros
            // 
            this.txt_pulgadasAcentimetros.Location = new System.Drawing.Point(48, 173);
            this.txt_pulgadasAcentimetros.Name = "txt_pulgadasAcentimetros";
            this.txt_pulgadasAcentimetros.Size = new System.Drawing.Size(106, 22);
            this.txt_pulgadasAcentimetros.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Centimetros a pulgadas";
            // 
            // btn_pulgadasAcentimetros
            // 
            this.btn_pulgadasAcentimetros.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pulgadasAcentimetros.Location = new System.Drawing.Point(453, 160);
            this.btn_pulgadasAcentimetros.Name = "btn_pulgadasAcentimetros";
            this.btn_pulgadasAcentimetros.Size = new System.Drawing.Size(136, 40);
            this.btn_pulgadasAcentimetros.TabIndex = 5;
            this.btn_pulgadasAcentimetros.Text = "Convertir";
            this.btn_pulgadasAcentimetros.UseVisualStyleBackColor = true;
            this.btn_pulgadasAcentimetros.Click += new System.EventHandler(this.btn_pulgadasAcentimetros_Click);
            // 
            // btn_centimetrosApulgadas
            // 
            this.btn_centimetrosApulgadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_centimetrosApulgadas.Location = new System.Drawing.Point(453, 249);
            this.btn_centimetrosApulgadas.Name = "btn_centimetrosApulgadas";
            this.btn_centimetrosApulgadas.Size = new System.Drawing.Size(136, 41);
            this.btn_centimetrosApulgadas.TabIndex = 6;
            this.btn_centimetrosApulgadas.Text = "Convertir";
            this.btn_centimetrosApulgadas.UseVisualStyleBackColor = true;
            this.btn_centimetrosApulgadas.Click += new System.EventHandler(this.btn_centimetrosApulgadas_Click);
            // 
            // txt_centimetrosApulgadas
            // 
            this.txt_centimetrosApulgadas.Location = new System.Drawing.Point(54, 285);
            this.txt_centimetrosApulgadas.Name = "txt_centimetrosApulgadas";
            this.txt_centimetrosApulgadas.Size = new System.Drawing.Size(100, 22);
            this.txt_centimetrosApulgadas.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_centimetrosApulgadas);
            this.Controls.Add(this.btn_centimetrosApulgadas);
            this.Controls.Add(this.btn_pulgadasAcentimetros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_pulgadasAcentimetros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pulgadasAcentimetros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pulgadasAcentimetros;
        private System.Windows.Forms.Button btn_centimetrosApulgadas;
        private System.Windows.Forms.TextBox txt_centimetrosApulgadas;
    }
}

