using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class Form2 : Form
    {
        bool d=false;
        bool iz = false;
        public Form2()
        {
            InitializeComponent();
        }
        
        int znach = 0;



        private void button1_Click(object sender, EventArgs e)
        {
          if (d==true)
            {
                string path = Application.StartupPath + @"\Database1.mdf";
                string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
                SqlConnection connect = new SqlConnection(myConnectionString);
                string sql = "INSERT INTO [Authorization]  (Логин, ФИО, Должность, Пароль) VALUES (@Логин, @ФИО, @Должность,@Пароль );";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@Логин", логинTextBox.Text);
                cmd_SQL.Parameters.AddWithValue("@ФИО", фИОTextBox.Text);
                cmd_SQL.Parameters.AddWithValue("@Должность", должностьComboBox.Text);
                cmd_SQL.Parameters.AddWithValue("@Пароль", парольTextBox.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();

                    label8.Text = "Запись успешно добавлена!";
                    label8.Visible = true;
                }
                catch (SqlException ex)
                {
                    label8.Text = "Ошибка! Запись не добавлена введите данные корректно! ";
                    label8.Visible = true;

                }
                finally
                {
                    connect.Close();
                      this.authorizationTableAdapter.Fill(this.database1DataSet.Authorization);
                }

            }
            if (iz == true)
            {
               

                string path = Application.StartupPath + @"\Database1.mdf";
                string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
                SqlConnection connect = new SqlConnection(myConnectionString);
                string sql = "Update [Authorization] set ФИО=@ФИО, Должность=@Должность, Пароль=@Пароль WHERE Логин=@Логин;";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@Логин", логинTextBox.Text);
                cmd_SQL.Parameters.AddWithValue("@ФИО", фИОTextBox.Text);
                cmd_SQL.Parameters.AddWithValue("@Должность", должностьComboBox.Text);
                cmd_SQL.Parameters.AddWithValue("@Пароль", парольTextBox.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();

                    label8.Text = "Запись успешно измененина!";
                    label8.Visible = true;
                }
                catch (SqlException ex)
                {
                    label8.Text = "Ошибка! Запись не измененина";
                    label8.Visible = true;

                }
                finally
                {
                    connect.Close();
                    this.authorizationTableAdapter.Fill(this.database1DataSet.Authorization);

                }
            }
            логинTextBox.ReadOnly = false;
            groupBox1.Visible = false;
            Validate();
            authorizationBindingSource.EndEdit();
            authorizationTableAdapter.Update(database1DataSet.Authorization);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Table". При необходимости она может быть перемещена или удалена.
            this.authorizationTableAdapter.Fill(this.database1DataSet.Authorization);
            dataGridView1.Rows[0].Selected = false;
            логинTextBox.TabStop = false;
            comboBox1.Text = comboBox1.Items[0].ToString();
            Validate();
            authorizationBindingSource.EndEdit();
            должностьComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].ToString();


        }



        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((znach == 0) && (textBox1.Text != ""))
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)

                {

                    dataGridView1.Rows[i].Selected = false;

                    for (int j = 0; j < dataGridView1.ColumnCount; j++)

                        if (dataGridView1.Rows[i].Cells[j].Value != null)

                            if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))

                            {

                                dataGridView1.Rows[i].Selected = true;
                                

                            }

                }
            }
            else if (textBox1.Text != "") Search(znach);
            else if (textBox1.Text == "") dataGridView1.ClearSelection();
        }
        private void Search(int znach)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)

            {

                dataGridView1.Rows[i].Selected = false;

                int j = znach - 1;

                if (dataGridView1.Rows[i].Cells[j].Value != null)

                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))

                    {

                        dataGridView1.Rows[i].Selected = true;

                        if (textBox1.Text == "") dataGridView1.ClearSelection();

                    }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            authorizationBindingSource.AddNew();
            логинTextBox.ReadOnly = false;
            groupBox1.Visible = true; d = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            логинTextBox.ReadOnly = true;
         
                должностьComboBox.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            groupBox1.Visible = true;
            iz = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";

               SqlConnection connect = new SqlConnection(myConnectionString);
            string sql = "Delete from [Authorization]  WHERE Логин=@Логин;";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Логин", dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

                label8.Text = "Запись успешно Удалена!";
                label8.Visible = true;
            }
            catch (SqlException ex)
            {
                label8.Text = "Ошибка! Запись не удалена";
                label8.Visible = true;

            }
            finally
            {
                connect.Close();
            }
            authorizationBindingSource.RemoveCurrent();
            Validate();
            authorizationBindingSource.EndEdit();
            authorizationTableAdapter.Update(database1DataSet.Authorization);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: znach = 0;

                    break;
                case 1:
                    znach = 1;

                    break;
                case 2:
                    znach = 2;

                    break;
                case 3:
                    znach = 3;

                    break;
                default:
                    znach = 0;

                    break;
            }
        }

     
       

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> filterParts = new List<string>();
            if (textBox2.Text != "")
            filterParts.Add("Логин = '" + textBox2.Text + "'");
            if (textBox3.Text != "")
            filterParts.Add("ФИО = '" + textBox3.Text + "'");
             if (comboBox2.SelectedIndex >= 0)
            filterParts.Add("Должность = '" + comboBox2.Text + "'");
            string filter = string.Join(" AND ", filterParts);
            authorizationBindingSource.Filter = filter;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    comboBox2.Text = "Manager";

                    break;
                case 1:
                    comboBox2.Text = "Engineer";

                    break;
                case 2:
                    comboBox2.Text = "ServiceWorker";

                    break;
              
                default:
                    comboBox2.Text = "";

                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Search(1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Search(2);
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value = " ";
            authorizationBindingSource.RemoveAt(dataGridView1.RowCount-2);

            Validate();
            authorizationBindingSource.EndEdit();
            authorizationTableAdapter.Update(database1DataSet.Authorization);
            groupBox1.Visible = false;
        }

        private void справкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void выйтиИзУчётнойЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); this.Close();
        }

        private void выйтиИзПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    } 
}
