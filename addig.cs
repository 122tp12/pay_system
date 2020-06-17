using System;
using users;
using pay_system;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using System.Data.SqlClient;
using System.Configuration;

namespace constS
{
    class constS
    {
        public static string[] types = { "Jurnei", "Medicine", "Games", "Kafe", "Produkts", "Kino", "Auto", "Clothers", "Taxi", "Animals", "Books", "Flowers", "Add many"};
    }
}
namespace users
{

    struct perevod//перевод грошей
    {
        public uBase user;
        public double price;
        public DateTime date;
        public string type;
    }
    struct KashBeak
    {
        public string name;
        public int procent;
    }
    class uBase
    {
        virtual public string name { get; set; }
        virtual public int id { get; set; }
        virtual public string password { get; set; }
        virtual public string email { get; set; }
        virtual public int telephone { get; set; }
        virtual public double balance { get; set; }
        public List<perevod> history = new List<perevod>();
        virtual public bool logIn(string _email, string _password)//логінація
        {
            if (email == _email && password == _password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class user : uBase
    {
        override public string name { get; set; }
        public string surName { get; set; }
        override public string email { get; set; }
        override public int telephone { get; set; }
        public string numOfCard { get; set; }//цифиркі карти
        public DateTime dateTo { get; set; }//дато до якої дійсна карта
        override public string password { get; set; }//то для логінації, логін буде емейлом
        override public double balance { get; set; }//скільки грошей на рахунку

        public List<KashBeak> KashBeaks = new List<KashBeak>();
        public user(string _name, string _sName, string _email, int _telephone, string _numOfCard, DateTime _dateTo, string _password, double _bal)
        {
            name = _name;
            surName = _sName;
            email = _email;
            telephone = _telephone;
            numOfCard = _numOfCard;
            dateTo = _dateTo;
            password = _password;
            balance = _bal;
            foreach (string i in constS.constS.types)
            {
                KashBeak tmp = new KashBeak();
                tmp.name = i;
                tmp.procent = 0;
                KashBeaks.Add(tmp);
            }
        }
        public user()
        {
            name = "";
            surName = "";
            email = "";
            telephone = 0;

            dateTo = DateTime.Today;
            password = "";
            balance = 0.0;
            foreach (string i in constS.constS.types)
            {
                KashBeak tmp = new KashBeak();
                tmp.name = i;
                tmp.procent = 0;
                KashBeaks.Add(tmp);
            }
        }
        public void addPerevod(ref user use, double s)
        {
            perevod perev1 = new perevod();
            perevod perev2 = new perevod();
            perev1.price = s;
            perev1.user = use;
            perev1.date = DateTime.Now;
            perev2.price = -s;
            perev2.user = this;
            perev2.date = DateTime.Now;
            balance -= s;
            use.balance += s;
            history.Add(perev1);
            use.history.Add(perev2);
        }
        public void addPerevod(ref company use, double s)
        {
            perevod perev1 = new perevod();
            perevod perev2 = new perevod();
            perev1.price = s;
            perev1.user = use;
            perev1.date = DateTime.Now;
            perev2.price = -s;
            perev2.user = this;
            perev2.date = DateTime.Now;
            string tmp = use.type;
            if (s > 0)
            {
                balance -= s;
                balance += s * (Convert.ToDouble(KashBeaks.Find(KashBeak => KashBeak.name == tmp).procent) / 100);
                use.balance += s;
            }
            else
            {

                balance += s;
                use.balance -= s;
            }
            history.Add(perev1);
            use.history.Add(perev2);
        }
    }
    class company : uBase
    {
        override public string name { get; set; }
        override public string password { get; set; }
        override public string email { get; set; }
        override public int telephone { get; set; }
        override public double balance { get; set; }
        public string type { get; set; }
        override public bool logIn(string _email, string _password)//логінація
        {
            if (email == _email && password == _password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public company(string _name, string _password, string _email, int _telephone, double _balance, string _type)
        {
            name = _name;
            password = _password;
            email = _email;
            telephone = _telephone;
            balance = _balance;
            type = _type;
        }
        public company()
        { }
        public void addPerevod(ref user use, double s)
        {
            perevod perev1 = new perevod();
            perevod perev2 = new perevod();
            perev1.price = s;
            perev1.user = use;
            perev1.date = DateTime.Now;
            perev2.price = -s;
            perev2.user = this;
            perev2.date = DateTime.Now;
            balance += s;
            use.balance -= s;
            history.Add(perev1);
            use.history.Add(perev2);
        }
    }
}
namespace pay_system
{
    public class Validator
    {
        // Валідація баланса, різних цифр, тощо...
        public static bool ValidateSum(string str)
        {
            try
            {
                int temp = Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }
            return true;
        }
        // Валідація довжини пароля...
        public static bool ValidatePasswordLength(string str)
        {
            if (str.Length >= 8 && str.Length <= 24)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Валідація символів пароля...
        public static bool ValidatePasswordSymbols(string str)
        {
            foreach (char a in str)
            {
                if (Convert.ToInt32(a) >= 32 && Convert.ToInt32(a) <= 90 || Convert.ToInt32(a) >= 97 && Convert.ToInt32(a) <= 122)
                { }
                else
                {
                    return false;
                }
            }
            return true;
        }
        // Валідація входу(паролю)...
        public static bool ValidatePasswords(string RealPassword, string Password)
        {
            if (RealPassword == Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Валідація входу(логіна)...
        public static bool ValidateLogin(string RealEmail, string RealNumber, string Login)
        {
            if (RealEmail == Login || RealNumber == Login)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // Валідація пошти...
        public static bool ValidateEmail(string str)
        {
            bool result = true;
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char a = str[i];
                if (a >= 'a' && a <= 'z' || a >= '0' && a <= '9' || a == '-' || a == '.' || a == '@')
                {
                    if (a == '-' || a == '.' || a == '@')
                    {
                        if (str[i + 1] == '-' || str[i + 1] == '.' || str[i + 1] == '@')
                        {
                            result = false;
                        }
                    }
                }
                else
                {
                    result = false;
                }
                if (a == '@')
                {
                    count++;
                }
            }
            if (count != 1)
            {
                result = false;
            }
            if (result == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class addingFunk
    {
        public static string dellSpace(object s)
        {
            string a = s.ToString();
            bool af = true;
            while (af)
            {
                af = false;
                if (a[0] == ' ')
                {
                    af = true;
                    a=a.Remove(0);
                }
                if (a[a.Length - 1] == ' ')
                {
                    af = true;
                    a=a.Remove(a.Length - 1);
                }
            }
            return a;
        }


    }


}

 