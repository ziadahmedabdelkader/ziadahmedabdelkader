using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Focus ();
            // TODO: This line of code loads data into the 'database1DataSet2.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet2.Table);
            // TODO: This line of code loads data into the 'database1DataSet1.disc' table. You can move, or remove it, as needed.
            this.discTableAdapter.Fill(this.database1DataSet1.disc);
            // TODO: This line of code loads data into the 'database1DataSet.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.database1DataSet.payment);

        }

        private void payedTextBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                text_Ratio.Text = comboBox1.SelectedValue.ToString();
            }
            catch
            {
                MessageBox.Show("are you sure to close");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                double ratio_value = Convert.ToDouble(text_Ratio.Text);
                int reservation_value = Convert.ToInt32(reservationTextBox.Text);
                double pay_value = ratio_value * reservation_value;
                payedTextBox.Text = pay_value.ToString();
               

                if (cash_radio.Checked)
                {
                    MessageBox.Show("Pay  " + pay_value + "  Pound");
                }
                else
                {
                    try
                    {
                        int z = Convert.ToInt32(textBox2.Text);
                        MessageBox.Show(" transaction is succeeded ");
                    }
                    catch
                    {
                        MessageBox.Show("fill the Sequence number ");
                    }


                }
            }
            catch
            {
                MessageBox.Show("enter Health Insurance ");
            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
