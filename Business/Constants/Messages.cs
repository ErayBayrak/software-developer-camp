using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Ekleme işlemi başarılı.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Bakım zamanı.";
        public static string ProductListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string Updated="Güncelleme işlemi başarılı.";
        public static string Deleted="Silme işlemi başarılı.";
        public static string ProductNameAlreadyExists="Bu isme sahip bir ürün bulunmakta.";
        public static string CategoryLimitExceded = "Kategori sayısı 15'ten büyük olamaz.";
        public static string AuthorizationDenied = "Yetkiniz yoks.";
        public static string UserRegistered="Kullanıcı kaydoldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Şifre hatalı.";
        public static string SuccessfulLogin="Giriş başarılı.";
        public static string UserAlreadyExists="Bu kullanıcı daha önce kaydolmuş.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
