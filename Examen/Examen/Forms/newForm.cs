using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCore.Interfeces;
using AppCore.Services;
using Domain.Entities;
using Infraestructura.Models;

namespace Examen.Forms
{
    public partial class newForm : Form
    {
        public INota nota;
        public newForm(INota n)
        {
            nota = n;
            InitializeComponent();
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        

        private void NewEstudiante_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante()
            {
                Nombres = NombEstud.Text,
                Apellidos = apellidos.Text,
                Id = (int)IdEstudi.Value,
                Carnet=Carnet.Text,
                Municipio=Municipio.Text,
                Departamento=Departamentos.Text
            };
            Asignatura a = new Asignatura()
            {
                Id = (int)IdAsig.Value,
                Nombres = NomAsig.Text,
                Creditos = (int)Creditos.Value
            };
            int suma = (int)PrimParcial.Value + (int)SegParcial.Value + (int)Sistem.Value;
            Nota n = new Nota()
            {
                estudiante=est,
                asignatura=a,
                Sistematicos= (int)Sistem.Value,
                Parcial1= (int)PrimParcial.Value,
                Parcial2= (int)SegParcial.Value,
                NotaFinal=suma,
            };
            nota.Add(n);
            Close();
        }

        private void NewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
