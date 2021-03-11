using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Constants
{
    public class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError = "Bu kategoriye daha fazla ürün eklenemez.";
        public static string ProductNameAlreadyExists = "Bu isimde ürün zaten var.";
        public static string CategoryLimitExeded = "Kategori limiti aşıldı. Yeni Ürün eklenemez.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string PasswordError = "Parola Hatası.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string ProductUpdated = "Ürün Güncellendi.";
    }
}