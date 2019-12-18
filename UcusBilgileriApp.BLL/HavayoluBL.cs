using UcusBilgileriApp.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusBilgileriApp.MODELS;
using System.Data.Entity;

namespace UcusBilgileriApp.BLL
{
    public class HavayoluBL : IDisposable
    {
        Helper hlp = new Helper();

        public List<Havayolu> HavayoluListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Havayolu_Adi from tblHavayollari", null);
            List<Havayolu> lst = new List<Havayolu>();
            while (dr.Read())
            {
                lst.Add(new Havayolu { Id_Havayolu = dr["Id_Havayolu"].ToString(), Havayolu_Adi = dr["Havayolu_Adi"].ToString() });
            }
            lst.Insert(0, new Havayolu { Havayolu_Adi = "Havayolu Seçiniz" });
            dr.Close();
            return lst;
        }

        public void Kaydet(Havayolu ha)
        {
            try
            {
                // HATA: Yapılandırma Sistemi Başlatılamadı
                DtbUcusEntities ctx = new DtbUcusEntities();
                ctx.tblHavayollaris.Add(new tblHavayollari { Id_Havayolu = ha.Id_Havayolu, Havayolu_Adi = ha.Havayolu_Adi });
                ctx.SaveChanges();
                //string cmdtext = "Insert into tblHavayollari values(@Id_Havayolu,@Havayolu_Adi)";

                //SqlParameter[] p = { new SqlParameter("@Id_Havayolu", ha.Id_Havayolu), new SqlParameter("@Havayolu_Adi", ha.Havayolu_Adi) };
                //return hlp.ExecuteNonQuery(cmdtext, p) > 0;
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

        public void Guncelle(Havayolu ha)
        {
            try
            {
                using (DtbUcusEntities ctx = new DtbUcusEntities())
                {
                    tblHavayollari hbl = ctx.tblHavayollaris.Find(ha.Id_Havayolu);
                    hbl.Havayolu_Adi = ha.Havayolu_Adi;
                    ctx.Entry<tblHavayollari>(hbl).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
                //SqlParameter[] p = { new SqlParameter("@Id_Havayolu", ha.Id_Havayolu), new SqlParameter("@Havayolu_Adi", ha.Havayolu_Adi) };
                //return hlp.ExecuteNonQuery("Update tblHavayollari set Id_Havayolu=@Id_Havayolu,Havayolu_Adi=@Havayolu_Adi Where Id_Havayolu=@Id_Havayolu", p) > 0;
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

        public Havayolu HavayoluBul(string Id_Havayolu)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Havayolu", Id_Havayolu) };
                SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Havayolu_Adi from tblHavayollari Where Id_Havayolu=@Id_Havayolu", p);

                Havayolu ha = null;

                if (dr.Read())
                {
                    ha = new Havayolu();

                    ha.Id_Havayolu = dr["Id_Havayolu"].ToString();
                    ha.Havayolu_Adi = dr["Havayolu_Adi"].ToString();


                }
                dr.Close();
                return ha;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void HavayoluSil(string Id_Havayolu)
        {
            try
            {
                using (DtbUcusEntities ctx = new DtbUcusEntities())
                {
                    tblHavayollari hyl = ctx.tblHavayollaris.Find(Id_Havayolu);
                    ctx.tblHavayollaris.Remove(hyl);
                    ctx.SaveChanges();
                }


                //SqlParameter[] p = { new SqlParameter("@Id_Havayolu", Id_Havayolu) };
                //return hlp.ExecuteNonQuery("Delete from tblHavayollari where Id_Havayolu=@Id_Havayolu", p) > 0;
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

        public bool HavayoluEnvanterKaydet(Ucak u)
        {

            try
            {
                string cmdtext = "Insert into tblHavayoluEnvanter values(@Id_Havayolu,@Id_Ucak,@Adet)";

                SqlParameter[] p = { new SqlParameter("@Id_Havayolu", u.Id_Havayolu), new SqlParameter("@Id_Ucak", u.Id_Ucak), new SqlParameter("@Adet", u.Adet) };
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

        public bool EnvanterGuncelle(Ucak u)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Havayolu", u.Id_Havayolu), new SqlParameter("@Id_Ucak", u.Id_Ucak), new SqlParameter("@Adet", u.Adet) };
                return hlp.ExecuteNonQuery("Update tblHavayoluEnvanter set Adet=@Adet Where Id_Havayolu=@Id_Havayolu and Id_Ucak=@Id_Ucak", p) > 0;
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

        public Havayolu HavayoluEnvanterBul(string Id_Havayolu)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Havayolu", Id_Havayolu) };
                SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Id_Ucak,Adet from tblHavayoluEnvanter Where Id_Havayolu=@Id_Havayolu", p);
                Havayolu ha = null;
                Ucak u = null;

                if (dr.Read())
                {
                    u = new Ucak();
                    u.Id_Havayolu = dr["Id_Havayolu"].ToString();
                    u.Id_Ucak = dr["Id_Ucak"].ToString();
                    u.Adet = Convert.ToInt32(dr["Adet"]);

                }
                dr.Close();
                return ha;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool HavayoluEnvanterSil(string Id_Havayolu, string Id_Ucak)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Id_Havayolu", Id_Havayolu), new SqlParameter("@Id_Ucak", Id_Ucak) };
                return hlp.ExecuteNonQuery("Delete from tblHavayoluEnvanter where Id_Havayolu=@Id_Havayolu and Id_Ucak=@Id_Ucak", p) > 0;
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
        public DataTable HavayollariTable() => hlp.GetDataTable("Select * from tblHavayollari");
        public DataTable HavayollariEnvanterTable() => hlp.GetDataTable("Select hy.Havayolu_Adi, u.Ucak_Adi, he.[Adet],u.Id_Ucak,hy.Id_Havayolu,he.Id_Havayolu,he.Id_Ucak from tblHavayoluEnvanter he,tblHavayollari hy,tblUcak u where he.Id_Havayolu=hy.Id_Havayolu and he.Id_Ucak=u.Id_Ucak");

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }
}
