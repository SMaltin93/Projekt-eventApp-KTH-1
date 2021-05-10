using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace KTHare
{
   
    public class Hashing
    {
        public Register getUserPassword;
        public string getHashed;

        public Hashing(Register getUserPassword)
        {
            this.getUserPassword = getUserPassword;
            this.getHashed = Hash_String(getUserPassword.GetPassword);
        }
        
       private string Hash_String (string userPassword)
        {
            StringBuilder build = new StringBuilder();
            
            for (int i = 0; i < GetHash(userPassword).Length; i++)
            {
                build.Append(GetHash(userPassword)[i].ToString("x2")); //  lowercase , the string should be formatted in Hexadecimal
            }
            return build.ToString();
        }
     

       private byte[] GetHash(string passwordToHash)
        {
            using (HashAlgorithm toHash = SHA256.Create())
            {
                byte[] Hashed = toHash.ComputeHash(Encoding.UTF8.GetBytes(passwordToHash + DateTime.Now));
                    return Hashed;
            }
        }

    }
}
