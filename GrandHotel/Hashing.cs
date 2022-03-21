using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HakAkses
{
    class Hashing
    {
        public static string EncryptSHA256(string s)
        {
            
                SHA256 sha = SHA256.Create();
                byte[] hashdata = sha.ComputeHash(Encoding.UTF8.GetBytes(s));

                StringBuilder resultValues = new StringBuilder();
                for (int i = 0; i < hashdata.Length; i++)
                {
                    resultValues.Append(hashdata[i].ToString("x2"));
                }
                return resultValues.ToString();
            
        }
    }
}
