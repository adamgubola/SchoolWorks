using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarKey
{

    class Ceasar
    {
        string message;
        int shift;
        string secretMessage;




        public Ceasar(int shift)
        {

            this.shift = shift;
        }


        private string TransformMessage(string text, int shiftValue)
        {

            int asci = 128;

            secretMessage = "";

            foreach (char c in text)
            {
                char encriptedChar = (char)(c + shiftValue);
                secretMessage += encriptedChar;
            }

            return secretMessage;
        }

        public string Encrypt(string message)
        {
            return TransformMessage(message, this.shift);
        }

        public string Decrypt(String message)
        {
            return TransformMessage(message, -this.shift);
        }

    }

        internal class Program
        {

            static void Main(string[] args)
            {

            Ceasar ceasar=new Ceasar(4);
            string message = "Elmentem a bolba tejért";
            Console.WriteLine(message);
            string encryptedMessage= ceasar.Encrypt(message);
            Console.WriteLine(encryptedMessage);
            string decryptedMessage= ceasar.Decrypt(encryptedMessage);
            Console.WriteLine(decryptedMessage);
            }
        }
    }

