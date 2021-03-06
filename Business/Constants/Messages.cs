﻿using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public  static string ProductCountOfCategoryError = "En fazla 10 ürün olabilir aynı kategoriden";
        public  static string ProductNameAlreadyExist = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExcededError = "Category limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered ="";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError ="Şifre yanlış";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists ="Kullanıcı önceden kaydolmuş";
        public static string AccessTokenCreated ="Token oluştruldu";
    }
}

