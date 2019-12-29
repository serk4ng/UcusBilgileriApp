using UcusBilgileriApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
            SqlDataReader dr = hlp.ExecuteReader("spHavaalanlari", null);
            List<Havaalani> lst = new List<Havaalani>();
            while (dr.Read())
            {
                lst.Add(new Havaalani { Id_Yer = dr["Id_Yer"].ToString(), Yer_Adi = dr["Yer_Adi"].ToString() });
            }
            lst.Insert(0, new Havaalani { Yer_Adi = "Havaalanı Seçiniz" });
            dr.Close();
            return lst;
        }

        public List<Havaalani> HavaalaniDataGridListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("spHavaalanlari", null);
            List<Havaalani> lst = new List<Havaalani>();
            while (dr.Read())
            {
                lst.Add(new Havaalani { Id_Yer = dr["Id_Yer"].ToString(), Yer_Adi = dr["Yer_Adi"].ToString() });
            }       
            dr.Close();
            return lst;
        }


        public bool HavaalaniKaydet(Havaalani ha)
        {

            try
            {
                string cmdtext = "Insert into tblKalkisVaris values(@Id_Yer,@Yer_Adi)";

                SqlParameter[] p = { new SqlParameter("@Id_Yer", ha.Id_Yer), new SqlParameter("@Yer_Adi", ha.Yer_Adi) };
                return hlp.ExecuteNonQuery(cmdtext, p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool HavaalaniGuncelle(Havaalani ha)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Yer", ha.Id_Yer), new SqlParameter("@Yer_Adi", ha.Yer_Adi) };
                return hlp.ExecuteNonQuery("Update tblKalkisVaris set Id_Yer=@Id_Yer,Yer_Adi=@Yer_Adi Where Id_Yer=@Id_Yer", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Havaalani HavaalaniBul(string Id_Yer)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Yer", Id_Yer) };
                SqlDataReader dr = hlp.ExecuteReader("Select Id_Yer,Yer_Adi from tblKalkisVaris Where Id_Yer=@Id_Yer", p);
                Havaalani ha = null;

                if (dr.Read())
                {
                    ha = new Havaalani();
                    ha.Id_Yer = dr["Id_Yer"].ToString();
                    ha.Yer_Adi = dr["Yer_Adi"].ToString();

                }
                dr.Close();
                return ha;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool HavaalaniSil(string Id_Yer)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Yer", Id_Yer) };
                return hlp.ExecuteNonQuery("Delete from tblKalkisVaris where Id_Yer=@Id_Yer", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable HavaalanlariTable() => hlp.GetDataTable("spHavaalanlari");

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
