
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
    public class UcusBL
    {
        Helper hlp = new Helper();
        public bool Kaydet(Ucus ucs)
        {
            
            try
            {
                string cmdtext = "Insert into tblUcusBilgileri values(@Ucus_Numarasi, @Id_Havayolu, @Kalkis_Yeri_Id, @Varis_Yeri_Id, @Kalkis_Tarih, @Kalkis_Saat, @Varis_Tarih, @Varis_Saat, @Tahmini_Sure, @Id_Ucak)";

                SqlParameter[] p = {  new SqlParameter("@Ucus_Numarasi", ucs.Ucus_Numarasi), new SqlParameter("@Id_Havayolu", ucs.Id_Havayolu),
                new SqlParameter("@Kalkis_Yeri_Id", ucs.Kalkis_Yeri_Id),new SqlParameter("@Varis_Yeri_Id", ucs.Varis_Yeri_Id),new SqlParameter("@Kalkis_Tarih", ucs.Kalkis_Tarih),
                new SqlParameter("@Kalkis_Saat", ucs.Kalkis_Saat),new SqlParameter("@Varis_Tarih", ucs.Varis_Tarih),new SqlParameter("@Varis_Saat", ucs.Varis_Saat),
                new SqlParameter("@Tahmini_Sure", ucs.Tahmini_Sure),new SqlParameter("@Id_Ucak", ucs.Id_Ucak) };
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

        public bool Guncelle(Ucus ucs)
        {
            try
            {
                SqlParameter[] p = {new SqlParameter("@Ucus_Numarasi", ucs.Ucus_Numarasi),new SqlParameter("@Id_Havayolu", ucs.Id_Havayolu),
                new SqlParameter("@Kalkis_Yeri_Id", ucs.Kalkis_Yeri_Id),new SqlParameter("@Varis_Yeri_Id", ucs.Varis_Yeri_Id),new SqlParameter("@Kalkis_Tarih", ucs.Kalkis_Tarih),
                new SqlParameter("@Kalkis_Saat", ucs.Kalkis_Saat),new SqlParameter("@Varis_Tarih", ucs.Varis_Tarih),new SqlParameter("@Varis_Saat", ucs.Varis_Saat),
                new SqlParameter("@Tahmini_Sure", ucs.Tahmini_Sure),new SqlParameter("@Id_Ucak", ucs.Id_Ucak) };
                return hlp.ExecuteNonQuery("Update tblUcusBilgileri set Id_Havayolu=@Id_Havayolu,Kalkis_Yeri_Id=@Kalkis_Yeri_Id,Varis_Yeri_Id=@Varis_Yeri_Id,Kalkis_Tarih=@Kalkis_Tarih,Kalkis_Saat=@Kalkis_Saat,Varis_Tarih=@Varis_Tarih,Varis_Saat=@Varis_Saat,Tahmini_Sure=@Tahmini_Sure,Id_Ucak=@Id_Ucak Where Ucus_Numarasi=@Ucus_Numarasi", p) > 0;
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

        public Ucus UcusBul(string Ucus_Numarasi)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ucus_Numarasi", Ucus_Numarasi) };
                SqlDataReader dr = hlp.ExecuteReader("Select Ucus_Numarasi,Id_Havayolu,Kalkis_Yeri_Id,Varis_Yeri_Id,Kalkis_Tarih,Kalkis_Saat,Varis_Tarih,Varis_Saat,Tahmini_Sure,Id_Ucak from tblUcusBilgileri Where Ucus_Numarasi=@Ucus_Numarasi", p);
                Ucus u = null;

                if (dr.Read())
                {
                    u = new Ucus();
                    u.Ucus_Numarasi = dr["Ucus_Numarasi"].ToString();
                    u.Id_Havayolu = dr["Id_Havayolu"].ToString();
                    u.Kalkis_Yeri_Id = dr["Kalkis_Yeri_Id"].ToString();                 
                    u.Varis_Yeri_Id = dr["Varis_Yeri_Id"].ToString();     
                    u.Kalkis_Tarih =Convert.ToDateTime(dr["Kalkis_Tarih"].ToString());
                    u.Kalkis_Saat = TimeSpan.Parse(dr["Kalkis_Saat"].ToString());
                    u.Varis_Tarih = Convert.ToDateTime(dr["Varis_Tarih"]);
                    u.Varis_Saat = TimeSpan.Parse(dr["Varis_Saat"].ToString());
                    u.Tahmini_Sure = TimeSpan.Parse(dr["Tahmini_Sure"].ToString());
                    u.Id_Ucak = dr["Id_Ucak"].ToString();

                }
                dr.Close();
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UcusSil(string Ucus_Numarasi)
        {
            SqlParameter[] p = { new SqlParameter("@Ucus_Numarasi", Ucus_Numarasi) };
            return hlp.ExecuteNonQuery("Delete from tblUcusBilgileri where Ucus_Numarasi=@Ucus_Numarasi", p) > 0;
        }

        public void Dispose()
        {
            hlp.Dispose();
        }
    }
}
