using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MasterLIO.Forms
{
    public partial class SelectAreaForm : Form
    {
        Graphics graph;
        List<Point> points;
        List<Boolean> zonePicked;

        public SelectAreaForm(ref List<Boolean> areasList)
        {
            InitializeComponent();
            this.zonePicked = areasList;
            points = new List<Point>();
            graph = pictureBox1.CreateGraphics();
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            zonePicked.Add(checkBox1.Checked);
            zonePicked.Add(checkBox2.Checked);
            zonePicked.Add(checkBox3.Checked);
            zonePicked.Add(checkBox4.Checked);
            zonePicked.Add(checkBox5.Checked);
            zonePicked.Add(checkBox6.Checked);
            zonePicked.Add(checkBox7.Checked);
            zonePicked.Add(checkBox8.Checked);
            zonePicked.Add(checkBox9.Checked);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
