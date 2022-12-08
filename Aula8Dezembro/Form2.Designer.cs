namespace Aula8Dezembro
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
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.inputTexto = new System.Windows.Forms.TextBox();
            this.inputTela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpar.ForeColor = System.Drawing.Color.Black;
            this.buttonLimpar.Location = new System.Drawing.Point(613, 66);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(134, 48);
            this.buttonLimpar.TabIndex = 0;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // inputTexto
            // 
            this.inputTexto.Location = new System.Drawing.Point(29, 40);
            this.inputTexto.Name = "inputTexto";
            this.inputTexto.Size = new System.Drawing.Size(110, 20);
            this.inputTexto.TabIndex = 1;
            this.inputTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // inputTela
            // 
            this.inputTela.Location = new System.Drawing.Point(29, 94);
            this.inputTela.Multiline = true;
            this.inputTela.Name = "inputTela";
            this.inputTela.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputTela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTela.Size = new System.Drawing.Size(542, 318);
            this.inputTela.TabIndex = 2;
            this.inputTela.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inputTela);
            this.Controls.Add(this.inputTexto);
            this.Controls.Add(this.buttonLimpar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.TextBox inputTexto;
        private System.Windows.Forms.TextBox inputTela;
    }
}