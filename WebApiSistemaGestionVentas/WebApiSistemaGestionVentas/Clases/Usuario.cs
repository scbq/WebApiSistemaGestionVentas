namespace WebApiSistemaGestionVentas.Clases
{
    public class Usuario
    {
        //Atributos
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        //Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        //Constructores
        public Usuario()
        {
            this.id = 0;
            this.nombre = "";
            this.apellido = "";
            this.nombreUsuario = "";
            this.contraseña = "";
            this.mail = "";
        }
        public Usuario(int id, string nombre, string apellido, string nombreUsusario, string contraseña, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsusario;
            this.contraseña = contraseña;
            this.mail = mail;
        }

        public Usuario(string usuario)
        {
            string[] campo;
            campo = usuario.Split(',');
            int.TryParse(campo[0], out this.id);
            campo[1] = this.nombre;
            campo[2] = this.apellido;
            campo[3] = this.nombreUsuario;
            campo[4] = this.contraseña;
            campo[5] = this.mail;
        }
        public Usuario(Usuario u)
        {
            this.id = u.id;
            this.nombre = u.nombre;
            this.apellido = u.apellido;
            this.nombreUsuario = u.nombreUsuario;
            this.contraseña = u.contraseña;
            mail = u.mail;
        }
    }
}
