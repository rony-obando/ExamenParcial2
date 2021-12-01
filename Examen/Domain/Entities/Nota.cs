using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Entities
{
    public class Nota
    {
        public Estudiante estudiante { get; set; }
        public Asignatura asignatura{ get; set; }
        public int Sistematicos { get; set; }
        public int Parcial1 { get; set; }
        public int Parcial2 { get; set; }
        public int NotaFinal { get; set; }
        public double Promedio { get; set; }
    }
}
