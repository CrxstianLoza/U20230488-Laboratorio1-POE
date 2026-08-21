using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u20230488
{
    public partial class FrmFichaEmpleado : Form
    {

        // Nombre: Cristian Francisco Loza Machuca
        // Autoevaluación: 10/10

        public FrmFichaEmpleado()
        {
            InitializeComponent();
        }

        private void FrmFichaEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbiGeneroMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se pueden ingresar letras.",
                    "Entrada no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se pueden ingresar letras.",
                    "Entrada no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se pueden ingresar letras.",
                    "Entrada no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se pueden ingresar números.",
                    "Entrada no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void txtDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se pueden ingresar números.",
                    "Entrada no válida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (txtDUI.Text.Length == 8)
            {
                txtDUI.Text += "-" + e.KeyChar;
                txtDUI.SelectionStart = txtDUI.Text.Length;
                e.Handled = true;
            }
        }
        private void txtDUI_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Nombre: " + txtNombre.Text +
                "\nApellido: " + txtApellido.Text +
                "\nFecha de Ingreso: " + dtpFechaIngreso.Value.ToShortDateString() +
                "\nCargo: " + txtCargo.Text,
                "Ficha de Empleado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}

