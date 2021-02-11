using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        public static string CarAdded = "Ekleme İşlemi Başarılı";
        public static string CarDeleted = "Silme İşlemi Başarılı";
        public static string CarUpdated = "Güncelleme İşlemi Başarılı";
        public static string BrandNameInvalid = "Marka bulunamadı!";
        internal static List<Car> MaintenanceTime;
    }
}
