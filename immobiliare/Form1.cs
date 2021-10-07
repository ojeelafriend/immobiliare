using System;

using System.Windows.Forms;

namespace immobiliare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            windowBox.Enabled = false;
            flatBox.Enabled = false;
            directionBox.Enabled = false;
            surfaceBox.Enabled = false;
            oldBox.Enabled = false;
            priceBox.Enabled = false;
            btnSendFinalData.Enabled = false;
        }

        private void btnSendFinalData_Click(object sender, EventArgs e)
        {
            string direction = directionBox.Text;
            double squareMeter = Convert.ToDouble(surfaceBox.Text);
            int age = Convert.ToInt32(oldBox.Text);
            double price = Convert.ToDouble(priceBox.Text);

            if (flatCheckBox.Checked)
            {
                int numberFlat = Convert.ToInt32(flatBox.Text);
                Flat flat = new Flat(direction,age,squareMeter,price,numberFlat);
                labelFinalPrice.Text = Convert.ToString(flat.CalculateImmo());
            }
            else
            {
                int numberWindows = Convert.ToInt32(windowBox.Text);
                Local local = new Local(direction, age, squareMeter, price, numberWindows);
                labelFinalPrice.Text = Convert.ToString(local.CalculateImmo());
            }
        }

        private void flatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (flatCheckBox.Checked)
            {
                localCheckBox.Enabled = false;
                flatBox.Enabled = true;

            }
            else
            {
                localCheckBox.Enabled = true;
                flatBox.Enabled = false;
            }
        }

        private void localCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (localCheckBox.Checked)
            {
                flatCheckBox.Enabled = false;
                windowBox.Enabled = true;
            }
            else
            {
                flatCheckBox.Enabled = true;
                windowBox.Enabled = false;
            }
        }

        private void flatBox_TextChanged(object sender, EventArgs e)
        { 

            if(flatBox.Text == "")
            {
                directionBox.Enabled = false;
                surfaceBox.Enabled = false;
                oldBox.Enabled = false;
                priceBox.Enabled = false;
                btnSendFinalData.Enabled = false;
            }
            else
            {
                directionBox.Enabled = true;
                surfaceBox.Enabled = true;
                oldBox.Enabled = true;
                priceBox.Enabled = true;
                btnSendFinalData.Enabled = true;
            }
        }

        private void windowBox_TextChanged(object sender, EventArgs e)
        {
            directionBox.Enabled = true;
            surfaceBox.Enabled = true;
            oldBox.Enabled = true;
            priceBox.Enabled = true;
            btnSendFinalData.Enabled = true;
        }
    }
}
