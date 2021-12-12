using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    internal class ACipher : ICipher
    {
        public string encryption;
        public void decode()
        {
            string encodeString = "";
            foreach (char symbol in encryption)
            {
                char newSymbol = symbol;
                if (symbol != 'а' & symbol != 'А')
                {
                    newSymbol--;
                    encodeString += newSymbol;
                }
                else if (symbol == 'А')
                {
                    encodeString += "Я";
                }
                else if (symbol == 'а')
                    encodeString += "я";
            }
            encryption = encodeString;
        }

        public void encode()
        {
            string encodeString = "";
            foreach (char symbol in encryption)
            {
                char newSymbol = symbol;
                if (symbol != 'я' & symbol != 'Я')
                {
                    newSymbol++;
                    encodeString += newSymbol;
                }
                else if (symbol == 'Я')
                {
                    encodeString += "А";
                }
                else if (symbol == 'я')
                    encodeString += "а";
                else
                    encodeString += "1";

            }
            encryption = encodeString;
        }
    }
}
