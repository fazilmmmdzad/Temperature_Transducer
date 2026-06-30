using System;
using System.Windows.Forms;

namespace TemperatureTransducer
{
    public partial class Information_Popup : Form
    {
        public Information_Popup()
        {
            InitializeComponent();
        }

        private void Information_Popup_Load(object sender, EventArgs e)
        {
            txt_Application.Text = "The three buttons above degree indicate which temperature scale your selected degree belongs to. Once you write the degree you want to write, you will know how many degrees it is on other temperature scales.";
            txt_ApplicationName.Text = "Honey Degrees";
            txt_Creator.Text = "Fazil Məmmədzadə";
            txt_DateOfCreation.Text = "10.01.2025 10:11";
            txt_Version.Text = "1.0.1";
            label1.Select();
        }
    }
}
