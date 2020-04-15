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
using MetroFramework;



namespace Azoth
{
    public partial class Menu : MetroFramework.Forms.MetroForm
    {
        #region vars
        public static bool activ = false;
        public static bool minmax = false;
        public static bool test1 = false;

        public static int min = 0;
        public static int max = 1;
        public static int smooth = 1;
        public static double sense = 1.0;
        public static int fov = 90;

        public static string weapon;
        public static string attachment;
        public static string scope;

        #endregion
        public Menu()
        {
            InitializeComponent();
        }
        #region bool
        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.Checked)
            {
                activ = true;
            }
            else
            {
                activ = false;
            }
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                minmax = true;
            }
            else
            {
                minmax = false;
            }
        }
        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
            {
                test1 = true;
            }
            else
            {
                test1 = false;
            }
        }

        #endregion
        #region int
        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            min = metroTrackBar1.Value;
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {
            max = metroTrackBar2.Value;
        }

        private void metroTrackBar3_Scroll(object sender, ScrollEventArgs e)
        {
            smooth = metroTrackBar3.Value;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            sense = Convert.ToDouble(numericUpDown1.Value);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            fov = Convert.ToInt32(numericUpDown2.Value);
        }
        #endregion
        #region string
        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = (string)metroComboBox1.SelectedItem;
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachment = (string)metroComboBox2.SelectedItem;
        }

        private void metroComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            scope = (string)metroComboBox3.SelectedItem;
        }
        #endregion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
