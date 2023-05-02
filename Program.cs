using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //fourth day homework


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();



            MyDictionary<string, string> students = new MyDictionary<string, string>();
            students.Add("Emir", "Gürbüz");
            students.Add("Bilge", "Uzun");
           // Console.WriteLine(students.Count); // count degeri boştur! 



            for (int i = 0; i < students.FirstNameLenght; i++)

            {

                Console.WriteLine("Adi :" + students.CountFirstName[i] + " " +"Soyadi : " + students.CountLastName[i]);

            }

            Console.WriteLine("Mevcut liste sayısı : " + students.FirstNameLenght);
        

      }


    }

    class MyDictionary<Tkey , Tvalue>

    {

        Tkey[]  items1;
        Tkey[]  tempArray1;
        Tvalue[]  items2;
        Tvalue[]  tempArray2;


        public MyDictionary()

        {

            items1 = new Tkey[0];
            items2 = new Tvalue[0];

        }


        public void Add(Tkey FirstName , Tvalue LastName)

        {

            tempArray1 = items1; // geçici dizinin referansı items1 dizisinin referansı oldu
            tempArray2 = items2; // geçici dizinin referansı items2 dizisinin referansı oldu

            items1 = new Tkey[items1.Length + 1];

            items2 = new Tvalue[items2.Length + 1];

            for (int i = 0; i < tempArray1.Length; i++)

            {

                items1[i] = tempArray1[i]; // geçici dizinin elemanlarını items1 dizisine aktardık
                

            }

            for (int i = 0; i < tempArray2.Length; i++)

            {

                items2[i] = tempArray2[i];

            }

            

            items1[items1.Length - 1] = FirstName;
            items2[items2.Length - 1] = LastName;

        }

        public int Count

        {

            get { return items1.Length; }

        }

        public Tkey[] CountFirstName // CountFirstName dizisinin elemanlarına erişmek için

        {
            get { return items1; }
        }

        public Tvalue[] CountLastName // CountLastName dizisinin elemanlarına erişmek için

        {
            get { return items2; }

        }

        public int FirstNameLenght // CountFirstName dizisinin uzunluğuna erişmek için

        {

            get { return items1.Length; }

        }

       

    }
}

