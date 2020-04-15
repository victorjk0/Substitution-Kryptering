using System;
using System.Collections.Generic;
using System.Text;

namespace Substitution_Kryptering
{
    class Encryptor
    {

        int ascii_num;
        string cryptword;

        public string Encrypt(string message)
        {

            for(int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    ascii_num = (int)message[i];
                }
                else
                {
                    ascii_num = (int)message[i] + 1;
                }
                char ascii_char = (char)ascii_num;

                cryptword += ascii_char;
            }

            return cryptword;
        }

        public string Decrypt(string message)
        {

            ascii_num = 0;
            cryptword = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == ' ')
                {
                    ascii_num = (int)message[i];
                }
                else
                {
                    ascii_num = (int)message[i] - 1;
                }
                char ascii_char = (char)ascii_num;

                cryptword += ascii_char;
            }

            return cryptword;
        }
    }
}
