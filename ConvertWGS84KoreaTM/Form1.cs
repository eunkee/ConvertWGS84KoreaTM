using System;
using System.Windows.Forms;

namespace ConvertWGS84KoreaTM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0; //Bessel
            comboBox2.SelectedIndex = 1; //중부
            comboBox3.SelectedIndex = 0; //Bessel
            comboBox4.SelectedIndex = 1; //중부
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBoxResultWGSLat.Text.Length > 0 && TextBoxResultWGSLon.Text.Length > 0)
            {
                ButtonKoreaTMtoWGS84_Click(null, null);
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBoxResultWGSLat.Text.Length > 0 && TextBoxResultWGSLon.Text.Length > 0)
            {
                ButtonKoreaTMtoWGS84_Click(null, null);
            }
        }

        private void ButtonKoreaTMtoWGS84_Click(object sender, EventArgs e)
        {
            string textBoxLat = TextBoxTMLat.Text;
            string textBoxLon = TextBoxTMLon.Text;
            if (textBoxLat.Length >= 0 && textBoxLon.Length == 0)
            {
                if (textBoxLat.Contains(',').Equals(true))
                {
                    string[] temp = textBoxLat.Split(',');
                    textBoxLat = temp[0].Replace(" ", "");
                    textBoxLon = temp[1].Replace(" ", "");
                }
            }
            if (textBoxLat.Length >= 0 && textBoxLon.Length >= 0)
            {
                bool canConvert = double.TryParse(textBoxLat, out double tm_lat);
                if (!canConvert)
                {
                    return;
                }
                canConvert = double.TryParse(textBoxLon, out double tm_lon);
                if (!canConvert)
                {
                    return;
                }
                if (tm_lat > 10000 && tm_lon > 10000)
                {
                    WGS84KoreaTM.Ellipsoid ellipsoid = (WGS84KoreaTM.Ellipsoid)comboBox1.SelectedIndex;
                    WGS84KoreaTM.Origin origin = (WGS84KoreaTM.Origin)comboBox2.SelectedIndex;
                    WGS84KoreaTM.TransM2GPS(ellipsoid, origin, tm_lat, tm_lon, out double wgsLat, out double wgsLon);
                    TextBoxResultWGSLat.Text = $"{wgsLat:#.#######}";
                    TextBoxResultWGSLon.Text = $"{wgsLon:#.#######}";
                }
            }
        }

        private void ButtonClearKoreaTMtoWGS84_Click(object sender, EventArgs e)
        {
            TextBoxResultWGSLat.Text = string.Empty;
            TextBoxResultWGSLon.Text = string.Empty;
        }

        private void ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBoxResultTMLat.Text.Length > 0 && TextBoxResultTMLon.Text.Length > 0)
            {
                ButtonWGS84toKoreaTM_Click(null, null);
            }
        }

        private void ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TextBoxResultTMLat.Text.Length > 0 && TextBoxResultTMLon.Text.Length > 0)
            {
                ButtonWGS84toKoreaTM_Click(null, null);
            }
        }

        private void ButtonWGS84toKoreaTM_Click(object sender, EventArgs e)
        {
            string textBoxLat = TextBoxWGSLat.Text;
            string textBoxLon = TextBoxWGSLon.Text;
            if (textBoxLat.Length >= 0 && textBoxLon.Length == 0)
            {
                if (textBoxLat.Contains(',').Equals(true))
                {
                    string[] temp = textBoxLat.Split(',');
                    textBoxLat = temp[0].Replace(" ", "");
                    textBoxLon = temp[1].Replace(" ", "");
                }
            }

            if (textBoxLat.Length >= 0 && textBoxLon.Length >= 0)
            {
                bool canConvert = double.TryParse(textBoxLat, out double wgsLat);
                if (!canConvert)
                {
                    return;
                }
                canConvert = double.TryParse(textBoxLon, out double wgsLon);
                if (!canConvert)
                {
                    return;
                }
                if (wgsLat < 200 && wgsLon < 200)
                {
                    WGS84KoreaTM.Ellipsoid ellipsoid = (WGS84KoreaTM.Ellipsoid)comboBox3.SelectedIndex;
                    WGS84KoreaTM.Origin origin = (WGS84KoreaTM.Origin)comboBox4.SelectedIndex;
                    WGS84KoreaTM.TransGPS2M(ellipsoid, origin, wgsLat, wgsLon, out double tmLat, out double tmLon);
                    TextBoxResultTMLat.Text = $"{tmLat:0.##}";
                    TextBoxResultTMLon.Text = $"{tmLon:0.##}";
                }
            }
        }

        private void ButtonClearWGS84toKoreaTM_Click(object sender, EventArgs e)
        {
            TextBoxResultTMLat.Text = string.Empty;
            TextBoxResultTMLon.Text = string.Empty;
        }

        private void ButtonCopyResultWGS84_Click(object sender, EventArgs e)
        {
            if (TextBoxResultWGSLat.Text.Length > 0 && TextBoxResultWGSLon.Text.Length > 0)
            {
                Clipboard.SetText($"{TextBoxResultWGSLat.Text}, {TextBoxResultWGSLon.Text}");
            }
        }

        private void ButtonCopyResultTM_Click(object sender, EventArgs e)
        {
            if (TextBoxResultTMLat.Text.Length > 0 && TextBoxResultTMLon.Text.Length > 0)
            {
                Clipboard.SetText($"{TextBoxResultTMLat.Text}, {TextBoxResultTMLon.Text}");
            }
        }
    }
}