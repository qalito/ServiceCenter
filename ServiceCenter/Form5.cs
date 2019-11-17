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
using Word = Microsoft.Office.Interop.Word;

namespace ServiceCenter
{
    public partial class Form5 : Form
    {
        string log;
        public Form5(string l)
        {
            InitializeComponent();
            log = l; }
        private readonly string TeamplateFileName = Application.StartupPath + @"\template.docx";
        private void receptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            приёмщикTextBox.Text = log;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.database1DataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Device". При необходимости она может быть перемещена или удалена.
            this.deviceTableAdapter.Fill(this.database1DataSet.Device);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.database1DataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Reception". При необходимости она может быть перемещена или удалена.
            this.receptionTableAdapter.Fill(this.database1DataSet.Reception);
            Form1 fr1 = new Form1();
            label3.Text = "Логин: " + log;
            deviceDataGridView.ClearSelection();
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            receptionDataGridView.Size = new Size(445, 338);
            receptionDataGridView.Location = new System.Drawing.Point(287, 0);
            receptionDataGridView.Visible = true;
            receptionDataGridView.Rows[0].Selected = false;
            deviceDataGridView.Rows[0].Selected = false;
            clientsDataGridView.Rows[0].Selected = false;
            this.Width = 760;
            this.Height = 570;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Width = 1130;
            this.Height = 570;
            receptionBindingSource.AddNew();
            groupBox1.Visible = true;
            актTextBox.Text = Convert.ToString(receptionDataGridView.RowCount - 1);
            приёмщикTextBox.Text = log;


            статусTextBox.Text = "Принят";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 760;
            this.Height = 570;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString); string sql = "INSERT INTO [Reception]  ([Акт], [Код_устройства], [Код_заказчика], [Гарантийный], [Описание], [Дата], [Приёмщик], [Статус]) VALUES (@Акт, @Код_устройства, @Код_заказчика,@Гарантийный, @Описание, @Дата,@Приёмщик, @Статус);";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Акт", актTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Код_устройства", код_устройстваTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Код_заказчика", код_заказчикаTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Гарантийный", гарантийныйTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Описание", описаниеTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Дата", датаDateTimePicker.Value.ToString());
            cmd_SQL.Parameters.AddWithValue("@Приёмщик", приёмщикTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Статус", статусTextBox.Text);
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();
                label4.Text = "Заказ успешно оформоен!";
                label4.Visible = true;
            }
            catch (SqlException ex)
            {
                label4.Text = "Ошибка! Запись не добавлена введите данные корректно! ";
                label4.Visible = true;

            }
            finally
            {
                connect.Close();
            }
            Validate();
            receptionBindingSource.EndEdit();
            receptionTableAdapter.Update(database1DataSet.Reception);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool b = false;
            if (код_заказчикаTextBox.Text != "")
            {
                for (int i = 0; i < clientsDataGridView.RowCount; i++)
                {

                    clientsDataGridView.Rows[i].Selected = false;

                    int j = 0;

                    if (clientsDataGridView.Rows[i].Cells[j].Value != null)

                        if ((clientsDataGridView.Rows[i].Cells[j].Value.ToString().Contains(код_заказчикаTextBox.Text)) && (b != true))

                        {

                            clientsDataGridView.CurrentCell = clientsDataGridView.Rows[i].Cells[j];
                            groupBox2.Visible = true; b = true;
                            button13.Visible = false; button5.Visible = false;
                        }

                }
            }
            if (b == false)
            {
                clientsBindingSource.AddNew();
                код_заказчикаTextBox1.ReadOnly = false;
                код_заказчикаTextBox1.Text = Convert.ToString(clientsDataGridView.RowCount - 1);
                код_заказчикаTextBox.Text = код_заказчикаTextBox1.Text;
                код_заказчикаTextBox1.ReadOnly = true;
                groupBox2.Visible = true;

            }
            else if (код_заказчикаTextBox.Text == "")
            {

                clientsBindingSource.AddNew();
                код_заказчикаTextBox1.ReadOnly = false;
                код_заказчикаTextBox1.Text = Convert.ToString(clientsDataGridView.RowCount - 1);
                код_заказчикаTextBox.Text = код_заказчикаTextBox1.Text;
                код_заказчикаTextBox1.ReadOnly = true;
                groupBox2.Visible = true;

            }

        }
        static bool Search()
        { bool b = false;

            return b;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            bool b = false;
            groupBox3.Visible = true;
            if (код_устройстваTextBox.Text != "")
            {
                for (int i = 0; i < deviceDataGridView.RowCount; i++)
                {

                    deviceDataGridView.Rows[i].Selected = false;

                    int j = 0;

                    if (deviceDataGridView.Rows[i].Cells[j].Value != null)

                        if ((deviceDataGridView.Rows[i].Cells[j].Value.ToString().Contains(код_устройстваTextBox.Text)) && (b != true))

                        {

                            deviceDataGridView.CurrentCell = deviceDataGridView.Rows[i].Cells[j];
                            groupBox3.Visible = true; b = true;
                            button14.Visible = false; button6.Visible = false;

                        }

                }

            }


            if (b == false)
            {
                deviceBindingSource.AddNew();
                код_устройстваTextBox1.ReadOnly = false;
                код_устройстваTextBox1.Text = Convert.ToString(deviceDataGridView.RowCount - 1);
                код_устройстваTextBox.Text = код_устройстваTextBox1.Text;
                код_устройстваTextBox1.ReadOnly = true;
                groupBox3.Visible = true;


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString);
            string sql = "INSERT INTO [Clients]  ([Код_заказчика], [Заказчик], [Контакты], [Статусы]) VALUES (@Код_заказчика, @Заказчик, @Контакты,@Статусы );";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Код_заказчика", код_заказчикаTextBox1.Text);
            cmd_SQL.Parameters.AddWithValue("@Заказчик", заказчикTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Контакты", контактыTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Статусы", статусыTextBox.Text);
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {


            }
            finally
            {
                connect.Close();
            }
            Validate();
            deviceBindingSource.EndEdit();
            deviceTableAdapter.Update(database1DataSet.Device);
            код_устройстваTextBox.Text = код_устройстваTextBox1.Text;
            Validate();
            deviceBindingSource.EndEdit();
            deviceTableAdapter.Update(database1DataSet.Device);
            groupBox3.Visible = false;
            код_заказчикаTextBox.Text = код_заказчикаTextBox1.Text;
            Validate();
            clientsBindingSource.EndEdit();
            clientsTableAdapter.Update(database1DataSet.Clients);
            groupBox2.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString);
            string sql = "INSERT INTO [Device]  ([Код_устройства], [Тип], [Производитель], [Модель], [Серийный_номер]) VALUES (@Код_устройства, @Тип, @Производитель,@Модель,@Серийный_номер );";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Код_устройства", код_устройстваTextBox1.Text);
            cmd_SQL.Parameters.AddWithValue("@Тип", типTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Производитель", производительTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Модель", модельTextBox.Text);
            cmd_SQL.Parameters.AddWithValue("@Серийный_номер", серийный_номерTextBox.Text);
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {


            }
            finally
            {
                connect.Close();
            }
            Validate();
            deviceBindingSource.EndEdit();
            deviceTableAdapter.Update(database1DataSet.Device);
            код_устройстваTextBox.Text = код_устройстваTextBox1.Text;
            Validate();
            deviceBindingSource.EndEdit();
            deviceTableAdapter.Update(database1DataSet.Device);
            groupBox3.Visible = false;

        }



        private void button7_Click(object sender, EventArgs e)
        {
            clientsDataGridView.Size = new Size(445, 338);
            clientsDataGridView.Location = new System.Drawing.Point(287, 0);
            receptionDataGridView.Visible = false;
            deviceDataGridView.Visible = false;
            clientsDataGridView.Visible = true;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            deviceDataGridView.Size = new Size(445, 338);
            deviceDataGridView.Location = new System.Drawing.Point(287, 0);

            receptionDataGridView.Visible = false;
            clientsDataGridView.Visible = false;
            deviceDataGridView.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            clientsDataGridView.Visible = false;
            deviceDataGridView.Visible = false;
            receptionDataGridView.Size = new Size(445, 338);
            receptionDataGridView.Location = new System.Drawing.Point(287, 0);
            receptionDataGridView.Visible = true;


        }


        private void button11_Click(object sender, EventArgs e)
        {
            this.Height = 570;
            this.Width = 760;

            receptionDataGridView.Rows[receptionDataGridView.RowCount - 2].Cells[0].Value = 2147483640;
            receptionBindingSource.RemoveAt(receptionDataGridView.RowCount - 2);

            Validate();
            receptionBindingSource.EndEdit();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try {
                string akt = актTextBox.Text; var kod_dev = код_устройстваTextBox.Text; var kod_zak = код_заказчикаTextBox.Text;
                string inf_dev = серийный_номерTextBox.Text;
                string inf_zak = заказчикTextBox.Text;
                string gar = гарантийныйTextBox.Text;
                string op = описаниеTextBox.Text;
                string dat = датаDateTimePicker.Value.ToString();
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var wordDocument = wordApp.Documents.Open(TeamplateFileName);
                ReplaceWordStub("{akt}", akt, wordDocument);
                ReplaceWordStub("{koddev}", kod_dev, wordDocument);
                ReplaceWordStub("{kodzak}", kod_zak, wordDocument);
                ReplaceWordStub("{infdev}", inf_dev, wordDocument);
                ReplaceWordStub("{inf_ak}", inf_zak, wordDocument);
                ReplaceWordStub("{gar}", gar, wordDocument);
                ReplaceWordStub("{op}", op, wordDocument);
                ReplaceWordStub("{dat}", dat, wordDocument);
                wordDocument.SaveAs2(FileName: @"D:\Заказ.docx");
                wordApp.Visible = true;
                MessageBox.Show(@"Заказ сформирован! Расположение...D:\Заказ.docx");
            }
            catch { MessageBox.Show("Произошла ошибка!");

            }

        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);

        }
        private void button13_Click(object sender, EventArgs e)
        {

            clientsDataGridView.Rows[clientsDataGridView.RowCount - 2].Cells[0].Value = 2147483640;
            clientsBindingSource.RemoveAt(clientsDataGridView.RowCount - 2);

            Validate();
            clientsBindingSource.EndEdit();
            clientsTableAdapter.Update(database1DataSet.Clients);
            groupBox2.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            deviceDataGridView.Rows[deviceDataGridView.RowCount - 2].Cells[0].Value = 2147483640;
            deviceBindingSource.RemoveAt(deviceDataGridView.RowCount - 2);

            Validate();
            deviceBindingSource.EndEdit();
            deviceTableAdapter.Update(database1DataSet.Device);
            groupBox3.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
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

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + @"\Database1.mdf";
            string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '" + path + "'; Integrated Security = True";
            SqlConnection connect = new SqlConnection(myConnectionString);
            string sql = "Update [Reception] set Статус=@Статус WHERE Акт=@Акт;";
            SqlCommand cmd_SQL = new SqlCommand(sql, connect);
            cmd_SQL.Parameters.AddWithValue("@Статус", "Закрыт");
            cmd_SQL.Parameters.AddWithValue("@Акт", textBox1.Text);
            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();
                label5.Text = "Заказ закрыт!";
                label5.Visible = true;
            }
            catch (SqlException ex)
            {
                label5.Text = "Ошибка! Введите существующий №Акта!";
                label5.Visible = true;

            }
            finally
            {
                connect.Close();

                if (textBox1.Text != "")
                {
                    for (int i = 0; i < receptionDataGridView.RowCount; i++)
                    {

                        receptionDataGridView.Rows[i].Selected = false;

                        int j = 0;

                        if (receptionDataGridView.Rows[i].Cells[j].Value != null)

                            if (receptionDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))

                            {

                                receptionDataGridView.Rows[i].Cells[7].Value = "Закрыт";
                                Validate();
                                receptionBindingSource.EndEdit();
                                receptionTableAdapter.Update(database1DataSet.Reception);
                                label5.Text = "Заказ закрыт!";
                            }

                    }
                }
                Validate();
                receptionBindingSource.EndEdit();
                receptionTableAdapter.Update(database1DataSet.Reception);

            }
        }
    } 
}

       
    
