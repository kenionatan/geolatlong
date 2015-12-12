using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geolatlong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var geo = new Address();
            geo.Line1 = "30 Frank Lloyd Wright Drive";
            geo.State = "MI";

            geo.GeoCode();

            txtLat.Text = geo.Latitude;
            txtLong.Text = geo.Longitude;
        }
    }
}
