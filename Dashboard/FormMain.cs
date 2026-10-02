using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class FormMain : Form
    {
        private FormNotas ventanaNotas = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Evento de carga del formulario
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if (ventanaNotas == null || ventanaNotas.IsDisposed)
            {
                ventanaNotas = new FormNotas();
                ventanaNotas.Show(this);
            }
            else
            {
                ventanaNotas.Focus();
                ventanaNotas.BringToFront();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
