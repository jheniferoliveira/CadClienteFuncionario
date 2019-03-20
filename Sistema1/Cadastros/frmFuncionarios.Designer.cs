namespace Cadastros
{
    partial class frmFuncionarios
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.grbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(104, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;
            // 
            // grbEstadoCivil
            // 
            this.grbEstadoCivil.Controls.Add(this.rdbCasado);
            this.grbEstadoCivil.Controls.Add(this.rdbSolteiro);
            this.grbEstadoCivil.Location = new System.Drawing.Point(54, 65);
            this.grbEstadoCivil.Name = "grbEstadoCivil";
            this.grbEstadoCivil.Size = new System.Drawing.Size(200, 43);
            this.grbEstadoCivil.TabIndex = 2;
            this.grbEstadoCivil.TabStop = false;
            this.grbEstadoCivil.Text = "Estado Civil";
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(7, 16);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(72, 17);
            this.rdbSolteiro.TabIndex = 0;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro(a)";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(86, 16);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(73, 17);
            this.rdbCasado.TabIndex = 1;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado(a)";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(54, 125);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(200, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 189);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grbEstadoCivil);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.grbEstadoCivil.ResumeLayout(false);
            this.grbEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox grbEstadoCivil;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.Button btnSalvar;
    }
}