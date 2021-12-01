using AppCore.Interfeces;
using AppCore.Services;
using Infraestructura.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen.Forms
{
    public partial class ViewForm : Form
    {
        public INota nota;
        List<int> borar = new List<int>();
        public ViewForm(INota n)
        {
            InitializeComponent();
        }

        private void New_Click(object sender, EventArgs e)
        {
            newForm newform = new newForm(nota);
            newform.ShowDialog();
            dgvView.DataSource = borar;
            dgvView.DataSource= nota.FindAll();
        }
    }
}
