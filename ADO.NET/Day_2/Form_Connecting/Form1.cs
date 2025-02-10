using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Form_Connecting
{
    public partial class Form1 : Form
    {
        string ConnString = string.Empty;
        SqlConnection conn;
        SqlCommand com;
        public Form1()
        {
            ConnString = new ConfigurationBuilder().AddJsonFile("AppSetting.json").Build().GetSection("con1").Value;
            conn = new SqlConnection(ConnString);

            InitializeComponent();
            DisConnect();

        }

        private void Display_Click(object sender, EventArgs e)
        {
            com = new SqlCommand("select * from Employee", conn);
            Employees.Items.Clear();
            SqlDataReader DataFlow = com.ExecuteReader();
            while (DataFlow.Read())
            {
                Employees.Items.Add($"({(int)DataFlow[0]})\t{DataFlow[1].ToString()}\t\t{DataFlow[2].ToString()}\t\t{DataFlow[3].ToString()}\t\t{(int)DataFlow[4]}");
            }
            DataFlow.Close();

        }

        private void Add_Click(object sender, EventArgs e)
        {

            string str = $"insert into Employee values ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}')";
            ExcuteStatment(str);

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string str = $"update Employee Set Fname='" + textBox2.Text + "' where Id=" + textBox1.Text;
            ExcuteStatment(str);

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string str = "Delete from Employee where Id='" + textBox1.Text + "'";
            ExcuteStatment(str);

        }
        private void ExcuteStatment(string str)
        {
            com.CommandText = str;
            int affected = com.ExecuteNonQuery();

            MessageBox.Show($"Affected Rows {affected}");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;

        }

        private void Connect_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Connection Opened");

            Btn_Display.Enabled = true;
            Btn_Add.Enabled = true;
            Btn_Change.Enabled = true;
            Btn_Remove.Enabled = true;
            Btn_Connect.Enabled = false;
            Btn_Disconnect.Enabled = true;
        }

        private void DisConnect_Click(object sender, EventArgs e)
        {
            conn.Close();
            MessageBox.Show("Connection Closed");
            DisConnect();

        }
        private void DisConnect()
        {
            Btn_Display.Enabled = false;
            Btn_Add.Enabled = false;
            Btn_Change.Enabled = false;
            Btn_Remove.Enabled = false;
            Btn_Connect.Enabled = true;
            Btn_Disconnect.Enabled = false;
        }
    }
}
