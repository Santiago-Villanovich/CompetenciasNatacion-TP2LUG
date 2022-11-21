using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BLL
{
    public class Seguridad
    {
        public static string GenerarMD5(string sCadena)
        {
            try
            {
                UnicodeEncoding UeCodigo = new UnicodeEncoding();

                byte[] ByteSourceText = UeCodigo.GetBytes(sCadena);
                MD5CryptoServiceProvider Md5 = new MD5CryptoServiceProvider();
                byte[] ByteHash = Md5.ComputeHash(ByteSourceText);
                return Convert.ToBase64String(ByteHash);
            }
            catch (CryptographicException ex)
            { throw (ex); }
            catch (Exception ex)
            { throw (ex); }
        }
    }
}
