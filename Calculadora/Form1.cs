namespace Calculadora
{
    public partial class Form1 : Form
    {
        private Decimal NumeroIngresado = 0;
        private Decimal Resultado = 0;
        private string operacion = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }
        #region MetodosInterface
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button9.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button10.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button7.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button4.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button11.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PonerNroTextBox(button1.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtbNro.Text = string.Empty;
            operacion = string.Empty;
            NumeroIngresado = 0;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            AsignarOperacion("+");
        }



        private void btnRestar_Click(object sender, EventArgs e)
        {
            AsignarOperacion("-");
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            AsignarOperacion("*");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            AsignarOperacion("/");
        }
        #endregion

        #region MetodosPrivados
        private void PonerNroTextBox(string nro)
        {
            txtbNro.Text = txtbNro.Text + nro;
            NumeroIngresado = Convert.ToDecimal(txtbNro.Text);
        }
        private void AsignarOperacion(string op)
        {
            operacion = op;
            txtbNro.Text=string.Empty;
        }
        #endregion
    }
}