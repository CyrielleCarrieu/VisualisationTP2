using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDataVis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

                                        // TODO : faire la variation de z + zoom souris avec la molette + drag and drop

        Dictionary<int, List<Record>> dic = new Dictionary<int, List<Record>>();
        Record min = new Record();
        Record max = new Record();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Read file
            string fileName = "trajectories.txt";

            StreamReader sr = new StreamReader(fileName);
            string line = sr.ReadLine(); //read the field names
            line = sr.ReadLine();

            #region Recupération des données
            while (line != null)
            {

                string[] r = line.Split(new char[] { ';' });

                // #ID;time;x;y;z;name;ID
                int index = 0;

                Record rec = new Record();

                rec.id = int.Parse(r[index++]);
                rec.time = r[index++];
                rec.x = double.Parse(r[index++], CultureInfo.InvariantCulture);
                rec.y = double.Parse(r[index++], CultureInfo.InvariantCulture);
                rec.z = double.Parse(r[index++], CultureInfo.InvariantCulture);
                rec.name = r[index++];
                rec.id1 = int.Parse(r[index++]);

                if (!dic.Keys.Contains(rec.id))
                {
                    dic.Add(rec.id, new List<Record>());
                }
                dic[rec.id].Add(rec);

                //Read next Line
                line = sr.ReadLine();

            }
            #endregion

            #region Normalisation Faire pour times
            //data_normalization
            //Ajouter le temps
            min.x = double.MaxValue;
            min.y = double.MaxValue;
            min.z = double.MaxValue;
            // Ajouter le temps
            max.x = double.MinValue;
            max.y = double.MinValue;
            max.z = double.MinValue;

            foreach (var traj in dic)
            {
                foreach (var rec in traj.Value)
                {
                    if (rec.x < min.x)
                    {
                        min.x = rec.x;
                    }
                    if (rec.y < min.y)
                    {
                        min.y = rec.y;
                    }
                    if (rec.z < min.z)
                    {
                        min.z = rec.z;
                    }

                    if (rec.x > max.x)
                    {
                        max.x = rec.x;
                    }
                    if (rec.y > max.y)
                    {
                        max.y = rec.y;
                    }
                    if (rec.z > max.z)
                    {
                        max.z = rec.z;
                    }
                }
            }

            #endregion
        }


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;
            Color minColor = pictureBoxMinColor.BackColor;
            Color maxColor = pictureBoxMaxColor.BackColor;

            if (dic != null)
            {
                //Show points
                foreach (var traj in dic)
                {
                    
                    Boolean isFirstRecord = true;
                    Record rec0 = new Record();
                    foreach (var rec in traj.Value)
                    {
                        SolidBrush p = new SolidBrush(Color.FromArgb(alpha, 
                            (int)GenericScaleDouble(rec.z, min.z, minColor.R, max.z, maxColor.R),
                            (int)GenericScaleDouble(rec.z, min.z, minColor.G, max.z, maxColor.G),
                            (int)GenericScaleDouble(rec.z, min.z, minColor.B, max.z, maxColor.B)));

                        if (!isFirstRecord)
                        {

                            float p0_x = zoom * (pan.X + (float)GenericScaleDouble(rec0.x, min.x, 0, max.x, w));
                            float p0_y = zoom * (pan.Y + (float)GenericScaleDouble(rec0.y, min.y, h, max.y, 0));
                            float p1_x = zoom * (pan.X + (float)GenericScaleDouble(rec.x, min.x, 0, max.x, w));
                            float p1_y = zoom * (pan.Y + (float)GenericScaleDouble(rec.y, min.y, h, max.y, 0));
                            g.DrawLine(new Pen(p), p0_x, p0_y, p1_x, p1_y);
                        }
                        rec0 = rec;
                        isFirstRecord = false;

                        /*  Affichage de points
                         * g.FillEllipse(tb,pan.X+(float)GenericScaleDouble((float)rec.x, min.x, 0, max.x, w),
                                     pan.Y+(float)GenericScaleDouble((float)rec.y, min.y, h, max.y, 0), 2, 2);
                         */
                    }
                }
            }
        }

        public static double GenericScaleDouble(double input, double i1, double o1, double i2, double o2)
        {
            if (i2 == i1)
                return o1;
            double a = (o2 - o1) / (i2 - i1);
            double b = o1 - a * i1;
            return (a * input + b);

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)numericUpDown1.Value;
            recordInfos.Text = dic[index][0].ToString() + "(" + dic[index].Count.ToString() + ")";
        }

        int alpha = 50;
        private void trackBarAlpha_Scroll(object sender, EventArgs e)
        {
            alpha = trackBarAlpha.Value;
            pictureBox1.Invalidate();
        }
        int red;
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            red = trackBar1.Value;
            pictureBox1.Invalidate();
        }

        
        private void pictureBoxMinColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMinColor.BackColor = colorDialog1.Color;
                pictureBox1.BackColor = colorDialog1.Color;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBoxMaxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxMaxColor.BackColor = colorDialog1.Color;
                pictureBox1.BackColor = colorDialog1.Color;
                pictureBox1.Invalidate();
            }
        }

        Point pan;
        Point mouseDown;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Move
                pan = new Point(e.Location.X, e.Location.Y);
                pictureBox1.Invalidate();
            }

        }

        float zoom = 1f;
        private void pictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            //pan = new Point(e.X, e.Y);
            if (e.Delta > 0)
            {
                zoom += 0.1f;
            }
            else
            {
                zoom -= 0.1f;
            }

            pictureBox1.Invalidate();
        }
    }
}
