using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        //out dışarıya verilecek değer gibi düşünülebilir.
        //bu metot verilen password'ün hash ve saltını verir.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                //burda key yerine başka bir değer de verilebilir.
                //Salt ek güvenliğie yarar.
                //her kullanıcı için farklı key değeri verir.
                passwordSalt = hmac.Key;
                //Encoding.UTF8.GetBytes password string olduğundan byte'a bu kodla çevirdik
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        //Sisteme giren kullanıcının passwordünün hashiyle dbdeki passwordün hashi verilen keye göre kontrol ediliyor
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
