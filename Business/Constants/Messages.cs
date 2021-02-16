using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string Added = "Ekleme İşlemi Başarılı";
        public static string Deleted = "Silme İşlemi Başarılı";
        public static string Updated = "Güncelleme İşlemi Başarılı";
        public static string BrandNameInvalid = "Marka bulunamadı!";
        public static string Listed = "Listeleme İşlemi Başarılı";
        internal static List<Car> MaintenanceTime;
    }
}
