using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        //jwtlerin oluşturulabilmesi için sisteme girilmesi için elde bulunanlar 
        //örn kullanıcı adı ve şifre bir credentialsdır.Burda ise bir key'e ihtiyaç 
        //var.Paramatre olarak verildi.
        //keyin imzalama nesnesini döndürecek bir fonk.
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
//asp.netin yani web apinin gelen jwt yi doğrulaması gerekiyor.algoritma ve
//keyi bu fonkla veriyoruz.