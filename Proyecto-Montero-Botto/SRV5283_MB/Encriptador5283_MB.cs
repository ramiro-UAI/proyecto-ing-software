using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRV5283_MB
{
    public class Encriptador5283_MB
    {
        public static string EncriptarMD5(string value)
        {
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(Encoding.ASCII.GetBytes(value));

            return (new ASCIIEncoding()).GetString(md5data);
        }

        public static string EncriptarSHA(string value)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytesTexto = Encoding.UTF8.GetBytes(value);
                byte[] hash = sha.ComputeHash(bytesTexto);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
