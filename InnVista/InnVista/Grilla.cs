using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnVista
{
    public partial class Grilla : UserControl
    {
        private List<Label> labels;
        private List<string> numeracion;
        private DateTime mes;

        public List<string> Numeracion
        {
            get { return this.numeracion; }
        }
        public DateTime Mes
        {
            get { return this.mes; }
        }
        public Grilla(DateTime mes, List<string> numeracion)
        {
            InitializeComponent();
            this.labels = new List<Label>();
            this.mes = mes;
            this.numeracion = numeracion;
        }
        private void Grilla_Load(object sender, EventArgs e)
        {
            GenerarGrilla(this.mes, this.numeracion);
        }
        public void GenerarGrilla(DateTime mes, List<string> numeracion)
        {
            int[] cantDiasMeses = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (DateTime.IsLeapYear(mes.Year))
                cantDiasMeses[1] = 29;
            
            int filas = cantDiasMeses[mes.Month - 1];
            Label lblAuxiliar;

            int x = 0;
            int y = 0;
            int p = 0;

            // 1. Generar tamaño del control
            this.Size = new System.Drawing.Size(5 + 100 + (50 * numeracion.Count) + 5, 5+(25*filas)+5);
            // 2. Agregar Celdas

            for (int i = 0; i < filas; i++)
            {
               
                for (int j = 0; j <= numeracion.Count; j++)
                {
                    lblAuxiliar = new Label();
                    lblAuxiliar.AutoSize = false;
                    lblAuxiliar.BorderStyle = BorderStyle.None;
                    lblAuxiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(63)))), ((int)(((byte)(79)))));
                    lblAuxiliar.ForeColor = System.Drawing.Color.White;
                    lblAuxiliar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblAuxiliar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    if (i == 0 && j == 0)
                    {
                        lblAuxiliar.Location = new System.Drawing.Point(5, 5);
                        lblAuxiliar.Name = string.Format("lbl_{0}{1}", i, j);
                        lblAuxiliar.Size = new System.Drawing.Size(100, 25);
                        lblAuxiliar.TabIndex = 0;
                        lblAuxiliar.Text = "FECHA";
                        x = 105;
                        y = 5;
                    }
                        
                    if (i == 0 && j > 0)
                    {
                        lblAuxiliar.Location = new System.Drawing.Point(x, y);
                        lblAuxiliar.Name = string.Format("lbl_{0}{1}", i, j);
                        lblAuxiliar.Size = new System.Drawing.Size(50, 25);
                        lblAuxiliar.TabIndex = 0;
                        lblAuxiliar.Text = numeracion[p];
                        x += 50;
                        p++;

                    }
                    if (i > 0 && j == 0)
                    {
                        lblAuxiliar.Location = new System.Drawing.Point(x, y);
                        lblAuxiliar.Name = string.Format("lblFecha_{0}", i);
                        lblAuxiliar.Size = new System.Drawing.Size(100, 25);
                        lblAuxiliar.TabIndex = 0;
                        lblAuxiliar.Text = new DateTime(mes.Year, mes.Month, i).ToString("d-MMM");
                        lblAuxiliar.BorderStyle = BorderStyle.FixedSingle;

                        x += 100;
                    }
                    if(i>0&&j>0)
                    {
                        lblAuxiliar.Location = new System.Drawing.Point(x, y);
                        lblAuxiliar.Name = string.Format("lbl_{0}{1}", i, j);
                        lblAuxiliar.Size = new System.Drawing.Size(50, 25);
                        lblAuxiliar.TabIndex = 0;
                        lblAuxiliar.Text = "";
                        lblAuxiliar.BorderStyle = BorderStyle.FixedSingle;

                        x += 50;
                    }
                    this.labels.Add(lblAuxiliar);
                    this.Controls.Add(lblAuxiliar);

                }
                x = 5;
                y += 25;
            }
        }

    }
}
