using UcusBilgileriApp.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusBilgileriApp.MODELS;

namespace UcusBilgileriApp.BLL
{
    public class UcakBL:IDisposable
    {
        Helper hlp = new Helper();

        public List<Ucak> UcakListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Id_Ucak,Ucak_Adi,Yolcu_Sayisi from tblUcak", null);
            List<Ucak> lst = new List<Ucak>();
            while (dr.Read())
            {
                lst.Add(new Ucak { Id_Ucak = dr["Id_Ucak"].ToString(), Ucak_Adi = dr["Ucak_Adi"].ToString(), Yolcu_Sayisi = Convert.ToInt32(dr["Yolcu_Sayisi"]) });
            }
            lst.Insert(0, new Ucak { Ucak_Adi = "Uçak Seçiniz" });
            dr.Close();
            return lst;
        }


        public List<Ucak> HavayoluEnvanterListesi(string Id_Havayolu)
        {
            SqlParameter[] p = { new SqlParameter("@Id_Havayolu", Id_Havayolu) };
            //SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Id_Ucak,Adet from tblHavayoluEnvanter where Id_Havayolu=@Id_Havayolu", p);
            SqlDataReader dr = hlp.ExecuteReader("Select e.Id_Havayolu,e.Id_Ucak,e.Adet,u.Ucak_Adi from tblHavayoluEnvanter e,tblUcak u where e.Id_Havayolu=@Id_Havayolu and e.Id_Ucak=u.Id_Ucak ", p);
            List<Ucak> lst = new List<Ucak>();
           
            while (dr.Read())
            {
                lst.Add(new Ucak { Id_Havayolu = dr["Id_Havayolu"].ToString(), Id_Ucak = dr["Id_Ucak"].ToString(), Ucak_Adi = dr["Ucak_Adi"].ToString(), Adet = Convert.ToInt32(dr["Adet"])});
            }
            dr.Close();
            return lst;
        }


        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
