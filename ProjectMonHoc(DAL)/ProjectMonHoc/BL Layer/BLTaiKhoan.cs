﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectMonHoc.DTO;
using ProjectMonHoc.EntityModel;
namespace ProjectMonHoc.BL_Layer
{
    class BLTaiKhoan
    {
        private static BLTaiKhoan instance;
        public static BLTaiKhoan Instance
        {
            get { if (instance == null) instance = new BLTaiKhoan(); return instance; }
            private set { instance = value; }
        }

        public byte checkLogin (string taikhoan, string matkhau)
        {
            DBMain db = new DBMain();
            //tk = (from TK in qlCF.TAIKHOANs
            //               where TK.TaiKhoan1 == taikhoan && TK.MatKhau == matkhau
            //               select TK).SingleOrDefault();
            string query = "Select * From TAIKHOAN Where TaiKhoan = '"
                + taikhoan + "' And MatKhau = '"
                + matkhau + "'";
            var tk = db.ExecuteQueryDataSet(query, CommandType.Text);
            if (tk == null)
                return 0;
            if (tk != null) return 1;
            return 0;
        }
        public string LayIDNhanVien(string taikhoan)
        {
            //QuanLyNhaHangProjectEntities qlCF = new QuanLyNhaHangProjectEntities();
            //TAIKHOAN tk = (from TK in qlCF.TAIKHOANs
            //             where TK.TaiKhoan1 == taikhoan
            //             select TK).SingleOrDefault();
            //if (tk != null)   
            //    return tk.IDNhanVien;

            DBMain db = new DBMain();
            string query = "Select IDNhanVien From TAIKHOAN Where TaiKhoan = '" + taikhoan + "'";
            return db.ExecuteQueryDataSet(query,CommandType.Text).Rows[0][0].ToString();
        }
        
        public bool DoiMatKhau(string oldPass, string newPass, string idNhanVien)
        {
            //QuanLyNhaHangProjectEntities ql = new QuanLyNhaHangProjectEntities();
            //var query = ql.TAIKHOANs.Where(x => x.IDNhanVien == idNhanVien).SingleOrDefault();
            //if(query != null)
            //{
            //    if (query.MatKhau == oldPass)
            //    {
            //        query.MatKhau = newPass;
            //        ql.SaveChanges();
            //    }
            //    else return false;
            //}

            DBMain db = new DBMain();
            string f = "";
            string query = "Select * from TAIKHOAN Where IDNhanVien = '" + idNhanVien + "' And MatKhau = '" + oldPass + "'";
            if (db.ExecuteQueryDataSet(query,CommandType.Text).Rows.Count >=1)
            {
                query = "Update TAIKHOAN Set MatKhau = '" + newPass + "' Where IDNhanVien = '" + idNhanVien + "' And MatKhau = '" + oldPass + "'";
                return db.MyExecuteNonQuery(query, CommandType.Text, ref f);
            }    
            else
                return false;
        }
    }
}
