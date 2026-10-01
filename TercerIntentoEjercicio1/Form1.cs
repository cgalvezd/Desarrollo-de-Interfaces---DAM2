using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TercerIntentoEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // VALORES INICIALES SEGÚN EL ENUNCIADO
            trackBarGastoDiario.Minimum = 10;
            trackBarGastoDiario.Maximum = 200;
            trackBarGastoDiario.Value = 50;

            btnConfirmar.Enabled = false;
            btnConfirmar.Click +=btnConfirmar_Click;

            //CARGA DE OPCIONES DEL COMBOBOX
            cmbTransporte.Items.Clear();
            cmbTransporte.Items.Add("Autobús (50€");
            cmbTransporte.Items.Add("Tren (100€)");
            cmbTransporte.Items.Add("Avión (200€)");
            cmbTransporte.SelectedIndex = 0;

            //SUSCRIPCIÓN DE LOS TRES CONTROLES AL MÉTODO COMÚN
            numericDias.ValueChanged += CalcularTotal_Changed;
            trackBarGastoDiario.Scroll += CalcularTotal_Changed;
            cmbTransporte.SelectedIndexChanged += CalcularTotal_Changed;

            //CÁLCULO INICIAL
            CalcularTotal_Changed(null, null);
        }
        private void CalcularTotal_Changed(object Sender, EventArgs e)
        {
            int dias = (int)numericDias.Value;
            int gastoDiario = trackBarGastoDiario.Value;

            //VALIDACIÓN DE ACTIVACIÓN DEL BOTÓN
            btnConfirmar.Enabled = dias > 0;

            //OBTENER EL COSTE DEL TRANSPORTE SEGÚN LA OPCIÓN SELECCIONADA.
            int costeTransporte = 0;
            switch (cmbTransporte.SelectedIndex)
            {
                case 0:
                    costeTransporte = 50;
                    break;
                case 1:
                    costeTransporte = 100;
                    break;
                case 2:
                    costeTransporte = 200;
                    break;
            }

            int total = (dias * gastoDiario) + costeTransporte;

            //MOSTRAR RESULTADO 
            lblTotal.Text = $"{total}€";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reserva confirmada con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
}
