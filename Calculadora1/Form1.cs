namespace Calculadora1
{
    public partial class FrmCalculadora : Form
    {
        private decimal Resultado { get; set; }

        private decimal Valor { get; set; }


        private Operacao OperacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtResultado.Text = "";
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";

        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";

        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";

        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";

        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";

        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";

        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnDoisZeros_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "00";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        { 
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);

                    break;
                default:
                    break;
            }
            txtResultado.Text = Convert.ToString(Resultado);
        }

        private void btnVirgulas_Click(object sender, EventArgs e)
        {
            //Verifica se o textBox já contém uma virgula, caso nao tenha, Aplica a concatenação
            if (!txtResultado.Text.Contains(","))

            {
                txtResultado.Text += ",";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtResultado.Text))

            {
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);

                //para manter o cursor no final do texto
                txtResultado.SelectionStart = txtResultado.Text.Length;
            }
        }
    }
}

