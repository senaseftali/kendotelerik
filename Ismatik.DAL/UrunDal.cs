using Ismatik.ENTİTY;
using Ismatik.ENTİTY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;
namespace Ismatik.DAL
{
  public class UrunDal
    {
        IsmatikEntities db;
        public UrunDal()
        {
             db = new IsmatikEntities();
        }
        public int UrunEkle(List<UrunBilgileri> urunBilgileris )
        {
            db.UrunBilgileris.AddRange(urunBilgileris);
            return db.SaveChanges();
        }

        public List<UrunBilgileri> GetUrunBilgileri(string anahtarKelime,string SiteAdi)
        {
            return db.UrunBilgileris.Where(a => a.anahtarKelime == anahtarKelime && a.SiteAdi== SiteAdi).OrderByDescending(a=>a.UrunID).ToList();
        }
     
        public List<UrunBilgileri> GetUrunFilter(string kelimeFilter, string SiteAdi, string anahtarKelime)
        {
         
       
            return db.UrunBilgileris.Where(a => a.UrunAdi.Contains(kelimeFilter) && a.anahtarKelime == anahtarKelime && a.SiteAdi == SiteAdi).OrderByDescending(a => a.UrunID).ToList();
        }

       

    }
}
