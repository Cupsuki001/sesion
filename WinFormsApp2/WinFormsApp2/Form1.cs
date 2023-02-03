namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNingresar_Click(object sender, EventArgs e)
        {
            string usuario, contra;
            int limit = 100;

            usuario = Convert.ToString(TXBusuario.Text);
            contra = Convert.ToString(TXBNcontra.Text);

            if(usuario == "" && contra == "") 
            {
                MessageBox.Show("ERROR. Se necesita la informacion para acceder");
                TXBusuario.Focus();
            }
            else if(usuario == "jeremy" && contra == "quesillo")
            {

                prueba j = new prueba();
                j.Show();
               

               

            }
            else 
            {
                MessageBox.Show("Por favor verifique los datos ingresados");
                TXBusuario.Text = "";
                TXBusuario.Focus();
                TXBNcontra.Text = "";
                TXBNcontra.Focus();
            }
           
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXBusuario.Text = "";
            TXBNcontra.Text = "";

        }

        private void BTNsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BRRP.Value < 100)
            {
                BRRP.Value += 1;

                porcentaje.Text = BRRP.Value.ToString() + "%";


            }
            else
            {
                timer1.Stop();
            }
        }

        private void BRRP_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}