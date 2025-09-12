namespace DirectorioMVC.Models
{
    public class Grado
    {

        private int numeroGrado { get; set; }
        private string nivelEducativo { get; set; }
        private string institucion { get; set; }
        private string nombreTitulo { get; set; }
        private DateTime fechaInicio { get; set; }
        private DateTime fechaFinal { get; set; }
        private string tipoGrado { get; set; }
        private DateTime fechaExpiracion { get; set; }
        private string pais { get; set; }

        //Constructor vacio
        public Grado() { }

        // Constructor que permite completar todas las variables internas
        public Grado(int numeroGrado, string nivelEducativo, string institucion, string nombreTitulo,
                     DateTime fechaInicio, DateTime fechaFinal, string tipoGrado, DateTime fechaExpiracion, string pais)
        {
            this.numeroGrado = numeroGrado;
            this.nivelEducativo = nivelEducativo;
            this.institucion = institucion;
            this.nombreTitulo = nombreTitulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.tipoGrado = tipoGrado;
            this.fechaExpiracion = fechaExpiracion;
            this.pais = pais;
        }

        public Grado(int numeroGrado, string nivelEducativo, string institucion, string nombreTitulo)
        {
            this.numeroGrado = numeroGrado;
            this.nivelEducativo = nivelEducativo;
            this.institucion = institucion;
            this.nombreTitulo = nombreTitulo;
        }

        public int getnumeroGrado()
        {
            return numeroGrado;
        }

        public string getnivelEducativo()
        {
            return nivelEducativo;
        }

        public string getInstitucion()
        {
            return institucion;
        }

        public string getnombreTitulo()
        {
            return nombreTitulo;
        }
    }
}
