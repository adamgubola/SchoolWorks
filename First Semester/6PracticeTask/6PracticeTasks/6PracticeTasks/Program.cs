using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PracticeTasks
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Stephen King", "Trap", 2000, 600);

            Console.WriteLine(b.AllData());






            //ReckTangel rack = new ReckTangel(10, 10, "red");
            //ReckTangel rack2= new ReckTangel(0,0, "red");

            //rack.Draw(5, 5);
            //rack2.Draw(5, 5);






            //int finish = 40;

            //Runner run1 = new Runner("Adam", 10, 3);
            //Runner run2 = new Runner("John", 5, 4);

            //do
            //{
            //    run1.RefreshDistance(2);
            //    run2.RefreshDistance(2);

            //    run1.show();
            //    run2.show();

            //} while (run1.GetDistance() <= finish || run2.GetDistance() <= finish);





            //Ceasar ceasar = new Ceasar(4);
            //string message = "Elmentem a bolba tejért";
            //Console.WriteLine(message);
            //string encryptedMessage = ceasar.Encrypt(message);
            //Console.WriteLine(encryptedMessage);
            //string decryptedMessage = ceasar.Decrypt(encryptedMessage);
            //Console.WriteLine(decryptedMessage);

        }
    }
}
