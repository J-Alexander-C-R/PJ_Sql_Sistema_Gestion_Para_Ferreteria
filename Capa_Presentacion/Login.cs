using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        private CN_Login objNegocio = new CN_Login();
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void ckb_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Mostrar.Checked == true)  // TODO Esto Verifica si el CheckBox (ckb_Mostrar) está marcado
            {
                if (txt_Contraseña.PasswordChar == '*') //TODO Si el cuadro de texto tiene como carácter de contraseña '*', lo cambia a '\0' (sin ocultar)
                {
                    txt_Contraseña.PasswordChar = '\0';
                }
            }
            else
            {
                txt_Contraseña.PasswordChar = '*'; //TODO Muestra la contraseña
            }
        }

        

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text.Trim();
            string contraseña = txt_Contraseña.Text.Trim();

            //TODO Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //TODO Llamar a la capa de negocios para validar el usuario
            if (objNegocio.ValidarUsuario(usuario, contraseña))
            {
                MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //TODO Abrir el formulario principal y ocultar el de login
                this.Hide();
                Frm_Principal formPrincipal = new Frm_Principal();
                formPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
