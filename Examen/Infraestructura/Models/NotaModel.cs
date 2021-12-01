using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infraestructura.Models
{
    public class NotaModel:INotaModel
    {
        List<Nota> notas = new List<Nota>();
        public void Add(Nota n)
        {
            int suma = 0;
            if (n == null)
            {
                throw new ArgumentException("El objeto esta vacio");
            }
            /*for (int i = 0; i < notas.Count; i++)
            {
                for (int l = 0; l < notas[i].asignatura.Count; i++)
                {
                    suma = n.NotaFinal[l]+suma;
                }
                n.Promedio = suma / n.asignatura.Count;
            }*/
            notas.Add(n);
        }
        public List<Nota> FindAll()
        {
            return notas;
        }
    }
}
