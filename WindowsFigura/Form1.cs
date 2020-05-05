using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFigura
{

    enum EstadoActual { selccionando, rectangulo, elipse}
    
    public partial class Form1 : Form
    {
        List<Figura> figuras;
        EstadoActual estado = EstadoActual.selccionando;
        bool dibujando = false;
        int temp_x, temp_y;

        public Form1()
        {
            InitializeComponent();
            figuras = new List<Figura>();
        }

        Figura GetFigura(int x, int y)
        {
            foreach(Figura f in figuras)
                {
                  if( f.EstaContenido(x,y) )
                    {
                    return f;
                    }
                }   

            return null;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // this.label1.Text = String.Format("{0},{1}",e.X, e.Y);

            if (e.Button == MouseButtons.Left && this.estado == EstadoActual.selccionando)
            {
                Figura seleccionada = null;

                seleccionada = GetFigura(e.X, e.Y);

                

                if (seleccionada != null)
                {
                    MessageBox.Show(seleccionada.color.ToString());
                    seleccionada.color = Color.Blue;
                }

            }
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figura f in figuras)
                f.Dibuja(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seleccion_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.selccionando;
        }

        private void elipse_Click(object sender, EventArgs e)
        {
            estado = EstadoActual.elipse;
        }

        private void rectangulo_Click(object sender, EventArgs e)
        {

            estado = EstadoActual.rectangulo;


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (estado == EstadoActual.rectangulo && dibujando == true)
            {
                Rectangulo r = new Rectangulo(temp_x, temp_y, e.X - temp_x , e.Y - temp_y);
                figuras.Add(r);
                r.Dibuja(this);
                dibujando = false;

            } else 
            if (estado == EstadoActual.elipse && dibujando == true)
            {
                Elipse elipse = new Elipse(temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
                figuras.Add(elipse);
                elipse.Dibuja(this);
                dibujando = false;

            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
           /*
            if (estado == EstadoActual.rectangulo && dibujando == true)
            {
                Graphics graphics = CreateGraphics();
                graphics.DrawRectangle(new Pen(Color.Black), temp_x, temp_y, e.X - temp_x, e.Y - temp_y);
         
            }

            */

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((estado == EstadoActual.rectangulo || estado == EstadoActual.elipse) && dibujando == false )
            {
                dibujando = true;
                temp_x = e.X;
                temp_y = e.Y;
            }

        }
    }
}
