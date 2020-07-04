using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using users;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Framework {
	public partial class Form7: Form {

		void update(user u)
        {
			try
			{

				using (SqlConnection sql = new SqlConnection(@"Data Source=NOTEBOOK\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True"))
				{
					sql.Open();
					string sqlExpression;
					sqlExpression = "update [user] set balance= " + u.balance + " where id="+u.id;

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

		user u = new user();
		Form4 f;

		internal Form7(ref user _u, Form4 f4) {
			InitializeComponent();

			u = _u;
			f = f4;
		}

	
		private void button1_Click(object sender, EventArgs e) {

			string deposit = textBox1.Text;

			string payment = comboBox1.Text;

			bool agreed = checkBox1.Checked;

			if (agreed == true) {

				u.balance += Convert.ToDouble(deposit);
				update(u);
			}
            else
            {

				MessageBox.Show("Confirm license to continue", "License");
            }

		}

        private void button2_Click(object sender, EventArgs e)
        {
			f.Visible = true;
			this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
