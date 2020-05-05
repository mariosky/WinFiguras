using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFigura
{
    abstract class Figura
    {
        protected Pen pluma;
        private Color _color;
        public Color color
        {
            get => _color;
            set
            {
                _color = value;
                brocha.Color = value;

            }
        }
        
        protected SolidBrush brocha;
        protected int x, y;
        protected int ancho, alto;




        public Figura(int x, int y, int ancho, int alto)
        {
            this.x = x;
            this.y = y;
            this.ancho = ancho;
            this.alto = alto;
            _color = Color.Black;
            pluma = new Pen(Color.Black);
            brocha = new SolidBrush(_color);

        }

        abstract public void Dibuja(Form forma);
        public bool EstaContenido(int a, int b)
        {
            return (a >= x && a <= x + ancho) && (b >= y &&  b <= y + alto); 
        }



    }
    class Rectangulo:Figura
    {


        public Rectangulo(int x, int y, int ancho, int alto):base(x,y,ancho,alto)
        {
            
        }

        public override void Dibuja(Form forma )
        {
            Graphics graphics = forma.CreateGraphics();
            // Pen, Brush, Color
            
            graphics.FillRectangle(brocha, x, y, ancho, alto);
            graphics.DrawRectangle(pluma, x, y, ancho, alto);

        }
    }
    class Elipse : Figura
    {

        public Elipse(int x, int y, int ancho, int alto) : base(x, y, ancho, alto)
        {

        }

        public override void Dibuja(Form forma)
        {
            Graphics graphics = forma.CreateGraphics();
            // Pen, Brush, Color
            graphics.FillEllipse(brocha, x, y, ancho, alto);
            graphics.DrawEllipse(pluma, x, y, ancho, alto);

        }
    }
    


}
