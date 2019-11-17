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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        string s;
        public string log;
     


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((textBox1.Text == "admin") && (textBox2.Text == "admin"))
            {

                Hide();
                Form2 f = new Form2();
                f.Show();


            }
            else if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                label4.Visible = true;
                label4.Text = "Ошибка! Введите данные!";
            }
            else
            {string path= Application.StartupPath + @"\Database1.mdf";
                string myConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = '"+path+"'; Integrated Security = True";
                string mySelectQuery = "SELECT Должность, Логин FROM [Authorization] WHERE Логин='" + textBox1.Text + "'AND Пароль='" + textBox2.Text + "' ";
                SqlConnection myConnection = new SqlConnection(myConnectionString);
                SqlCommand myCommand = new SqlCommand(mySelectQuery, myConnection);
                try
                {
                    myConnection.Open();
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    if (myReader.HasRows == false) { label4.Visible = true; label4.Text = "Вход не выполнен! Повторите попытк!"; };
                    while (myReader.Read()) { s = myReader.GetString(0); s = s.Replace(" ", string.Empty); log = myReader.GetString(1); }




                    if (s != "")
                    {
                        switch (s)
                        {
                            case "ServiceWorker":
                                label4.Text = "ServiceWorker";

                                Hide();
                                Form5 f = new Form5(log);
                                f.Show();
                              
                                break;
                            case "Engineer":
                                label4.Text = "Engineer";

                                Hide();
                                Form4 f1 = new Form4(log);
                                f1.Show();
                              
                                break;
                            case "Manager":
                                label4.Text = "Manager";

                                Hide();
                                Form3 f2 = new Form3(log);
                                f2.Show();
                            
                                break;
                            default:
                                label4.Text = "Вход не выполнен! Повторите попытку!";

                                break;
                        }

                    }

                }
                catch
                {
                    label4.Text = "Вход не выполнен! Повторите попытку!";

                }
                finally { myConnection.Close(); }

            }

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}


