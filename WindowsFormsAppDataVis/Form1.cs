using System;
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
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int index = (int)numericUpDown1.Value;
            recordInfos.Text = dic[index][0].ToString() + "(" + dic[index].Count.ToString() + ")";
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (dic != null)
            {
                //Show points
                foreach (var traj in dic)
                {
                    foreach (var rec in traj.Value)
                    {
                        g.DrawEllipse(Pens.Black, (float)rec.x / (float)max.x * pictureBox1.Width, (float)rec.y / (float)max.y * pictureBox1.Height, 2, 2);
                    }
                }

            }
        }
    }
}
