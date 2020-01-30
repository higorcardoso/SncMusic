using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SncMusic
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)  // aluno novo
        {
            FrmAluno frmaluno = new FrmAluno();
            frmaluno.MdiParent = this;
            frmaluno.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)  //professor novo
        {
            FrmProfessor frmprofessor = new FrmProfessor();
            frmprofessor.MdiParent = this;
            frmprofessor.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e) // curso novo
        {
            FrmCurso frmCurso = new FrmCurso();
            frmCurso.MdiParent = this;
            frmCurso.Show();
        }
  
        private void novoToolStripMenuItem3_Click(object sender, EventArgs e) // usuário novo
        {
            FrmUsuario frmusuario = new FrmUsuario();
            frmusuario.MdiParent = this;
            frmusuario.Show();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
