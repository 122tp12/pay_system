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
using pay_system;

namespace Framework {
	internal partial class Form4: Form {
		Form3 f;
		user u;
		public Form4(Form3 f3, user _u) {
			InitializeComponent();
			f = f3;
			u = _u;
			name.Text =  addingFunk.dellSpace(u.name) + " " + addingFunk.dellSpace(u.surName);
			card.Text = u.numOfCard;
			telephone.Text=u.telephone;
			email.Text=u.email;
			date.Text=u.dateTo.Day.ToString()+"."+u.dateTo.Month.ToString()+"."+u.dateTo.Year.ToString();
			balance.Text = u.balance.ToString();
		}
		
		private void button3_Click(object sender, EventArgs e)
        {
			f.Visible = true;
			this.Close();
        }

        private void telephone_Click(object sender, EventArgs e)
        {

        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void card_Click(object sender, EventArgs e)
        {

        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            this.Visible = false;

                Form7 form = new Form7(ref u, this);

                form.Show();

            
        }
    }
}
