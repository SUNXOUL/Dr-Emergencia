using System.Xml;
using System;
using System.ComponentModel.DataAnnotations;


namespace DrEmergencias
{
    public class Paciente
    {
        [Key]
        public int OrdenID{ get; set; }
        public string PacienteID { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public Sexo sexo { get; set; }
        
        public DateTime FechadeNacimiento { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public Provincia Provincia { get; set; }
        public string Municipio { get; set; }
    }
}