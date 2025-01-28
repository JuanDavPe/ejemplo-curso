using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class wfFormulario : Form
    {
        public wfFormulario()
        {
            InitializeComponent();
        }

        private void wfFormulario_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a c#  ");
        }

        private void wfFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Chau Chau..");
        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("se disparo el efecto click .. cuidado..");
            //this.BackColor = Color.Bisque;
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
        }

        private void wfFormulario_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botton Izquierdo..");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el botton Derecho..");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botton del Medio");

        }

        private void lbLuffy_MouseMove(object sender, MouseEventArgs e)
        {
            lbLuffy.BackColor = Color.Cyan;
            lbLuffy.Cursor = Cursors.Hand;
        }

        private void lbLuffy_MouseLeave(object sender, EventArgs e)
        {
            lbLuffy.BackColor = System.Drawing.SystemColors.Control;
            lbLuffy.Cursor = Cursors.Arrow;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNombre.Text.Length + "caracteres");
        }
    }
}
