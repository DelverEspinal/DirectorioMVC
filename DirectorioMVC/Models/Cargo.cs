namespace DirectorioMVC.Models
{
    public class Cargo
    {

        private int numeroCargo { get; set; }

        private string titulo { get; set; }

        private DateTime fechaInicio { get; set; }

        private DateTime fechaFinal { get; set; }

        private bool empleoActual { get; set; }

        private string empresa { get; set; }

        private decimal salario { get; set; }

        private string detalles { get; set; }


        //Constructor vacio
        public Cargo()
        {

        }

        //Constructor que permite completar todas las variables internas
        public Cargo(int numeroCargo, string titulo, DateTime fechaInicio, DateTime fechaFinal,
                     bool empleoActual, string empresa, decimal salario, string detalles)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.empleoActual = empleoActual;
            this.empresa = empresa;
            this.salario = salario;
            this.detalles = detalles;
        }

        public Cargo(int numeroCargo, string titulo, string empresa, decimal salario)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.empresa = empresa;
            this.salario = salario;
        }


        public int getNumeroCargo()
        {
            return numeroCargo;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public string getEmpresa()
        {
            return empresa;
        }

        public decimal getSalario()
        {
            return salario;
        }
    }
}

