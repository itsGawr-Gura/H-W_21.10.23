using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace H_W_21._10._23
{
    public static class Extensions
    {
        public static string reverse(this string str)
        {
            return new string(str.Reverse().ToArray());
        }
    }

    internal class Lab_Tumakov_8
    {
        // Ex 8.4 метод интерфейса System.IFormattable.
        public bool ImplementsIFormattable(object obj)
        {
            if (obj as IFormattable != null)
            {
                return true;
            }

            return false;
        }
        public static void SearchMail(ref string s)
        {
            int index = s.IndexOf("#");
            if (index != -1)
            {
                s = s.Substring(index + 1).Trim();
            }
        }
        static void Main(string[] args)
        {
            // Ex 8.1 Bank Account
            Console.WriteLine("Ex 8.1");
            Console.WriteLine("Bank account");
            BankAccount account = new BankAccount(1000, BankAccountType.Checking);

            bool flag;

            BankAccount account1 = new BankAccount(1000, BankAccountType.Checking);
            Console.WriteLine("Account Number: {0}", account.AccountNumber);
            Console.WriteLine("Balance: ${0}", account.Balance);
            Console.WriteLine("--------------------");
            Console.WriteLine("Account Number: {0}", account1.AccountNumber);
            Console.WriteLine("Balance: ${0}", account1.Balance);
            decimal deptoacc2;
            flag = false;
            while (flag != true)
            {
                Console.WriteLine("How much $ do you want deposit to accaunt №{0} from acc №{1}?", account1.AccountNumber, account.AccountNumber);
                flag = decimal.TryParse(Console.ReadLine(), out deptoacc2);
                if (flag == false || deptoacc2 < 0)
                {
                    Console.WriteLine("It's not positive number!");
                    flag = false;
                }
                else if (deptoacc2 > account.Balance)
                {
                    Console.WriteLine("Balance in acc №1 insufficient");
                    flag = false;
                }
                else
                {
                    account.Withdraw(deptoacc2);
                    account1.Deposit(deptoacc2);
                    Console.WriteLine("New Balance in acc №{1}: ${0}", account.Balance, account.AccountNumber);
                    Console.WriteLine("New Balance in acc №{1}: ${0}", account1.Balance, account1.AccountNumber);

                }

            }
            // Ex 8.2 string reverse
            Console.WriteLine("Ex 8.2 string reverse");
            string str = "Reverse";
            Console.WriteLine(str.reverse());
            // Ex 8.3 File creating or reading
            Console.Write("Write file name: ");
            string fileName = Console.ReadLine();

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File doesn't exists.");


            }

            string outputFileName = "output.txt";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    using (StreamWriter writer = new StreamWriter(outputFileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            writer.WriteLine(line.ToUpper());
                        }
                    }
                }

                Console.WriteLine("The contents are written to a file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File processing Error: " + ex.Message);
            }
            // H-W 8.1 метод интерфейса System.IFormattable.
            Console.WriteLine("Work with file, email and ФИО");
            string file = "ФИО и Email.txt";
            string outputFile = "Email.txt";
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    using (StreamWriter writer = new StreamWriter(outputFile))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            SearchMail(ref line);
                            writer.WriteLine(line);
                        }
                    }
                }

                Console.WriteLine("Email address are written to the file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("File processing Error: " + ex.Message);
            }
            // H-W 8.2 Song
            Console.WriteLine("H-W 8.2 Song");
            List<Song> songs = new List<Song>();
            Song song1 = new Song("Song 'Rain'", "Author - Rainy", null);
            Song song2 = new Song("Song 'Sunrise'", "Author - Rize", song1);
            Song song3 = new Song("Song 'Tornado'", "Author - Tor", song2);
            Song song4 = new Song("Song 'Fog'", "Author - Tumakov", song3);

            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Console.WriteLine("Title: " + song.Title());
            }
            if (song1.Equals(song2))
            {
                Console.WriteLine("Первая и вторая песни в списке равны.");
            }
            else
            {
                Console.WriteLine("Первая и вторая песни в списке не равны.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}












