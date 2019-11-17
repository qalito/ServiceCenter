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
    public partial class Form3 : Form
    {
        string log;
        public Form3(string l)
        {
            InitializeComponent();
            log = l;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Reception". При необходимости она может быть перемещена или удалена.
            this.receptionTableAdapter.Fill(this.database1DataSet.Reception);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.database1DataSet.Work);
            label3.Text = "Логин: " + log;
        }

        private void workBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }



        private void button3_Click(object sender, EventArgs e)
        {
            List<string> filterParts = new List<string>();
            if (textBox4.Text != "")
                filterParts.Add("[Тип устройства] = '" + textBox4.Text + "'");

            string filter = string.Join(" AND ", filterParts);
            workBindingSource.Filter = filter;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> filterParts = new List<string>();
            string filter = string.Join(" AND ", filterParts);
            workBindingSource.Filter = filter;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + @"\Database1.mdf";
                string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
                SqlConnection connect = new SqlConnection(myConnectionString);
                string sql = "Update [Work] set [Оплата]=@Оплата WHERE[Код работы]=@Код;";
                SqlCommand cmd_SQL = new SqlCommand(sql, connect);
                cmd_SQL.Parameters.AddWithValue("@Оплата", textBox7.Text);
                cmd_SQL.Parameters.AddWithValue("@Код", textBox6.Text);
                try
                {
                    connect.Open();
                    int n = cmd_SQL.ExecuteNonQuery();
                    label9.Visible = true;
                    label9.Text = "Установлена";
                }
                catch (SqlException ex)
                {
                    label9.Text = "Ошибка! Введите \nсуществующий Код работы";
                    label9.Visible = true;

                }
                finally
                {
                    connect.Close();
                    this.workTableAdapter.Fill(this.database1DataSet.Work);
                    bool b=false;
                    if (textBox6.Text != "")
                    {
                        for (int i = 0; i < workDataGridView.RowCount; i++)
                        {

                            workDataGridView.Rows[i].Selected = false;

                            int j = 0;

                            if (workDataGridView.Rows[i].Cells[j].Value != null)

                                if (workDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox6.Text))

                                {
                                    b = true;
                                 
                               
                                    break;
                                }

                        }
                        if (b == false) { label9.Text = "Ошибка! Введите \nсуществующий Код работы"; }
                    }
                }
            }
            catch 
            {
                label9.Text = "Ошибка! Введите \nкоректно сумму оплаты 0,00";
            }
        }

        private void workDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            label9.Text = "Ошибка! Введите \nкоректно сумму оплаты 0,00";
            e.ThrowException = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); this.Close();

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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}

