using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Offline_Disaster_Coaching
{

    public class RootObject
    {
        public string FIELD1 { get; set; }
        public string FIELD2 { get; set; }
        public string FIELD3 { get; set; }
        public string FIELD4 { get; set; }  
        public string FIELD5 { get; set; }
    }

    public partial class Form1 : MetroForm
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void htmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (StreamReader file = File.OpenText(@"C:\Users\Krastan\Documents\GitHub\Offline-Disaster-Coaching"))
                {
                   JsonSerializer serializer = new JsonSerializer();
                    RootObject obj = (RootObject)serializer.Deserialize(file, typeof(RootObject));
                }


            if (metroComboBox1.Text == "Earthquakes")
            {
                
            }
            else if (metroComboBox1.Text == "Flood")
            {

            }
            else if (metroComboBox1.Text == "Hurricane")
            {

            }
            else if (metroComboBox1.Text == "Tornado")
            {

            }
        }
    }
}
