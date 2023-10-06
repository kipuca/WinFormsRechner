namespace WinFormsRechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            try
            {
                // Fehlerausgabe zurücksetzen
                lblError.Text = "";
                lblError.BackColor = SystemColors.Control;

                // Zahl1 lesen
                string strZahl1 = cboZahl1.Text;
                double dZahl1 = Convert.ToDouble(strZahl1);

                string strRechenart = cboRechenart.Text;

                // Zahl2 einlesen
                string strZahl2 = cboZahl2.Text;
                double dZahl2 = Convert.ToDouble(strZahl2);

                double dErgebnis = 0;

                switch (strRechenart)
                {
                    case "+": dErgebnis = dZahl1 + dZahl2; break;
                    case "-": dErgebnis = dZahl1 - dZahl2; break;
                    case "*": dErgebnis = dZahl1 * dZahl2; break;
                    case "/": dErgebnis = dZahl1 / dZahl2; break;
                    case "%": dErgebnis = dZahl1 % dZahl2; break;

                }
                txtErgebnis.Text = dErgebnis.ToString();

            }
            catch (Exception ex)
            {
                // Fehlerausgabe im Ausgabe Fenster
                System.Diagnostics.Debug.WriteLine(ex);

                //Fehlerausgabe in lblError
                lblError.BackColor = Color.Red;
                lblError.Text = "Bist du zu doof um Zahlen einzugeben???";

            }
        }


        private void cboZahl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboZahl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboRechenart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }
    }
}