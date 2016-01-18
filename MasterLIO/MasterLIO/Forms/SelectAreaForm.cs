using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterLIO.Forms
{
    public partial class SelectAreaForm : Form
    {
        Graphics graph;
        List<Point> points;
        public SelectAreaForm()
        {
            graph = this.CreateGraphics();
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true); // в конструкторе
            points = new List<Point>();
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            points.Add(new Point(e.X, e.Y));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
