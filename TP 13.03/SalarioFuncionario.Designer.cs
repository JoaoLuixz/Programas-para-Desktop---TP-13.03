namespace TP_13._03
{
    partial class SalarioFuncionario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lbDiasTrabalhados = new System.Windows.Forms.Label();
            this.lbValorDiaria = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbDiasTrabalhados = new System.Windows.Forms.TextBox();
            this.txtBValorDiaria = new System.Windows.Forms.TextBox();
            this.mtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbSalBase = new System.Windows.Forms.Label();
            this.lbValIR = new System.Windows.Forms.Label();
            this.lbSalLiq = new System.Windows.Forms.Label();
            this.txtbSalBase = new System.Windows.Forms.TextBox();
            this.txtbValIR = new System.Windows.Forms.TextBox();
            this.txtbSalLiq = new System.Windows.Forms.TextBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(35, 142);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(54, 18);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Location = new System.Drawing.Point(236, 142);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(45, 18);
            this.lbCPF.TabIndex = 1;
            this.lbCPF.Text = "CPF:";
            // 
            // lbDiasTrabalhados
            // 
            this.lbDiasTrabalhados.AutoSize = true;
            this.lbDiasTrabalhados.Location = new System.Drawing.Point(35, 189);
            this.lbDiasTrabalhados.Name = "lbDiasTrabalhados";
            this.lbDiasTrabalhados.Size = new System.Drawing.Size(131, 18);
            this.lbDiasTrabalhados.TabIndex = 2;
            this.lbDiasTrabalhados.Text = "Dias trabalhados:";
            // 
            // lbValorDiaria
            // 
            this.lbValorDiaria.AutoSize = true;
            this.lbValorDiaria.Location = new System.Drawing.Point(292, 192);
            this.lbValorDiaria.Name = "lbValorDiaria";
            this.lbValorDiaria.Size = new System.Drawing.Size(95, 18);
            this.lbValorDiaria.TabIndex = 3;
            this.lbValorDiaria.Text = "Valor Diária:";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(95, 139);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(100, 26);
            this.txtbNome.TabIndex = 1;
            // 
            // txtbDiasTrabalhados
            // 
            this.txtbDiasTrabalhados.Location = new System.Drawing.Point(172, 189);
            this.txtbDiasTrabalhados.Name = "txtbDiasTrabalhados";
            this.txtbDiasTrabalhados.Size = new System.Drawing.Size(100, 26);
            this.txtbDiasTrabalhados.TabIndex = 3;
            // 
            // txtBValorDiaria
            // 
            this.txtBValorDiaria.Location = new System.Drawing.Point(393, 192);
            this.txtBValorDiaria.Name = "txtBValorDiaria";
            this.txtBValorDiaria.Size = new System.Drawing.Size(100, 26);
            this.txtBValorDiaria.TabIndex = 4;
            // 
            // mtxtCPF
            // 
            this.mtxtCPF.Location = new System.Drawing.Point(287, 134);
            this.mtxtCPF.Mask = "000,000,000,00";
            this.mtxtCPF.Name = "mtxtCPF";
            this.mtxtCPF.Size = new System.Drawing.Size(100, 26);
            this.mtxtCPF.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(378, 359);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(115, 53);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbSalBase
            // 
            this.lbSalBase.AutoSize = true;
            this.lbSalBase.Location = new System.Drawing.Point(21, 324);
            this.lbSalBase.Name = "lbSalBase";
            this.lbSalBase.Size = new System.Drawing.Size(103, 18);
            this.lbSalBase.TabIndex = 10;
            this.lbSalBase.Text = "Salário Base:";
            // 
            // lbValIR
            // 
            this.lbValIR.AutoSize = true;
            this.lbValIR.Location = new System.Drawing.Point(23, 376);
            this.lbValIR.Name = "lbValIR";
            this.lbValIR.Size = new System.Drawing.Size(66, 18);
            this.lbValIR.TabIndex = 11;
            this.lbValIR.Text = "Valor IR:";
            // 
            // lbSalLiq
            // 
            this.lbSalLiq.AutoSize = true;
            this.lbSalLiq.Location = new System.Drawing.Point(23, 422);
            this.lbSalLiq.Name = "lbSalLiq";
            this.lbSalLiq.Size = new System.Drawing.Size(117, 18);
            this.lbSalLiq.TabIndex = 12;
            this.lbSalLiq.Text = "Salário Líquido:";
            // 
            // txtbSalBase
            // 
            this.txtbSalBase.Location = new System.Drawing.Point(129, 321);
            this.txtbSalBase.Name = "txtbSalBase";
            this.txtbSalBase.Size = new System.Drawing.Size(126, 26);
            this.txtbSalBase.TabIndex = 13;
            // 
            // txtbValIR
            // 
            this.txtbValIR.Location = new System.Drawing.Point(95, 373);
            this.txtbValIR.Name = "txtbValIR";
            this.txtbValIR.Size = new System.Drawing.Size(126, 26);
            this.txtbValIR.TabIndex = 14;
            // 
            // txtbSalLiq
            // 
            this.txtbSalLiq.Location = new System.Drawing.Point(146, 419);
            this.txtbSalLiq.Name = "txtbSalLiq";
            this.txtbSalLiq.Size = new System.Drawing.Size(114, 26);
            this.txtbSalLiq.TabIndex = 15;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTitulo.Location = new System.Drawing.Point(200, 20);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(154, 22);
            this.lbTitulo.TabIndex = 16;
            this.lbTitulo.Text = "Calculadora SVS";
            // 
            // SalarioFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 544);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtbSalLiq);
            this.Controls.Add(this.txtbValIR);
            this.Controls.Add(this.txtbSalBase);
            this.Controls.Add(this.lbSalLiq);
            this.Controls.Add(this.lbValIR);
            this.Controls.Add(this.lbSalBase);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mtxtCPF);
            this.Controls.Add(this.txtBValorDiaria);
            this.Controls.Add(this.txtbDiasTrabalhados);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lbValorDiaria);
            this.Controls.Add(this.lbDiasTrabalhados);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SalarioFuncionario";
            this.Text = "Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbNome;
        private Label lbCPF;
        private Label lbDiasTrabalhados;
        private Label lbValorDiaria;
        private TextBox txtbNome;
        private TextBox txtbDiasTrabalhados;
        private TextBox txtBValorDiaria;
        private MaskedTextBox mtxtCPF;
        private Button btnCalcular;
        private Label lbSalBase;
        private Label lbValIR;
        private Label lbSalLiq;
        private TextBox txtbSalBase;
        private TextBox txtbValIR;
        private TextBox txtbSalLiq;
        private Label lbTitulo;
    }
}