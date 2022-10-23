using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarUpdated = "Ürün güncellendi.";
        public static string CarDeleted = "Ürün silindi.";
        public static string CarListed = "Ürünler listelendi.";
        public static string RentalListed = "Kiralama listelendi.";
        public static string CustomerListed = "Müşteriler listelendi.";
        public static string Useristed = "Kullanıcılar listelendi.";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalUpdated = "Kiralama güncellendi.";
        public static string RentalDeleted = "Kiralama silindi.";
        public static string BusyCar = "Kiralamak istediğiniz araba şu an mevcut değil.";

        public static string CarDescriptionInvalid = "Araba açıklaması geçersiz.";
        public static string CompanyInvalid = "Şirket ismi geçersiz.";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz.";
        public static string CarColorInvalid = "Araba rengi geçersiz.";
        public static string CarBrandInvalid = "Araba markası geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarCountOfBrandError = "Bir markada en fazla 10 araç olabilir.";

        public static string ImageAdded = "Resim eklendi";
        public static string ImageUpdated = "Resim güncellendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImageListed = "Resimler listelendi.";
        public static string ImageLimitExceded = "Görsel limiti aşıldığı için yeni görsel eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt Oldu.";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı.";
        public static string SuccessfulLogin = "Giriş Başarılı.";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token Oluşturuldu.";
    }
}
