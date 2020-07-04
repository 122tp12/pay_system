using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using users;
using pay_system;

namespace Framework {
	public partial class Form3: Form {
        static bool join(ref user m, string lo, string pa)
        {
            try
            {
                string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True";

                SqlConnection connection = new SqlConnection(connectionString);


                string sqlExpression = "SELECT * FROM [user]";
                // Открываем подключение
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    string l, p;
                    l = lo;
                    p = pa;
                    // выводим названия столбцов

                    while (reader.Read()) // построчно считываем данные
                    {
                        object f1 = reader.GetValue(0);
                        object f2 = reader.GetValue(1);
                        object f3 = reader.GetValue(2);
                        object f4 = reader.GetValue(3);
                        object f5 = reader.GetValue(4);
                        object f6 = reader.GetValue(5);
                        object f7 = reader.GetValue(6);
                        object f8 = reader.GetValue(7);
                        object f9 = reader.GetValue(8);

                        f4 = addingFunk.dellSpace(f4);
                        f5 = addingFunk.dellSpace(f5);
                        f6 = addingFunk.dellSpace(f6);

                        if (Convert.ToString(f4) == l || Convert.ToString(f5) == l)
                        {
                            if (Convert.ToString(f6) == p)
                            {
                                reader.Close();
                                m.id = Convert.ToInt32(f1);
                                m.name = Convert.ToString(f2);
                                m.surName = Convert.ToString(f3);
                                m.email = Convert.ToString(f4);
                                m.telephone = f5.ToString();
                                m.password = Convert.ToString(f6);
                                m.numOfCard = Convert.ToString(f7);
                                m.balance = Convert.ToDouble(f8);
                                int tmp = Convert.ToInt32(f9);

                                sqlExpression = "SELECT * FROM Keashbeak";
                                // Открываем подключение
                                command = new SqlCommand(sqlExpression, connection);
                                reader = command.ExecuteReader();
                                while (reader.Read()) // построчно считываем данные
                                {
                                    f1 = reader.GetValue(0);
                                    f2 = reader.GetValue(1);
                                    f3 = reader.GetValue(2);
                                    f4 = reader.GetValue(3);
                                    f5 = reader.GetValue(4);
                                    f6 = reader.GetValue(5);
                                    f7 = reader.GetValue(6);
                                    f8 = reader.GetValue(7);
                                    f9 = reader.GetValue(8);
                                    object f10 = reader.GetValue(9);
                                    object f11 = reader.GetValue(10);
                                    object f12 = reader.GetValue(11);
                                    object f13 = reader.GetValue(12);
                                    if (Convert.ToInt32(f1) == tmp)
                                    {
                                        KashBeak tmp1 = new KashBeak();
                                        tmp1.procent = Convert.ToInt32(f2);
                                        tmp1.name = reader.GetName(1);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f3);
                                        tmp1.name = reader.GetName(2);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f4);
                                        tmp1.name = reader.GetName(3);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f5);
                                        tmp1.name = reader.GetName(4);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f6);
                                        tmp1.name = reader.GetName(5);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f7);
                                        tmp1.name = reader.GetName(6);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f8);
                                        tmp1.name = reader.GetName(7);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f9);
                                        tmp1.name = reader.GetName(8);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f10);
                                        tmp1.name = reader.GetName(9);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f11);
                                        tmp1.name = reader.GetName(10);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f12);
                                        tmp1.name = reader.GetName(11);
                                        m.KashBeaks.Add(tmp1);
                                        tmp1.procent = Convert.ToInt32(f13);
                                        tmp1.name = reader.GetName(12);
                                        m.KashBeaks.Add(tmp1);
                                    }
                                }
                                connection.Close();
                                reader.Close();

                                return true;
                            }
                        }
                    }



                }
                reader.Close();
                connection.Close();


                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

                return false;

            }
        }
        public Form3() {
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e) {

		}

		private void label1_Click(object sender, EventArgs e) {

		}

        private void button1_Click(object sender, EventArgs e)
        {
            string login=textBox2.Text;
            string password=textBox3.Text;
            user m = new user();
            bool tmp=join(ref m, login, password);
            if (tmp == true)
            {
                if (!checkBox1.Checked)
                {
                    textBox2.Text ="";
                    textBox3.Text ="";
                }
                Form4 f = new Form4(this, m);
                f.Show();
                this.Visible = false;
                //here
            }
            else
            {
                error.Text = "Password or login wrong";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
			Form2 f = new Form2(this);
			f.Show();
			this.Visible = false;
           
		}

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
