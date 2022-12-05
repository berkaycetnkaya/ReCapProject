using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants.Messages
{
    public static class Messages
    {
        public static string UserRegistered="Kullanıcı kayıt edildi";
        public static string UserNotFound = " Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Bararıyla giriş yapıldı";
        public static string UserAlreadyExists="Kullanıcı zaten kayıtlı";
        public static string AccessTokenCreated="Giriş tokeni oluşturuldu";
    }
}
