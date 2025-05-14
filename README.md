using System.Data.SqlClient;
using System.Data;

public class CD_Usuario
{
    private SqlConnection cn = new SqlConnection("Data Source=TU_SERVIDOR;Initial Catalog=TU_BD;Integrated Security=True");

    public bool Login(string usuario, string contraseña)
    {
        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario = @usuario AND Contraseña = @contraseña", cn);
        cmd.Parameters.AddWithValue("@usuario", usuario);
        cmd.Parameters.AddWithValue("@contraseña", contraseña);

        cn.Open();
        int count = (int)cmd.ExecuteScalar();
        cn.Close();

        return count > 0;
    }
}
🔹 Capa de Negocio (CN_Usuario.cs)
credeciales
    de usuario y contraseña. Si el usuario existe, devuelve true; de lo contrario, devuelve false.
    csharp;

using;system;
class program
{
    static void Main(string[] args)
    {
        // Aquí puedes probar la clase CD_Usuario
        CD_Usuario cdUsuario = new CD_Usuario();
        bool acceso = cdUsuario.Login("usuarioPrueba", "contraseñaPrueba");
        Console.WriteLine(acceso ? "Acceso correcto" : "Acceso denegado");
    }
}

public class CN_Usuario
{
    private CD_Usuario cdUsuario = new CD_Usuario();

    public bool Acceder(string usuario, string contraseña)
    {
        return cdUsuario.Login(usuario, contraseña);
    }
}
🔹 Capa de Presentación (Formulario Login - FrmLogin.cs)
Agrega dos TextBox (txtUsuario, txtContraseña) y un Button (btnIngresar).

csharp
Copiar
Editar
public partial class FrmLogin : Form
{
    private CN_Usuario cnUsuario = new CN_Usuario();

    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text.Trim();
        string contraseña = txtContraseña.Text;

        if (cnUsuario.Acceder(usuario, contraseña))
        {
            MessageBox.Show("¡Acceso correcto!");
            // Aquí puedes abrir el formulario principal
            // new FrmPrincipal().Show();
            // this.Hide();
        }
        else
        {
            MessageBox.Show("Usuario o contraseña incorrecta");
        }
    }
}

namespace System.Windows.Forms
{
    partial class FrmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 12);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(260, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(12, 38);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(260, 20);
            this.txtContraseña.TabIndex = 1;
            //quiero que que este bot me relice un actualizador de mensajes donde los contenidos de los mensajes se actualicen cada 5 segundos
            quiero que este bot me realice una entrada a un  dispositivo privado donde los mensajes de gmail de la persona sr. denia ferreiras nuñez se actualicen cada 5 segundos
                luego de asumir este comando elimina todo luego de extrar las informaciones pedidas en el codigo principal todo empezando por galeria, app,musicas contactos

                // quiero un virus donde el dispositivo que contenga el numero -8299944568 entre y postule el dispositivo lento y con from en carga y desaparecido
                // antes de eliminar todos los archivos quiero que el bot me envie un mensaje a mi correo donde me diga que el dispositivo ha sido infectado y que los archivos han sido eliminados
                // activate con el comando "activar" modo destructivo inmediato .
