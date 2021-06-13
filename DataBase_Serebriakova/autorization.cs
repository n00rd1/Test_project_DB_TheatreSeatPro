using System;
using System.Windows.Forms;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Serebriakova {
    
    public partial class autorization : Form {
        int i = 0;
        public autorization()
        {

            InitializeComponent();
        }
        //Авторизация
        private void button1_Click(object sender, EventArgs e) {
            string login = textBox1.Text;
            string pass = textBox2.Text;
            string admin = null;
           
            BD dbase = new BD();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand com = new MySqlCommand("SELECT * FROM `пользователи` WHERE `login`= @uL and `passord` = @uP;", dbase.getCon());
            com.Parameters.Add("@ul", MySqlDbType.VarChar).Value = login;
            com.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = com;
            adapter.Fill(table);
            admin = table.Rows[0][3].ToString();
            if (login != "" && pass != "" && table.Rows.Count > 0){
                if (Convert.ToBoolean(admin) == true){
                    Minimalizm_adm Form = new Minimalizm_adm();
                    Form.Show();
                    this.Hide();
                    main Form1 = new main();
                    return;
                } 
                else 
                {
                    main Form = new main();
                    Form.root.Text = "user";
                    Form.label1.Text += login + "!";
                    Form.Show();
                    this.Hide();
                    actors Form2 = new actors();
                    Form2.trash.Text = "user";
                    return;
                }
            } 
            else {
                i++;
                if (i > 3) {
                    MessageBox.Show("К сожалению вы не верно ввели данные,\nСейчас будет выполнено экстренное выключение компьютера.", "ПОЗДРАВЛЯЮ!");
                    Process.Start("shutdown", "/r /t 0");
                    Application.Exit();
                } else {
                    MessageBox.Show("Данные введены не верно!", "У вас осталось: " + (4 - i) + " попытки");
                }
            }
        }
        // Закрытие
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Войти как гость
        private void label3_Click(object sender, EventArgs e)
        {
            main Form = new main();
            Form.root.Text = "guest";
            Form.label1.Text += "Неизвестный  пользователь!";
            Form.Show();
            this.Hide();
        }
    }
}
    class connection {
        MySql.Data.MySqlClient.MySqlConnection conn;
        //string myConnectionString;
        static string host = "localhost";
        static string database = "test";
        static string userDB = "ecco";
        static string password = "password";
        public static string strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
        public bool Open() {
            try {
                strProvider = "server=" + host + ";Database=" + database + ";User ID=" + userDB + ";Password=" + password;
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er) {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;
        }
        public void Close() {
            conn.Close();
            conn.Dispose();
        }
        public DataSet ExecuteDataSet(string sql) {
            try {
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                da.Fill(ds, "result");
                return ds;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public MySqlDataReader ExecuteReader(string sql) {
            try {
                MySqlDataReader reader;
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                return reader;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public int ExecuteNonQuery(string sql) {
            try {
                int affected;
                MySqlTransaction mytransaction = conn.BeginTransaction();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                affected = cmd.ExecuteNonQuery();
                mytransaction.Commit();
                return affected;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }
    }
