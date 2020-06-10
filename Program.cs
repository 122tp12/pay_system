using System;
using users;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using System.Reflection.Metadata;

namespace constS
{
    class constS
    {
        public static string[] types= { "Jurnei","Medicine", "Games", "Kafe", "Produkts", "Kino", "Auto", "Klothers", "Taxi", "Animals", "Books", "Flowers" };      
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
    struct KashBeak {
        public string name;
        public int procent;
    }
    class uBase{
        virtual public string name { get; set; }
        virtual public string password { get; set; }
        virtual public string email { get; set; }
        virtual public string telephone { get; set; }
        virtual public double balance { get; set; }
        public List<perevod> history=new List<perevod>();
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
    class user:uBase
    {
        override public string name { get; set; }
        public string surName { get; set; }
        override public string email { get; set; }
        override public string telephone { get; set; }
        public string numOfCard { get; set; }//цифиркі карти
        public DateTime dateTo { get; set; }//дато до якої дійсна карта
        override public string password { get; set; }//то для логінації, логін буде емейлом
        override public double balance { get; set; }//скільки грошей на рахунку

        public List<KashBeak> KashBeaks = new List<KashBeak>();
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
            foreach(string i in constS.constS.types){
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
            telephone = "";
            numOfCard = "";
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
    class company:uBase
    {
        override public string name { get; set; }
        override public string password { get; set; }
        override public string email { get; set; }
        override public string telephone { get; set; }
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
        public company(string _name, string _password, string _email, string _telephone, double _balance, string _type)
        {
            name = _name;
            password = _password;
            email = _email;
            telephone = _telephone;
            balance = _balance;
            type = _type;
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
            balance += s;
            use.balance -= s;
            history.Add(perev1);
            use.history.Add(perev2);
        }
    }
}

namespace pay_sys
{
    
    class Program
    {

        static void Main(string[] args)
        {
            List<user> mas = new List<user>();
            int s;
            while (true) {
                try {
                    Console.Clear();
                    WriteLine("1 Add user");
                    WriteLine("2 Add perevod");
                    WriteLine("3 add many");
                    WriteLine("4 Print all");
                    WriteLine("5 exit");
                    s = Convert.ToInt32(ReadLine());
                    if (s == 1)
                    {
                        Clear();
                        user tmp = new user();
                        WriteLine("Enter name");
                        tmp.name = ReadLine();
                        WriteLine("Enter sur name");
                        tmp.surName = ReadLine();
                        WriteLine("Enter email");
                        tmp.email = ReadLine();
                        WriteLine("Enter telephone");
                        tmp.telephone = ReadLine();
                        WriteLine("Enter num of card");
                        tmp.numOfCard = ReadLine();
                        DateTime sw = new DateTime();
                        sw=sw.AddDays(12-1);
                        sw=sw.AddMonths(02-1);
                        sw=sw.AddYears(2020-1);
                        tmp.dateTo = sw;
                        WriteLine("Enter password");
                        tmp.password = ReadLine();
                        WriteLine("Enter balance");
                        tmp.balance = Convert.ToInt32(ReadLine());
                        mas.Add(tmp);
                        ReadKey();
                    }
                    else if (s == 2) {
                        string name1, name2;
                        WriteLine("Enter 1 name");
                        name1 = ReadLine();
                        WriteLine("Enter 2 name");
                        name2 = ReadLine();
                        user u1 = mas.Find(user => user.name == name1);
                        user u2 = mas.Find(user => user.name == name2);
                        if (u1 == null || u2 == null)
                        {
                            Console.WriteLine("Not found");
                        }
                        else
                        {
                            WriteLine("Enter many");
                            double ss = Convert.ToDouble(ReadLine());
                            u1.addPerevod(ref u2, ss);

                        }
                        ReadKey();
                    }
                    else if (s == 3) {
                        string name1;
                        WriteLine("Enter 2 name");
                        name1 = ReadLine();
                        user u1 = mas.Find(user => user.name == name1);
                        double qwe = Convert.ToDouble(ReadLine());
                        u1.balance += qwe;
                        ReadKey();
                    }
                    else if (s == 4) {
                        foreach (user i in mas)
                        {
                            WriteLine($"Name: {i.name}");
                            WriteLine($"Sur name: {i.surName}");
                            WriteLine($"number of card: {i.numOfCard}");
                            WriteLine($"Password: {i.password}");
                            WriteLine($"Telephone: {i.telephone}");
                            WriteLine($"Email: {i.email}");
                            WriteLine($"Date to: {i.dateTo.Day}.{i.dateTo.Month}.{i.dateTo.Year}");
                            WriteLine($"Balance: {i.balance}");
                            WriteLine("History: ");
                            foreach (perevod j in i.history)
                            {
                                WriteLine($"\tName:{j.user.name}");
                                WriteLine($"\tMany:{j.price}");
                                WriteLine($"\tDate:{j.date.Hour}:{j.date.Minute}, {j.date.Day}.{j.date.Month}.{j.date.Year}");
                            }
                            ReadKey();
                        }
                    }
                    else if (s == 5) { }
                }
                catch { };
            }
        }
    }
}
