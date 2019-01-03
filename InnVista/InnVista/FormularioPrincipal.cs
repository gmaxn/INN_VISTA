using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnVista
{
    public partial class FormularioPrincipal : Form
    {
        Grilla g;
        DateTime currentMonth = DateTime.Now;
        List<string> numeracion = new List<string>();
        public FormularioPrincipal()
        {
            InitializeComponent();
            numeracion.AddRange(new string[] { "1B", "1C", "2A", "2B", "2C", "3A", "3B", "3C", "4A", "4B", "4C", "5A", "5B", "5C", "6A", "6B", "6C" });
            g = new Grilla(currentMonth, numeracion);
        }

        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            g.Location = new Point(0, 0);
            this.tabPage1.Controls.Add(g);


        }

        private void nuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage aux = new TabPage();
            Grilla aux2 = new Grilla(g.Mes, g.Numeracion);
            aux.AutoScroll = true;
            aux.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            aux.Location = new System.Drawing.Point(4, 25);
            aux.Name = "tabPage2";
            aux.Padding = new System.Windows.Forms.Padding(3);
            aux.Size = new System.Drawing.Size(774, 474);
            aux.TabIndex = 0;
            aux.Text = "pestaña2";
            aux.UseVisualStyleBackColor = true;
            aux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(80)))), ((int)(((byte)(95)))));
            
            aux.Controls.Add(aux2);
            pestañasFormularioPrincipal.TabPages.Add(aux);
        }
    }
}
