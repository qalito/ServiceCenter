using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCenter
{
    public partial class Form4 : Form
    {
        public Form4(string log)
        {
            InitializeComponent();
        }

        private void receptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.database1DataSet.Work);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Reception". При необходимости она может быть перемещена или удалена.
            this.receptionTableAdapter.Fill(this.database1DataSet.Reception);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                for (int i = 0; i < receptionDataGridView.RowCount; i++)

                {

                    receptionDataGridView.Rows[i].Selected = false;

                    for (int j = 0; j < receptionDataGridView.ColumnCount; j++)

                        if (receptionDataGridView.Rows[i].Cells[j].Value != null)

                            if (receptionDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox4.Text))

                            {

                                receptionDataGridView.Rows[i].Selected = true;



                            }

                }
            }
            if (textBox1.Text == "") receptionDataGridView.ClearSelection();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString); string sql = "Update [Reception] set Статус=@Статус, Описание=@Описание WHERE Акт=@Акт;";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Статус", textBox2.Text);
            cmd_SQL.Parameters.AddWithValue("@Описание", textBox3.Text);
            cmd_SQL.Parameters.AddWithValue("@Акт", textBox1.Text);

            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

                label5.Text = "Статус изменён!";
                label5.Visible = true;
            }
            catch (SqlException ex)
            {
                label5.Text = "Ошибка! Статус не изменён!";
                label5.Visible = true;

            }
            finally
            {

                connect.Close();
                this.receptionTableAdapter.Fill(this.database1DataSet.Reception);
            }

        }
    


        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\tosya_\source\repos\ServiceCenter\ServiceCenter\Database1.mdf; Integrated Security = True");
            string sql = "Delete from [Work]  WHERE[Код работы] = @Код_работы;";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Код_работы", workDataGridView.Rows[workDataGridView.CurrentRow.Index].Cells[0].Value.ToString());
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();
                label11.Text = "Запись успешно Удалена!";
                label11.Visible = true;
            }
            catch (SqlException ex)
            {
                label11.Text = "Ошибка! Запись не удалена";
                label11.Visible = true;

            }
            finally
            {
                connect.Close();
            }

            workBindingSource.RemoveCurrent();
            Validate();
            workBindingSource.EndEdit();
            workTableAdapter.Update(database1DataSet.Work);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            workBindingSource.AddNew();
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString); string sql = "INSERT INTO [Work]  ([Код работы], [Вид ремонтных работ], [Тип устройства]) VALUES (@Код, @Вид, @Тип);";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Код", код_работыTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Вид", вид_ремонтных_работTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Тип", тип_устройстваTextBox.Text);

            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

                label11.Text = "Запись успешно добавлена!";
                label11.Visible = true;
            }
            catch (SqlException ex)
            {
                label11.Text = "Ошибка! Запись не добавлена введите данные корректно! ";
                label11.Visible = true;

            }
            finally
            {
                connect.Close();
            }
            Validate();
            workBindingSource.EndEdit();
            workTableAdapter.Update(database1DataSet.Work);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            workDataGridView.Rows[workDataGridView.RowCount - 2].Cells[0].Value = 2147483640;
            workBindingSource.RemoveAt(workDataGridView.RowCount - 2);

            Validate();
            workBindingSource.EndEdit();
            workTableAdapter.Update(database1DataSet.Work);
            groupBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                for (int i = 0; i < workDataGridView.RowCount; i++)

                {

                    workDataGridView.Rows[i].Selected = false;

                    for (int j = 0; j < workDataGridView.ColumnCount; j++)

                        if (workDataGridView.Rows[i].Cells[j].Value != null)

                            if (workDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox5.Text))

                            {

                                workDataGridView.Rows[i].Selected = true;

                                if (textBox1.Text == "") workDataGridView.ClearSelection();

                            }

                }
            }
            if (textBox1.Text == "") workDataGridView.ClearSelection();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); this.Hide();
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

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

