using System;
using System.Collections;
using System.Collections.Generic;

namespace pay_sys
{
    struct perevod//перевод грошей
    {
        public user user;
        public double price;
        public DateTime date;
    }
    class user
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string numOfCard { get; set; }//цифиркі карти
        public DateTime dateTo { get; set; }//дато до якої дійсна карта
        private string password { get; set; }//то для логінації, логін буде емейлом
        public double balance { get; set; }//скільки грошей на рахунку
       
        public List<perevod> history = new List<perevod>();
        public user(string _name, string _sName, string _email, string _telephone, string _numOfCard, DateTime _dateTo, string _password, double _bal)
        {
            name = _name;
            surName = _sName;
            email = _email;
            telephone = _telephone;
            numOfCard = _numOfCard;
            dateTo = _dateTo;
            password = _password;
            balance = _bal;
        }
        public user()
        {
            name = "";
            surName = "";
            email = "";
            telephone = "";
            numOfCard = "";
            dateTo = DateTime.Today;
            password = "";
            balance = 0.0;
        }
        public bool logIn(string _email, string _password)//логінація
        {
            if (email==_email&&password==_password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addPerevod(user use, double s) 
        {
            perevod perev = new perevod();
            perev.price = s;
            perev.user = use;
            perev.date = DateTime.Now;
            balance += s;
            history.Add(perev);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("exit");
        }
    }
}
