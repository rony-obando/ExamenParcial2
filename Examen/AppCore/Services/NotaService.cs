using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCore.Interfeces;
using Domain.Entities;
using Domain.Interfaces;

namespace AppCore.Services
{
    public class NotaService:INota
    {
        private INotaModel NotaModel;

        public void Add(Nota n)
        {
            NotaModel.Add(n);
        }

        public List<Nota> FindAll()
        {
            return NotaModel.FindAll();
        }
    }
}
