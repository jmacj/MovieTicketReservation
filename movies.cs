using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class movies : Form
    {
        public movies()
        {
            InitializeComponent();
        }

        int totalSeatCount = 10;
        double price = 270.50, totalPrice = 0.00;
        int count = 0;
        private void movies_Load(object sender, EventArgs e)
        {
            checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox5.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox6.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox7.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox8.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox9.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox10.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox11.Appearance = System.Windows.Forms.Appearance.Button;
            checkBox12.Appearance = System.Windows.Forms.Appearance.Button;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.Controls)
            {
                if (crtl is CheckBox)
                {
                    if (((CheckBox)crtl).Checked == true)
                    {
                        ((CheckBox)crtl).Checked = false;
                    }
                }
            }
        }

        public void seatCount(int count, double totalPrice)
        {
            if (count == totalSeatCount)
            {
                foreach (Control crtl in this.Controls)
                {
                    if (crtl is CheckBox)
                    {
                        if (((CheckBox)crtl).Checked == false)
                        {
                            crtl.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                foreach (Control crtl in this.Controls)
                {
                    // if checkbox is checked or unchecked 
                    if (crtl is CheckBox)
                    {
                        if (((CheckBox)crtl).Checked == false)
                        {
                            crtl.Enabled = true;
                        }
                    }
                }
            }
            lblMoviePrice.Text = totalPrice.ToString("#.00");
            lblSeatCount.Text = Convert.ToString(totalSeatCount - count);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                MessageBox.Show("checked");
                count += 1;
                totalPrice += price;
            }
            else
            {
                MessageBox.Show("unchecked");
                count -= 1;
                totalPrice -= price;
            }
            seatCount(count, totalPrice);
        }
    }
}
