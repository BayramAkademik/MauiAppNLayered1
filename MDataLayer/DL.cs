using MEntityLayer;

using System.Collections.ObjectModel;

namespace MDataLayer
{
    // All the code in this file is included in all platforms.
    public static class DL
    {
        /// <summary>
        /// Veritabanına müşteri ekler.
        /// </summary>
        /// <param name="m">Müşteri</param>
        /// <param name="mesaj">Eğer hata oluşursa hata mesajını buradan alın</param>
        /// <returns>Başarılı olursa true, aksi halde false</returns>
        public static bool MusteriEkle(Musteri m, ref string mesaj)
        {
            //mesaj = "Hops arkadaş, daha veri tabanı yok ki!";
            return true;
        }

        /// <summary>
        /// Veritabanındaki müşteriyi günceller.
        /// </summary>
        /// <param name="m">Müşteri</param>
        /// <param name="mesaj">Eğer hata oluşursa hata mesajını buradan alın</param>
        /// <returns>Başarılı olursa true, aksi halde false</returns>
        public static bool MusteriDuzenle(Musteri m, ref string mesaj)
        {
            return true;
        }

        /// <summary>
        /// Veritabanındaki müşteriyi siler.
        /// </summary>
        /// <param name="m">Müşteri</param>
        /// <param name="mesaj">Eğer hata oluşursa hata mesajını buradan alın</param>
        /// <returns>Başarılı olursa true, aksi halde false</returns>
        public static bool MusteriSil(Musteri m, ref string mesaj)
        {
            return true;
        }

        /// <summary>
        /// Veritabanından müşterileri yükler.
        /// </summary>
        /// <param name="mesaj">Eğer hata oluşursa hata mesajını buradan alın</param>
        /// <returns>Müşretilerin listesi</returns>
        public static ObservableCollection<Musteri> MusterileriYukle(ref string mesaj)
        {
            return new ObservableCollection<Musteri>();

            
        }
    }
}
