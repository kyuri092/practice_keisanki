using System;
using System.Windows.Forms;

namespace ゲーム作成の練習
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


          







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            calc1();

        }
        private void calc1()
        {


            int value1 = 0;
            int value2 = 0;

            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("演算子を入力して下さい");
            }

            if (txtValue1.Text.Equals(""))
            {
                MessageBox.Show("数値1を入力して下さい");
                return;
            }

            if (txtValue2.Text.Equals(""))
            {
                MessageBox.Show("数値2を入力して下さい");
                return;
            }

            try
            {
                value1 = int.Parse(txtValue1.Text);
                value2 = int.Parse(txtValue2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラーだo");
                return;
            }



            int answer = 0;

            if (listBox1.SelectedItem.Equals("+"))
            {
                answer = value1 + value2;
            }

            if (listBox1.SelectedItem.Equals("-"))
            {
                answer = value1 - value2;
            }
            if (listBox1.SelectedItem.Equals("*"))
            {
                answer = value1 * value2;
            }
            if (listBox1.SelectedItem.Equals("/"))
            {
                answer = value1 / value2;
            }



            txtAnswer.Text = answer.ToString();


        }

        private void calc2()
        {
            int value1 = 0;
            int value2 = 0;

            value1 = int.Parse(txtValue1.Text);
            value2 = int.Parse(txtValue2.Text);



            int answer = 0;

            if (listBox1.SelectedItem.Equals("+"))
            {
                answer = value1 + value2;
            }

            if (listBox1.SelectedItem.Equals("-"))
            {
                answer = value1 - value2;
            }
            if (listBox1.SelectedItem.Equals("*"))
            {
                answer = value1 * value2;
            }
            if (listBox1.SelectedItem.Equals("/"))
            {
                answer = value1 / value2;
            }



            txtAnswer.Text = answer.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                calc2();
            }
        }

        private void txtValue1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                calc2();
            }
        }

        private void txtValue2_TextChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                calc2();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            int change = 0;
            int value1 = 0;
            int value2 = 0;

            change = int.Parse(txtValue1.Text);

            value1 = int.Parse(txtValue2.Text);
            value2 = change;

            txtValue1.Text = value1.ToString();
            txtValue2.Text = value2.ToString();
           
        }



        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                calc2();
            }
        }
    }
}
