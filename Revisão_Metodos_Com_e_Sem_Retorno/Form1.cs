using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisão_Metodos_Com_e_Sem_Retorno
{
    public partial class FormAppook : Form
    {
        public FormAppook()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            Metedos MetOb = new Metedos();

            MetOb.user = textBoxUser.Text;
            MetOb.password = Convert.ToInt16(textBoxSenha);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
