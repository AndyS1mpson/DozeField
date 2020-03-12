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
    public partial class PointAffiliation : Form
    {
        Bitmap bmp;
        Graphics g;
        private List<(double x, double y)> _vertices;
        private (double, double) point;
        public PointAffiliation()
        {
            InitializeComponent();
            bmp = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(bmp);
            _vertices = new List<(double, double)>();
        }

        private void PointAffiliation_Load(object sender, EventArgs e)
        {

        }

        private void FieldCoordinates_Click(object sender, EventArgs e)
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

        private void PointCoordinates_Click(object sender, EventArgs e)
        {
            double x = Double.Parse(pointX.Text);
            double y = Double.Parse(pointY.Text);

            DrawPoint(x,y);
            point = (x, y);
            pointX.Clear();
            pointY.Clear();
        }

        public void DrawPoint(double x,double y)
        {
            Bitmap bitmap = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bitmap);

            g.FillRectangle(Brushes.Red, (float)x, (float)y, 4, 4);
            picture.Image = bitmap;
        }

        private void DrawPolygon()
        {
            Bitmap bmp = new Bitmap(picture.Width, picture.Height);
            Graphics g = Graphics.FromImage(bmp);

            PointF[] field = new PointF[_vertices.Count];
            for (int i = 0; i < _vertices.Count; i++)
            {
                field[i] = new PointF((float)_vertices[i].x, (float)_vertices[i].y);
            }
            g.DrawPolygon(new Pen(Color.Black), field);
            this.picture.BackgroundImage = bmp;
        }

        private void PointInField_Click(object sender, EventArgs e)
        {
            bool result = point.IsPointInField(_vertices.ConvertFromListTo());
            label5.Text = result.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
