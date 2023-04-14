using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
//        Issuer: Token'in oluşturulduğu sunucunun adı veya URL'si.
//        Audience: Token'in geçerli olacağı hedef alıcılar.
//        Key: Token'in şifrelenmesi için kullanılacak anahtar.
//        ExpiryInMinutes: Token'in geçerlilik süresi, dakika cinsinden belirtilir.
//        RefreshExpiryInDays: Yenileme token'inin geçerlilik süresi, gün cinsinden belirtilir.
//        AllowRefresh: Token'in yenilenebilir olup olmadığını belirten bir boolean değerdir.
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
