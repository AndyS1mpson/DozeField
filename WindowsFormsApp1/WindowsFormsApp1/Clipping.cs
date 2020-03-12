using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Clipping : Form
    {
        Bitmap bmp;
        private List<(double x,double y)> _vertices;
        private Segment segment;
        public DozeField dozeField;
        public Clipping()
        {
            _vertices = new List<(double, double)>();
            InitializeComponent();
            bmp = new Bitmap(picture.Width, picture.Height);
        }
        private void DrawPolygon()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bmp);

            PointF[] field = new PointF[_vertices.Count];
            for(int i = 0;i<_vertices.Count;i++)
            {
                field[i] = new PointF((float)_vertices[i].x,(float) _vertices[i].y);
            }
            g.DrawPolygon(new Pen(Color.Black),field);
            this.picture.BackgroundImage = bmp;
        }

        public void DrawLine(Segment segment)
        {
            Graphics g = Graphics.FromImage(bmp);
            g.DrawLine(new Pen(Color.Red), new PointF((float)segment.start.x,(float)segment.start.y), new PointF((float)segment.end.x, (float)segment.end.y));
            picture.Image = bmp;


        }
        private void ShowLine_Click(object sender, EventArgs e)
        {
            double xStart = Double.Parse(startX.Text);
            double yStart = Double.Parse(startY.Text);
            double xEnd = Double.Parse(endX.Text);
            double yEnd = Double.Parse(endY.Text);
            segment = new Segment((xStart, yStart), (xEnd, yEnd));
            bmp = new Bitmap(picture.Width, picture.Height);
            picture.Refresh();
            DrawLine(segment);

            startX.Clear();
            startY.Clear();
            endX.Clear();
            endY.Clear();

        }


        private void ShowPolygon_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(verticeX.Text);
            double y = Double.Parse(verticeY.Text);
            _vertices.Add((x, y));
            if (_vertices.Count > 1)
            {
                DrawPolygon();
            }
            
            verticeX.Clear();
            verticeY.Clear();

            
        }

        private void Clip_Click(object sender, EventArgs e)
        {
            _vertices.Add(_vertices[0]);
            dozeField = new DozeField(_vertices.ConvertFromListTo());
            var result = dozeField.Clip(segment.start, segment.end);
            bmp = new Bitmap(picture.Width, picture.Height);
            picture.Refresh();
            foreach (var el in result)
            {
                DrawLine(el);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void Clipping_Load(object sender, EventArgs e)
        {

        }
    }
}
