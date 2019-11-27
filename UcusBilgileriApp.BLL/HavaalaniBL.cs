using Gazi.Sube1.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusBilgileriApp.MODELS;

namespace UcusBilgileriApp.BLL
{
   public class HavaalaniBL: IDisposable
    {
        Helper hlp = new Helper();

        public List<Havaalani> HavaalaniListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Id_Yer,Yer_Adi from tblKalkisVaris", null);
            List<Havaalani> lst = new List<Havaalani>();
            while (dr.Read())
            {
                lst.Add(new Havaalani { Id_Yer = dr["Id_Yer"].ToString(), Yer_Adi = dr["Yer_Adi"].ToString() });
            }
            lst.Insert(0, new Havaalani { Yer_Adi = "Havaalanı Seçiniz" });
            dr.Close();
            return lst;
        }



        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
