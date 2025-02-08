using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            sqlDataAdapter1.Fill(dataSet11);
            sqlConnection1.Close();
            dataGridView1.DataSource = dataSet11.Tables[0];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int RecordID = int.Parse(textBox1.Text);
            DataRow drow = dataSet11.Tables[0].Rows.Find(RecordID);
            if (drow != null) 
            {
                drow.Delete();
                MessageBox.Show("Deleted Sucessfully");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RecordId = int.Parse(textBox1.Text);
            DataRow drow = dataSet11.Tables[0].Rows.Find(RecordId);
          
            if (drow != null) 
            {

                drow[1] = textBox2.Text.Trim() != string.Empty ? textBox2.Text : drow[1];
                drow[2] = textBox3.Text.Trim() != string.Empty ? textBox3.Text : drow[2];
                drow[3] = textBox4.Text.Trim() != string.Empty ? textBox4.Text : drow[3];
                drow[4] = int.TryParse(textBox5.Text,out int x) ? textBox5.Text : drow[4];
            }
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(dataSet11);
            int RecordId=int.Parse(textBox6.Text);
            DataRow drow = dataSet11.Tables[0].Rows.Find(RecordId);
            DataView dview = dataSet11.Tables[0].DefaultView;
            dview.RowFilter = $"ID={RecordId}";
            dataGridView1.DataSource = dview;

            if (drow == null)
            {
                MessageBox.Show("Not Exist..!");
            }
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow drow = dataSet11.Tables[0].NewRow();
            drow[0] = int.Parse(textBox1.Text);
            drow[1] = textBox2.Text;
            drow[2] = textBox3.Text;
            drow[3] = textBox4.Text;
            drow[4] = int.Parse(textBox5.Text);
            dataSet11.Tables[0].Rows.Add(drow);
            sqlConnection1.Open();
            sqlDataAdapter1.Update(dataSet11);
            sqlConnection1.Close();
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            MessageBox.Show("Updated Succesfully");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
