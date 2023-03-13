namespace TP_13._03
{
    public partial class SalarioFuncionario : Form
    {
        public SalarioFuncionario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = txtbNome.Text;
            funcionario.CPF = mtxtCPF.Text;
            funcionario.DiasTrabalhados = float.Parse(txtbDiasTrabalhados.Text);
            funcionario.ValorDiaria = float.Parse(txtBValorDiaria.Text);

            funcionario.CalcSalBase();
            txtbSalBase.Text = funcionario.salBase.ToString();

            funcionario.CalcPercIR();
            funcionario.CalcIR();
            txtbValIR.Text = funcionario.IR.ToString();

            funcionario.CalcSalLiq();
            txtbSalLiq.Text =  funcionario.salLiq.ToString();
            //funcionario.ResetSalLiq();
        }
    }
}