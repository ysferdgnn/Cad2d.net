using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> p1 = new List<Point>();
        List<Point> p2 = new List<Point>();
        List<Color> colors = new List<Color>();
        List<float> widths = new List<float>();
        bool enableSnap = false;
        Point newp1, newp2;
        int gridsize;
        bool isDrawing = false,isOrtho=false;
        float drawWidth=5;
        Color DrawColor;
        Pen pen;
        bool keyListening;
        string distancetxt="0";
        ColorDialog Renk;
        int snapdistance = 0;
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            newp1 = new Point(e.X,e.Y);
            newp2 = new Point(e.X,e.Y);
            
            newp1=checkSnapDistances(newp1,snapdistance);
            
           

        }
        public Point checkSnapDistances(Point snappoint,float snapdistance)
        {
            if (enableSnap)
            {
                foreach (Point item in p1)
                {
                    if (Math.Sqrt(Math.Pow(snappoint.X - item.X, 2) + Math.Pow(snappoint.Y - item.Y, 2)) < snapdistance)
                    {
                        snappoint = item;
                    }
                }
                foreach (Point item in p2)
                {
                    if (Math.Sqrt(Math.Pow(snappoint.X - item.X, 2) + Math.Pow(snappoint.Y - item.Y, 2)) < snapdistance)
                    {
                        snappoint = item;
                    }
                }
            }
            return snappoint;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X+" : "+e.Y;
            if (keyListening)
            {
                newp2 = checkOrtho(newp1, e);
                newp2 = LineLenght(Int32.Parse(distancetxt));
            }
            else if(!keyListening)
            {
                newp2 = checkOrtho(newp1,e);
            }
            pictureBox1.Invalidate();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            Renk.ShowDialog();
            DrawColor = Renk.Color;
           pen= new Pen(DrawColor, drawWidth);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
            newp2 = checkSnapDistances(newp2,snapdistance);
            if (düzÇizgiToolStripMenuItem.Checked&&isDrawing)
            {
                p1.Add(newp1);
                p2.Add(newp2);
                colors.Add(DrawColor);
                widths.Add(drawWidth);
            }
            isDrawing = false;
            distancetxt = "0";
            keyListening = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridsize = 10;
            Renk = colorDialog1;
            snapdistance = 10;
            DrawColor = Color.Black;
            drawWidth = 2;
            pen = new Pen(Color.Black,drawWidth);
            yakalamaNoktalarınıGösterToolStripMenuItem.Checked = false;
            düzÇizgiToolStripMenuItem.Checked = false;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           // drawWidth = float.Parse(toolStripTextBox1.Text);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                drawWidth = float.Parse(toolStripTextBox1.Text);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawGrid(gridsize, e);
            for (int i = 0; i < p1.Count; i++)
            {
                pen = new Pen(colors[i],widths[i]);
                e.Graphics.DrawLine(pen,p1[i],p2[i]);
                
                if (yakalamaNoktalarınıGösterToolStripMenuItem.Checked==true)
                {
                    drawSnappoints(Convert.ToInt32(drawWidth), e);
                }
            }
            if (isDrawing)
            {
                if (düzÇizgiToolStripMenuItem.Checked)
                {
                    e.Graphics.DrawLine(new Pen(Color.Red, pen.Width), newp1, newp2);
                }  
            }
        }

        private void yakalamaNoktalarınıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (yakalamaNoktalarınıGösterToolStripMenuItem.Checked==true)
            {
                yakalamaNoktalarınıGösterToolStripMenuItem.Checked = false;
            }
            else
            {
                yakalamaNoktalarınıGösterToolStripMenuItem.Checked = true;
            }

        }

        private void düzÇizgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (düzÇizgiToolStripMenuItem.Checked==false)
            {
                düzÇizgiToolStripMenuItem.Checked = true;
            }
            else
            {
                düzÇizgiToolStripMenuItem.Checked = false;
            }
        }

        private void kenarYakalamayıAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kenarYakalamayıAçToolStripMenuItem.Checked)
            {
                kenarYakalamayıAçToolStripMenuItem.Checked = false;
                enableSnap = false;
            }
            else
            {
                enableSnap = true;
                kenarYakalamayıAçToolStripMenuItem.Checked = true;
            }
        }

        private void orthoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orthoToolStripMenuItem.Checked)
            {
                isOrtho = false;
                orthoToolStripMenuItem.Checked = false;
            }
            else
            {
                isOrtho = true;
                orthoToolStripMenuItem.Checked = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.O)
            {
                if (isOrtho)
                {
                    isOrtho = false;
                }
                else
                {
                    isOrtho = true;
                }
            }
            else if (e.KeyCode==Keys.ControlKey)
            {
                if (isDrawing)
                {
                    isDrawing = false;
                }
                else
                {
                    if (p1.Count!=0&&p2.Count!=0)
                    {
                        p1.RemoveAt(p1.Count-1);
                        p2.RemoveAt(p2.Count-1);
                    }
                }
            }
            else if(e.KeyCode==Keys.Enter)
            {

                if (isDrawing)
                {
                    if (keyListening)
                    {
                        keyListening = false;
                    }
                    else
                        keyListening = true;
                }
                
            }
            else if (e.KeyCode==Keys.NumPad1)
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "1";
                }
                
            }
            else if (e.KeyCode == Keys.NumPad2 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "2";
                }
            }
            else if (e.KeyCode == Keys.NumPad3 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "3";
                }
            }
            else if (e.KeyCode == Keys.NumPad4 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "4";
                }
            }
            else if (e.KeyCode == Keys.NumPad5 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "5";
                }
            }
            else if (e.KeyCode == Keys.NumPad6 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "6";
                }
            }
            else if (e.KeyCode == Keys.NumPad7 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "7";
                }
            }
            else if (e.KeyCode == Keys.NumPad8 )
            {
                if(keyListening)
                {
                    distancetxt = distancetxt + "8";
                }
            }
            else if (e.KeyCode == Keys.NumPad9 )
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "9";
                }
            }
            else if (e.KeyCode==Keys.NumPad0)
            {
                if (keyListening)
                {
                    distancetxt = distancetxt + "0";
                }
            }

        }

        private void çizimKalınlığıToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = distancetxt;
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox2.Text!="")
            {
                snapdistance = Convert.ToInt32(toolStripTextBox2.Text);
            }
            
        }

        public void drawSnappoints(int squaresize,PaintEventArgs e)
        {
            
            foreach (Point item in p1)
            {
               int squareX = item.X - squaresize;
                int squareY = item.Y - squaresize;
                int squareWidth = squaresize * 3;
                int sqareHeight = squaresize * 3;
                Rectangle rect = new Rectangle(squareX,squareY,squareWidth,sqareHeight);
               
                e.Graphics.DrawRectangle(new Pen(Color.Green), rect);
            }
            foreach (Point item in p2)
            {
                int squareX = item.X - squaresize;
                int squareY = item.Y - squaresize;
                int squareWidth = squaresize * 3;
                int sqareHeight = squaresize * 3;
                Rectangle rect = new Rectangle(squareX, squareY, squareWidth, sqareHeight);

                e.Graphics.DrawRectangle(new Pen(Color.Green), rect);
            }
            
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            pictureBox1.DrawToBitmap(bmp,pictureBox1.ClientRectangle);
            bmp.Save("draw.png");
        }

        public Point checkOrtho(Point p1,MouseEventArgs e)
        {
            Point tmppoint = p1;
            if (isOrtho)
            {
                //if (Math.Abs(p1.Y - e.Y) < 20)
                //{
                //    tmppoint = new Point(e.X, p1.Y);
                //}
                if (Math.Asin(Math.Sqrt(Math.Pow(e.Y-p1.Y,2))/Math.Sqrt(Math.Pow(e.X-p1.X,2)+Math.Pow(e.Y-p1.Y,2)))<0.5)
                {
                    tmppoint = new Point(e.X, p1.Y);
                    label2.Text = Math.Asin(Math.Sqrt(Math.Pow(e.Y - p1.Y, 2)) / Math.Sqrt(Math.Pow(e.X - p1.X, 2) + Math.Pow(e.Y - p1.Y, 2))).ToString();
                }
                else if (Math.Asin(Math.Sqrt(Math.Pow(e.Y - p1.Y, 2)) / Math.Sqrt(Math.Pow(e.X - p1.X, 2) + Math.Pow(e.Y - p1.Y, 2))) >0.5)
                {
                    tmppoint = new Point(p1.X, e.Y);
                }

            }
            else if (!isOrtho)
            {
                tmppoint = e.Location;
            }
            return tmppoint;

        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBox3.Text=="")
            {
                gridsize = 20;
            }
            else 
            {
                gridsize = Int32.Parse(toolStripTextBox3.Text);
            }
            
        }

        public Point LineLenght(int uzunluk)
        {
            int x1 = newp1.X;
            int y1 = newp1.Y;
            int x2 = 0;
            int y2 = 0;
            double distance = 999999999;
            List<Point> points = new List<Point>();
            //if (Math.Sqrt(Math.Pow(x1-newp2.X,2)+Math.Pow(y1-newp2.Y,2))==uzunluk)
            //{
            //    x2 = newp2.X;
            //    y2 = newp2.Y;
            //}
            
                for (int i = newp1.X-uzunluk; i <newp1.X+uzunluk; i++)
                {
                    for (int j = newp1.Y-uzunluk; j < newp1.Y+uzunluk; j++)
                    {
                        if (Math.Abs(Math.Sqrt(Math.Pow(i - x1, 2) + Math.Pow(j - y1, 2))-uzunluk)<2)
                        {
                            points.Add(new Point(i,j));
                        }
                    }
                }
                foreach (Point item in points)
                {
                    if (Math.Sqrt(Math.Pow(item.X-newp2.X,2)+Math.Pow(item.Y-newp2.Y,2))<distance)
                    {
                    distance = (Math.Sqrt(Math.Pow(item.X - newp2.X, 2) + Math.Pow(item.Y - newp2.Y, 2)));
                        x2 = item.X;
                        y2 = item.Y;
                    }
                }
            
            Point tmpPoint = new Point(x2,y2);
            points.Clear();
            return tmpPoint;

        }
        public void DrawGrid(int size,PaintEventArgs e)
        {
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                if (i%size==0)
                {
                    Pen tp = new Pen(Brushes.Gray);
                    e.Graphics.DrawLine(tp, new Point(i, 0), new Point(i,pictureBox1.Height));
                }
            }
            for (int i = 0; i < pictureBox1.Height; i++)
            {
                if (i%size==0)
                {
                    Pen tp = new Pen(Brushes.Gray);
                    e.Graphics.DrawLine(tp, new Point(0, i), new Point(pictureBox1.Width, i));
                }
            }
        }
    }
}
