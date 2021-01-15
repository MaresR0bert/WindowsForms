using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Agenda
{
    public partial class AgendaActiv : Form
    {
        public AgendaActiv()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreare_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreareAgenda creareAgenda = new CreareAgenda();
            creareAgenda.ShowDialog();
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeschide_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreareAgenda creareAgenda = new CreareAgenda(sender, e);
            creareAgenda.ShowDialog();
            this.Close();
        }
    }
}
