using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6PracticeTasks
{
    public class Ceasar
    {
        public int shift;
        public string secretMessage;

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

}


