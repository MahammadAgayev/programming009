using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _28
{
    class BankAccount
    {
        private bool _isCardAccepted;
        private decimal _balance;

        public BankAccount(decimal balance)
        {
            _balance = balance;
        }

        public void AcceptCard()
        {
            Console.Write("PIN'i daxil edin: ");

            string pin = Console.ReadLine();

            if (pin != "1234")
            {
                throw new InvalidOperationException("PIN düzgün deyil");
            }

            _isCardAccepted = true;

            Console.WriteLine("Kart uğurla əlavə olundu");
        }

        public decimal GetBalance()
        {
            if (_isCardAccepted == false)
            {
                throw new InvalidOperationException("Kart məlumatı yoxdur");
                return -1;
            }

            return _balance;
        }

        public void DecreaseBalance(decimal amountToDeduct)
        {
            if (_isCardAccepted == false)
            {
                throw new InvalidOperationException("Kart məlumatı yoxdur");
            }
            else if(amountToDeduct > _balance)
            {
                throw new InvalidOperationException("Balansda kifayət qədər məbləğ yoxdur");
            }

            _balance -= amountToDeduct;
        }

        public void ReturnCard()
        {
            _isCardAccepted = false;

            Console.WriteLine("Kart qaytarıldı");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //error handling
            //exception

            //int a = 5;
            //int b = 0;

            //Console.WriteLine("Division start");
            //Console.WriteLine(a / b);
            //Console.WriteLine("Division finish");

            //compile time error
            //int a = 4.5m;

            //runtime error
            //string s = null;
            //Console.WriteLine(s.Substring(0, 1));

            //int[] arr = new int[2];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;

            //Recurse();

            //while (true)
            //{
            //    int a = 100;
            //}

            //List<int> ints = new List<int>();

            //while(true)
            //{
            //    ints.Add(100);
            //}

            //DivideByZeroException
            //NullReferenceException
            //IndexOutOfRangeException
            //StackOverFlowException
            //OutOfMemoryException

            //Exception

            //try, catch

            Console.OutputEncoding = Encoding.UTF8;

            //try
            //{
            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"Bölmə: {a / b}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0-a bölmək olmaz");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Xəta baş verdi");
            //}

            //Console.Write("x: ");
            //int x = int.Parse(Console.ReadLine());

            //Console.Write("y: ");
            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Vurma: {x * y}");
            //Console.WriteLine("Proqram uğurla öz işini yerinə yetirdi");

            /*
             * 1 - kartin daxil edilmesi
             * 2 - balansin gosterilmesi, kart daxil edilmeyibse, gosterme
             * 3 - balansdan mexaric, -> step 4
             * 4 - kartin geri qaytarilmasi
             */

            BankAccount account = new BankAccount(1000);

            try
            {
                while (true)
                {
                    Console.WriteLine("1 - kartı daxil edin");
                    Console.WriteLine("2 - balansı göstər");
                    Console.WriteLine("3 - balansdan məxaric");
                    Console.WriteLine("4 - kartı qaytar");


                    int operation = int.Parse(Console.ReadLine());

                    if (operation == 4)
                    {
                        return;
                    }

                    switch (operation)
                    {
                        case 1:
                            account.AcceptCard();
                            break;
                        case 2:
                            decimal balance = account.GetBalance();
                            Console.WriteLine($"Balance: {balance}");
                            break;
                        case 3:
                            Console.Write("Məbləğ: ");
                            decimal amount = decimal.Parse(Console.ReadLine());
                            account.DecreaseBalance(amount);
                            break;
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Xəta baş verdi");
            }
            finally
            {
                account.ReturnCard();
            }

            //finally
            //try-catch-finally
            //try-catch
            //try-finally

            //Divide(1, 0);

        }

        static void Recurse()
        {
            int a = 100;

            Recurse();
        }

        static double Divide(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("0-a bölmək olmaz");
                return -1;
            }
            finally
            {
                Console.WriteLine("Əməliyyat uğurla başa çatdı");
            }
        }
    }
}
