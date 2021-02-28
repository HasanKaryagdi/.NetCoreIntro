using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //Hiçbir sınıfı çıplak bırakmıcaz
    //Mikro servis
    //GErçek sistemlerde ürün alışverişi yapırken test ederken sahte yapılarla çalışılır
    //gamermanagerin doğrulama servisi kullanıcam
    class GamerManager : IGamerService
    {
        private IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine("Kayıt Olundu");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
