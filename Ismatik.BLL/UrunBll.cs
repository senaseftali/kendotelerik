using Ismatik.DAL;
using Ismatik.ENTİTY.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismatik.BLL
{
  public class UrunBll
    {
        UrunDal _urunDal;
        public UrunBll()
        {
          _urunDal = new UrunDal();
        }

        public List<UrunBilgileri> GetUrunBilgileris(string anahtarKelime, string SiteAdi)
        {


            return _urunDal.GetUrunBilgileri(anahtarKelime, SiteAdi); 
        }
        public List<UrunBilgileri> GetUrunFilter(string kelimeFilter, string SiteAdi,string anahtarKelime)
        {
           


            return _urunDal.GetUrunFilter(kelimeFilter, SiteAdi, anahtarKelime);
        }
        public bool UrunBilgileriEkle(List<UrunBilgileri> urunBilgileris)
        {


            return _urunDal.UrunEkle(urunBilgileris)>0; 
        }

    }
}

