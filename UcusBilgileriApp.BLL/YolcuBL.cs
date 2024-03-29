﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcusBilgileriApp.DAL;
using UcusBilgileriApp.MODELS;

namespace UcusBilgileriApp.BLL
{
    public class YolcuBL : IDisposable
    {
        Helper hlp = new Helper();

        public List<Yolcu> YolcuListesi()
        {
            SqlDataReader dr = hlp.ExecuteReader("spYolcular", null);
            List<Yolcu> lst = new List<Yolcu>();

            while (dr.Read())
            {
                lst.Add(new Yolcu { Ad = dr["Ad"].ToString(), Soyad = dr["Soyad"].ToString(), Ucus_Numarasi = dr["Ucus_Numarasi"].ToString(), Koltuk_No = dr["Koltuk_No"].ToString() });
            }
            lst.Insert(0, new Yolcu { Ad = "Ad Seçiniz", Soyad = "Soyad Seçiniz", Ucus_Numarasi = "Ucus Numarasi Seçiniz" });
            dr.Close();
            return lst;
        }

        public List<Yolcu> YolcuListesi(string Ad,string Soyad)
        {
            SqlParameter[] p = { new SqlParameter("@Ad", Ad), new SqlParameter("@Soyad", Soyad) };
            //SqlDataReader dr = hlp.ExecuteReader("Select Id_Havayolu,Id_Ucak,Adet from tblHavayoluEnvanter where Id_Havayolu=@Id_Havayolu", p);
            SqlDataReader dr = hlp.ExecuteReader("Select Ad,Soyad,Ucus_Numarasi,Koltuk_No from tblYolcular where Ad=@Ad and Soyad=@Soyad ", p);
            List<Yolcu> lst = new List<Yolcu>();

            while (dr.Read())
            {
                lst.Add(new Yolcu { Ad = dr["Ad"].ToString(), Soyad = dr["Soyad"].ToString(), Ucus_Numarasi = dr["Ucus_Numarasi"].ToString(), Koltuk_No = dr["Koltuk_No"].ToString() });
            }
           
            dr.Close();
            return lst;
        }


        public bool YolcuKaydet(Yolcu y)
        {
            try
            {
                string cmdtext = "Insert into tblYolcular values(@Ad,@Soyad,@Ucus_Numarasi,@Koltuk_No)";

                SqlParameter[] p = { new SqlParameter("@Ad", y.Ad), new SqlParameter("@Soyad", y.Soyad), new SqlParameter("@Ucus_Numarasi", y.Ucus_Numarasi), new SqlParameter("@Koltuk_No", y.Koltuk_No) };
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

        public bool YolcuGuncelle(Yolcu y)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", y.Ad), new SqlParameter("@Soyad", y.Soyad), new SqlParameter("@Ucus_Numarasi", y.Ucus_Numarasi), new SqlParameter("@Koltuk_No", y.Koltuk_No) };
                return hlp.ExecuteNonQuery("Update tblYolcular set Ucus_Numarasi=@Ucus_Numarasi , Koltuk_No=@Koltuk_No Where Ad=@Ad and Soyad=@Soyad", p) > 0;
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

        public Yolcu YolcuBul(string Ad,string Soyad)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", Ad), new SqlParameter("@Soyad", Soyad) };
                SqlDataReader dr = hlp.ExecuteReader("Select Ad,Soyad,Ucus_Numarasi,Koltuk_No from tblYolcular Where Ad=@Ad and Soyad=@Soyad ", p);
                Yolcu y = null;

                if (dr.Read())
                {
                    y = new Yolcu();
                    y.Ad = dr["Ad"].ToString();
                    y.Soyad = dr["Soyad"].ToString();
                    y.Ucus_Numarasi = dr["Ucus_Numarasi"].ToString();
                    y.Koltuk_No = dr["Koltuk_No"].ToString();

                }
                dr.Close();
                return y;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool YolcuSil(string Ad,string Soyad)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Ad", Ad), new SqlParameter("@Soyad", Soyad) };
                return hlp.ExecuteNonQuery("Delete from tblYolcular where Ad=@Ad and Soyad=@Soyad ", p) > 0;
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

        public DataTable YolcuTable() => hlp.GetDataTable("spYolcular");

        public void Dispose()
        {
            ((IDisposable)hlp).Dispose();
        }
    }

}
