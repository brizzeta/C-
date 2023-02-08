using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _08._02.Credit_Card
{
    internal class Program
    {
        class Card
        {
            string number;
            string name;
            string CVV;
            string end_date;
            public Card(string num, string name2, string CVV_, string end_d)
            {
                if (num.Length != 16)                  //проверка длины номера
                    throw new Exception("Credit card length is not correct.");

                foreach (char el in num)                //проверка символов номера
                {
                    if (el >= 'A' && el <= 'z')
                    {
                        throw new Exception("Letters can not be in card number.");
                    }
                }
                number = num;

                //----------------------------------------------------------------------------

                foreach (char el in name2)           //проверка фио на цифры
                {
                    if (el >= '0' && el <= '9')
                    {
                        throw new Exception("Numbers can not be in full name.");
                    }
                }

                string[] n = name2.Split(' ');     //проверка фио на количество слов
                if (n.Length != 3) throw new Exception("Full name must includes 3 words.");

                name = name2;

                //----------------------------------------------------------------------------

                if (CVV_.Length != 3)                //проверка CVV на длину
                    throw new Exception("CVV length is not correct.");

                foreach (char el in CVV_)            //проверка CVV на буквы
                {
                    if (el >= 'A' && el <= 'z')
                    {
                        throw new Exception("Letters can not be in CVV.");
                    }
                }
                CVV = CVV_;

                //----------------------------------------------------------------------------

                if (end_d.Length != 5 && end_d[2] != '/')           //проверка даты на длину и знак "/"
                    throw new Exception("End date of credit card is not correct.");

                foreach (char el in end_d)                          //проверка даты на буквы
                {
                    if (el >= 'A' && el <= 'z')
                    {
                        throw new Exception("Letters can not be in date.");
                    }
                }
                end_date = end_d;
            }
            public string Number
            {
                get => number;
                set
                {
                    if (value.Length != 16)                  //проверка длины номера
                        throw new Exception("Credit card length is not correct.");

                    foreach (char el in value)                //проверка символов номера
                    {
                        if (el >= 'A' && el <= 'z')
                        {
                            throw new Exception("Letters can not be in card number.");
                        }
                    }
                    number = value;
                }
            }
            public string Name
            {
                get => name;
                set
                {
                    foreach (char el in value)           //проверка фио на цифры
                    {
                        if (el >= '0' && el <= '9')
                        {
                            throw new Exception("Numbers can not be in full name.");
                        }
                    }

                    string[] n = value.Split(' ');        //проверка фио на количество слов
                    if (n.Length != 3) throw new Exception("Full name must includes 3 words.");

                    name = value;
                }
            }
            public string _CVV
            {
                get => CVV;
                set
                {
                    if (value.Length != 3)                //проверка CVV на длину
                        throw new Exception("CVV length is not correct.");

                    foreach (char el in value)            //проверка CVV на буквы
                    {
                        if (el >= 'A' && el <= 'z')
                        {
                            throw new Exception("Letters can not be in CVV.");
                        }
                    }
                    CVV = value;
                }
            }
            public string End_date
            {
                get => end_date;
                set
                {
                    if (value.Length != 5 && value[2] != '/')           //проверка даты на длину и знак "/"
                        throw new Exception("End date of credit card is not correct.");

                    foreach (char el in value)                          //проверка даты на буквы
                    {
                        if (el >= 'A' && el <= 'z')
                        {
                            throw new Exception("Letters can not be in the date.");
                        }
                    }
                    end_date = value;
                }
            }
            public override string ToString()
            {
                return $"Number of card: {number}\nFull name: {name}\nCVV: {CVV}\nEnd date of card work: {end_date}";
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Card c = new Card("4444444444454444", "Nikol Motorina Pavlovna", "283", "17/d4");
                Console.WriteLine(c.ToString());
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
