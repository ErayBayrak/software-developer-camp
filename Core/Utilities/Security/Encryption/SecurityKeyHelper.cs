using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            //Simetrik şifreleme, bilgileri şifrelemek ve deşifre etmek için yalnızca
            //bir gizli anahtar içeren en basit şifreleme türüdür.Bir sayı, bir
            //kelime veya rastgele harfler dizisi olabilen gizli bir anahtar kullanır.
            //Gönderen ve alıcı, tüm mesajları şifrelemek ve şifresini çözmek için
            //kullanılan gizli anahtarı bilmelidir. İşlem süresinin hızlı olması
            //simetrik şifreleme algoritmalarının en önemli avantajlarındandır.  
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
