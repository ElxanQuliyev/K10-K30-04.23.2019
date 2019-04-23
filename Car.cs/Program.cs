using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.cs
{
    class Program
    {
         static string userInput;
       
        static void Main(string[] args)
        {
            Car masin1 = new Car("Bmw","m5");
            Car masin2 = new Car("Mercedec", "Sclass");
            do
            {
                Console.WriteLine("1.Go");
                Console.WriteLine("2.Top up ");
                Console.WriteLine("3.Local km ");
                Console.WriteLine("4.Global km ");
                Console.WriteLine("5.Exit");
                Console.Write(">>>>>>");
                userInput = Console.ReadLine();
                if (CheckInput(userInput)) {
                    switch (userInput)
                    {
                        case  "1":
                            masin1.Go();



                            break;
                        case "2":
                            Console.WriteLine("Masin benzin vuruldu");
                            break;
                        case "3":
                            Console.WriteLine("Local km bu qederdir");
                            break;
                        case "4":
                            Console.WriteLine("Global km bu qederdir");
                            break;
                        default:
                            Console.WriteLine("Xahis edirik yuxardikaki reqemlerden birin daxil edin");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Xahis edirik reqem  daxil edin");
                }
            } while (userInput != "5");
           



        }
        static public bool CheckInput(string input)
        {
            try
            {
                int userInput = Convert.ToInt32(input);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }
    }
    class Car
    {
        public string Marka;
        public string Model;
        private int FullEff;
        private double CurrentEff=50;
        private double MaxFuell;
        public double LocalKM;
        public double GlobalKm;


        public Car(string marka, string model,int fullEff=20,int maxFuell=60)
        {
            Marka = marka;
            Model = model;
            FullEff = fullEff;
            MaxFuell = maxFuell;
        }
        public void Go()
        {
            double neededKM = 0;
            while (neededKM == 0)
            {
                Console.Write("Nece km Getmek isdeyirsiz? : ");
                string input = Console.ReadLine();
           

                if (CheckInput(input))
                {
                    neededKM = Convert.ToDouble(input);
                  
                    if(CurrentEff <= neededKM / 100 * FullEff)
                    {
                        Console.WriteLine("Sizin benziniz yoxdur.Lütfen Benzin doldurun");

                    }
                    else
                    {
                        CurrentEff -= neededKM / 100 * FullEff;
                        Console.WriteLine("Siz {0} km getdiniz.{1} lt benziniz qaldi",neededKM,CurrentEff);

                    }
                }
                else
                {
                    Console.WriteLine("Xahis edirik reqem gonderin");
                }
            }
          
          
        }
         public bool CheckInput(string input)
        {
            try
            {
              Convert.ToUInt32(input);
                return true;

            }
            catch (Exception)
            {

                return false;
            }

        }

    }
   
}
