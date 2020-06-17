using System;
using users;
using pay_system;
using System.Collections;
using System.Collections.Generic;
using static System.Console;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Remoting.Services;

namespace program
{
    class Program
    {
        public static void updateU(ref user m)
        {
            try
            {

                using (SqlConnection sql = new SqlConnection(@"Data Source=NOTEBOOK\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True"))
                {
                    sql.Open();
                    string sqlExpression = "update [user] set balance= " + m.balance + ", FirstName =\'" + m.name + "\', SecondName =\'" + m.surName + "\' where id =" + m.id + " ;";


                    SqlCommand command = new SqlCommand(sqlExpression);

                    command.Connection = sql;

                    command.ExecuteNonQuery();

                    sql.Close();

                    ReadKey();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

                ReadKey();
            }
        }
        public static void updateC(ref company m)
        {

            try
            {

                using (SqlConnection sql = new SqlConnection(@"Data Source=NOTEBOOK\SQLEXPRESS;Initial Catalog=MiniBank;Integrated Security=True"))
                {
                    sql.Open();
                    string sqlExpression = "update [corporation] set balance= " + m.balance + ", name =\'" + m.name + "\' where id =" + m.id + " ;";


                    SqlCommand command = new SqlCommand(sqlExpression);

                    command.Connection = sql;

                    command.ExecuteNonQuery();

                    sql.Close();

                    ReadKey();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

                ReadKey();
            }
        }
        public static void payM(ref user m)
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

                WriteLine("Enter num of card or name fo company");
                string a = ReadLine();
                bool ad = true;
                while (reader.Read()) // построчно считываем данные
                {
                    object f1 = reader.GetValue(0);
                    object f7 = reader.GetValue(6);
                    object f8 = reader.GetValue(7);


                    f7 = addingFunk.dellSpace(f7);
                    WriteLine(f1.ToString());
                    WriteLine(f7.ToString()+"    "+a);
                    WriteLine(f7.ToString()==a);
                    WriteLine(f8.ToString());
                    ReadKey();
                    if (Convert.ToString(f7) == a)
                    {
                        WriteLine("Enter sum");
                        double tmp = Convert.ToDouble(ReadLine());
                        if (tmp < m.balance)
                        {
                            user tmp1 = new user();
                            tmp1.id = Convert.ToInt32(f1);
                            tmp1.balance = Convert.ToDouble(f8);
                            m.addPerevod(ref tmp1, tmp);

                            updateU(ref tmp1);
                            updateU(ref m);
                            ad = false;
                        }
                    }

                }

                connection.Close();
                reader.Close();
                if (ad)
                {

                    while (reader.Read()) // построчно считываем данные
                    {
                        object f1 = reader.GetValue(0);
                        object f6 = reader.GetValue(5);
                        object f2 = reader.GetValue(1);


                        f2 = addingFunk.dellSpace(f2);
                        if (Convert.ToString(f2) == a)
                        {
                            WriteLine("Enter sum");
                            double tmp = Convert.ToDouble(ReadLine());
                            if (tmp < m.balance)
                            {
                                company tmp1 = new company();
                                tmp1.id = Convert.ToInt32(f1);
                                tmp1.balance = Convert.ToDouble(f6);
                                m.addPerevod(ref tmp1, tmp);
                                updateC(ref tmp1);
                                updateU(ref m);
                                
                            }
                        }

                        connection.Close();
                        reader.Close();
                    }
                }
            }
        }
        public static void Edit(ref user m)
        {
            while (true)
            {
                Clear();
                WriteLine("1 name");
                WriteLine("2 sur name");
                WriteLine("3 email");
                WriteLine("4 telephone");
                WriteLine("5 password");
                WriteLine("6 beak");
                int s = Convert.ToInt32(ReadLine());
                if (s == 1)
                {
                    WriteLine("Enter new name");
                    string a = ReadLine();
                    m.name = a;
                    updateU(ref m);
                    
                }
                else if (s == 2) {
                    WriteLine("Enter new sur name");
                    string a = ReadLine();
                    m.surName = a;
                    updateU(ref m);
                }
                else if (s == 3) {
                    WriteLine("Enter emil");
                    string a = ReadLine();
                    m.email = a;
                    updateU(ref m);
                }
                else if (s == 4) {
                    WriteLine("Enter new telephone");
                    int a = Convert.ToInt32(ReadLine());
                    m.telephone = a;
                    updateU(ref m);
                }
                else if (s == 5) {

                    WriteLine("Enter new password");
                    string a = ReadLine();
                    m.password = a;
                    updateU(ref m);
                    
                }
                else if (s == 6) { break; }
            }
        }
        static bool join(ref user m)
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
                    Console.WriteLine("Enter login");
                    l = Console.ReadLine();

                    Console.WriteLine("Enter password");
                    p = Console.ReadLine();
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
                                m.telephone = Convert.ToInt32(f5);
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

                ReadKey();
                return false;
                
            }
        }
        static void all(ref user m)
        {
            int s;
            while (true)
            {
                try
                {
                    Console.Clear();
                   
                    WriteLine("1 pay");
                    WriteLine("2 edit pola");
                    WriteLine("3 add many");
                    WriteLine("4 Print information");
                    WriteLine("5 exit");
                    s = Convert.ToInt32(ReadLine());
                    if (s == 1)
                    {
                        payM(ref m);
                    }
                    else if (s == 2) { Edit(ref m); }
                
                    else if (s == 3) {
                        WriteLine("Enter many");
                        double tmp = Convert.ToDouble(ReadLine());
                        m.balance += tmp;
                        updateU(ref m);
                    }
                    else if (s == 4)
                    {
                        WriteLine("Id: " + m.id);
                        WriteLine("Name: " + m.name);
                        WriteLine("Sur name: " + m.surName);
                        WriteLine("Num of card: " + m.numOfCard);
                        WriteLine("Password: " + m.password);
                        WriteLine("Telephone: " + m.telephone);
                        WriteLine("Email: " + m.email);
                        WriteLine("Date: " + m.dateTo);
                        WriteLine("Balance: " + m.balance);
                        WriteLine("History: ");
                        foreach (perevod i in m.history)
                        {
                            WriteLine("\tUser: " + i.user);
                            WriteLine("\tType: " + i.type);
                            WriteLine("\tPrice: " + i.price);
                            WriteLine("\tDate: " + i.date);
                        }
                        ReadKey();
                    }
                    else if (s == 5) { Environment.Exit(0); }
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);

                    ReadKey();
                }
            }
        }
        static void Main(string[] args)
        {
            user m=new user();
            while(!join(ref m)) { };
            
            all(ref m);
        }
    }
}