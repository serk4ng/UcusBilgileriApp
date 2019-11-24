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
    public class HavayoluBL: IDisposable
    {
        Helper hlp = new Helper();

        public List<Havayolu>HavayoluListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Havayolu_Adi from tblHavayollari", null);
             List<Havayolu> lst = new  List<Havayolu>();
            while (dr.Read())
            {
                lst.Add(new Havayolu { Id_Havayolu = dr["Id_Havayolu"].ToString(), Havayolu_Adi = dr["Havayolu_Adi"].ToString() });
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
