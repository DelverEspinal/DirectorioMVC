namespace DirectorioMVC.Models
{
    public class Persona
    {
        private string numeroId { get; set; }
        private string nombres { get; set; }
        private string apellidos { get; set; }
        private DateTime fechaNacimiento { get; set; }
        private string telefono { get; set; }
        private string celular { get; set; }
        private string email { get; set; }
        private string ciudad { get; set; }
        private string direccion { get; set; }
        private string profesion { get; set; }

       

        //Constructor vacio
        public Persona()
        {

        }

        // Constructor que permite completar todas las variables internas
        public Persona(string numeroId, string nombres, string apellidos, DateTime fechaNacimiento,
                       string telefono, string celular, string email, string ciudad,
                       string direccion, string profesion)
        {
            this.numeroId = numeroId;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechaNacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.celular = celular;
            this.email = email;
            this.ciudad = ciudad;
            this.direccion = direccion;
            this.profesion = profesion;

        }

        public Persona(string nombres, string apellidos)
        {
            this.nombres = nombres;
            this.apellidos = apellidos;

        }

        public void setNombres(string p_nombres)
        {
            this.nombres = p_nombres;
        }

        public string getNombres()
        {
            return this.nombres;
        }


        public void setApellidos(string p_apellidos)
        {
            this.apellidos = p_apellidos;
        }

        public string getApellidos()
        {
            return this.apellidos;
        }


        public string getNombreCompleto()
        {
            return this.nombres + " " + this.apellidos;
        }
    }
}
