
namespace MaiorValorEntreTres.View
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.nUDValor1 = new System.Windows.Forms.NumericUpDown();
            this.nUDValor2 = new System.Windows.Forms.NumericUpDown();
            this.nUDValor3 = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(80, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(199, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Digite três valores";
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor1.Location = new System.Drawing.Point(40, 88);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(62, 20);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.Text = "Valor 1:";
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor2.Location = new System.Drawing.Point(40, 144);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(62, 20);
            this.lblValor2.TabIndex = 2;
            this.lblValor2.Text = "Valor 2:";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValor3.Location = new System.Drawing.Point(40, 192);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(62, 20);
            this.lblValor3.TabIndex = 3;
            this.lblValor3.Text = "Valor 3:";
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Location = new System.Drawing.Point(56, 288);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(248, 78);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nUDValor1
            // 
            this.nUDValor1.Location = new System.Drawing.Point(120, 88);
            this.nUDValor1.Name = "nUDValor1";
            this.nUDValor1.Size = new System.Drawing.Size(128, 23);
            this.nUDValor1.TabIndex = 5;
            // 
            // nUDValor2
            // 
            this.nUDValor2.Location = new System.Drawing.Point(120, 144);
            this.nUDValor2.Name = "nUDValor2";
            this.nUDValor2.Size = new System.Drawing.Size(128, 23);
            this.nUDValor2.TabIndex = 6;
            // 
            // nUDValor3
            // 
            this.nUDValor3.Location = new System.Drawing.Point(120, 192);
            this.nUDValor3.Name = "nUDValor3";
            this.nUDValor3.Size = new System.Drawing.Size(128, 23);
            this.nUDValor3.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(144, 248);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(72, 24);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular ";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.nUDValor3);
            this.Controls.Add(this.nUDValor2);
            this.Controls.Add(this.nUDValor1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Exibir Maior Valor de Três";
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDValor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown nUDValor1;
        private System.Windows.Forms.NumericUpDown nUDValor2;
        private System.Windows.Forms.NumericUpDown nUDValor3;
        private System.Windows.Forms.Button btnCalcular;
    }
}