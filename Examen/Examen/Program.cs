using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen.Forms;
using Autofac;
using Infraestructura.Models;
using Domain.Interfaces;
using AppCore.Services;
using AppCore.Interfeces;

namespace Examen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<NotaModel>().As<INotaModel>();
            builder.RegisterType<NotaService>().As<INota>();
            var container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ViewForm(container.Resolve<INota>()));
        }
    }
}
