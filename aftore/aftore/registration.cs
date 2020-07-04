using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pay_system;
using users;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Framework {
	
    public partial class Form2: Form {
        private void insert(user m)
        {
            try
            {

                using (SqlConnection sql = new SqlConnection(@"Data Source=NOTEBOOK\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True"))
                {
                    sql.Open();
                    string sqlExpression;
                    sqlExpression = "insert into [user] (FirstName, SecondName, email, telephone, password, nameOfCard, balance) values(\'"+m.name+ "\', \'" + m.surName+ "\', \'" + m.email+ "\', \'" + m.telephone+ "\', \'" + m.password+ "\', \'" + m.numOfCard+ "\', " + m.balance+")";

                    SqlCommand command = new SqlCommand(sqlExpression);

                    command.Connection = sql;

                    command.ExecuteNonQuery();

                    sql.Close();

                    
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"{e} Exception caught.", "Error sql");
            }
        }
        public string card()
        {
            while (true) {
                Random r = new Random();
                int rn1 = r.Next(10000000, 99999999);
                int rn2 = r.Next(10000000, 99999999);
                string qwe = rn1.ToString() + rn2.ToString();
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionString);


                string sqlExpression = "SELECT numOfCard FROM [user]";
                // Открываем подключение
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                bool srt = true;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string a = reader.GetString(0);
                        if (a == qwe)
                        {
                            srt = false;
                        }
                    }
                }
                if (srt)
                {
                    return qwe;
                }
            }
            return "";
        }
        Form3 f;
        public Form2(Form3 f3) {
			InitializeComponent();
            f = f3;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            f.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                string p = textBox1.Text;
                string em = textBox2.Text;
                string pa = textBox3.Text;
                bool re = false;
                string eror = "";
                if (Validator.ValidateEmail(em)) {
                    if (Validator.ValidatePasswordLength(pa)) {
                        if (Validator.ValidatePasswordSymbols(pa)) {

                            user u = new user();
                            u.balance = 0;
                            u.email = em;
                            u.name = textBox4.Text;
                            u.surName = textBox5.Text;
                            u.password = pa;
                            u.telephone = p;
                            Random r = new Random();
                            int rn1 = r.Next(10000000, 99999999);
                            int rn2 = r.Next(10000000, 99999999);
                            string qwe = rn1.ToString() + rn2.ToString();
                            u.numOfCard = qwe;
                            u.dateTo = DateTime.Now.AddYears(2);

                            MessageBox.Show($"{u.name} {u.surName}\n{u.numOfCard}\n{u.password}\n{u.telephone}\n{u.email}\n{u.balance}\n{u.dateTo}");

                            insert(u);
                            f.Visible = true;
                            this.Close();

                        }

                        else
                        {
                            re = true;
                            eror += "password(symphols) ";
                        }
                    }

                    else
                    {

                        re = true;
                        eror += "password(lenght) ";
                    }

                }
                else
                {
                    re = true;
                    eror += "email ";
                }
                if (re)
                {
                    MessageBox.Show("Invalid value in " + eror, "Error");
                }
                else
                {
                    MessageBox.Show("User registered", "Ok");
                }
            }
            else
            {
                MessageBox.Show("License is not confirmed", "License");
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
