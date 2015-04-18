namespace CalculadoraQuilometragem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numInicial = new System.Windows.Forms.NumericUpDown();
            this.numFinal = new System.Windows.Forms.NumericUpDown();
            this.btnName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KM Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KM Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade devida";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(136, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(51, 16);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "label4";
            // 
            // numInicial
            // 
            this.numInicial.Location = new System.Drawing.Point(115, 46);
            this.numInicial.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numInicial.Name = "numInicial";
            this.numInicial.Size = new System.Drawing.Size(120, 20);
            this.numInicial.TabIndex = 4;
            // 
            // numFinal
            // 
            this.numFinal.Location = new System.Drawing.Point(115, 85);
            this.numFinal.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFinal.Name = "numFinal";
            this.numFinal.Size = new System.Drawing.Size(120, 20);
            this.numFinal.TabIndex = 5;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(97, 133);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(112, 35);
            this.btnName.TabIndex = 6;
            this.btnName.Text = "Calcular";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 245);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.numFinal);
            this.Controls.Add(this.numInicial);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFinal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numInicial;
        private System.Windows.Forms.NumericUpDown numFinal;
        private System.Windows.Forms.Button btnName;
    }
}

