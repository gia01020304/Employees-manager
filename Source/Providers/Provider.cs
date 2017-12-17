using DA;
using project.DataObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace project.Provider
{

    public class Providers
    {
        public int test(params object[] Par)
        {
            string query = @"SELECT dbo.test(@macv)";
            return DataAccess.ExcuteScalar(query,true, Par);
        }

        public int ThemNhanVien(params object[] Par)
        {
            string query = @"	INSERT dbo.NhanVien
             		        ( Kh ,
             		          FName ,
             		          LName ,
             		          GioiTinh ,
             		          DOB ,
             		          HireDay ,
             		          QueQuan ,
             		          Id_PB ,
             		          Id_NQL ,
             		          Kh_NQL ,
             		          Id_CV
             		        )
             		VALUES  (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11 )";
            return DataAccess.ExcuteNonQuery(query, Par); 
           
        }

        public DataSet TimKiem(params object[] Par)
        {
            string query = @"SELECT  Id,FName ,LName,GioiTinh,DOB,QueQuan FROM dbo.NhanVien

                        WHERE Id LIKE @p1 OR FName  LIKE @p1 OR LName  LIKE @p1 OR GioiTinh  LIKE @p1  OR DOB  LIKE @p1

                        OR QueQuan  LIKE @p1  OR HireDay  LIKE @p1  OR Id_CV  LIKE @p1  OR Id_NQL  LIKE @p1 OR Kh  LIKE @p1 ";
            return DataAccess.ExcuteQuery(query, Par);
        }

        public int UpdateThongTin(params object[] Par)
        {
            string query = @"UPDATE dbo.Admin
                        SET UserName=@p1,
	                        PassWord=@p2,
	                        FullName=@p3
	                        WHERE UserName=@p4";
    
            return DataAccess.ExcuteNonQuery(query,Par);

        }

        public SqlDataReader GetNhanVienDTO(object Id)
        {
            string query = @"SELECT *FROM dbo.NhanVien
                             WHERE dbo.NhanVien.Id = @p1";
            return DataAccess.GetDataDTO(query,Id);
        }

        public int GetIDNV()
        {
            string query = @"SELECT IDENT_CURRENT('NhanVien')";
            return DataAccess.ExcuteScalar(query,false);
        }

        public SqlDataReader GetPhongBan(params object[] Par)
        {

            string query = @"SELECT dbo.PhongBan.NamePB ,dbo.PhongBan.KyHieu,dbo.ChucVu.Id AS idcv,dbo.ChucVu.Name
                            FROM dbo.PhongBan,dbo.ChucVu,dbo.PhongBan_ChucVu
                            WHERE dbo.PhongBan.Id=@mbp
                                    AND dbo.PhongBan.Id=dbo.PhongBan_ChucVu.Id_PB
                                    AND dbo.PhongBan_ChucVu.Id_CV=dbo.ChucVu.Id ";
            return DataAccess.GetDataDTO( query, Par);

        }

        public int ThemThanNhan(params object[]Par)
        {
            string query = @"INSERT dbo.ThanNhan
                    ( Id_NV, Kh_NV , NameTN, DOB,QuanHe )
                    VALUES(@p1,@p2,@p3,@p4,@p5) ";
            return DataAccess.ExcuteNonQuery(query, Par);
        }

        public int UpdateDataSet(DataSet ds,params object[] Par)
        {
           
            string query = @"SELECT NameTN N'Tên Thân Nhân',DOB N'Ngày Sinh',QuanHe N'Quan Hệ'
                                    FROM @p1
                                    WHERE Id_NV=@p2 ";
            return DataAccess.UpdateDataSet(query,ds, Par);
        }

        public DataSet GetThanNhan(params object[] par)
        {
            string query = @"SELECT NameTN N'Tên Thân Nhân',DOB N'Ngày Sinh',QuanHe N'Quan Hệ'
                                                FROM dbo.ThanNhan
                                                WHERE Id_NV=@p1";
            return DataAccess.ExcuteQuery(query, par);
        }

        public SqlDataReader GetChucVu(object[] Par)
        {
            string query = @"SELECT Id,NameCV FROM dbo.ChucVu,dbo.PhongBan_ChucVu
                           WHERE Id=dbo.PhongBan_ChucVu.Id_CV AND Id_PB=@mpb  ";
            return DataAccess.GetDataDTO( query, Par);
        }

        public int EditNhanVien(params object[] Par)
        {
                string query = @"UPDATE	dbo.NhanVien
							  SET 
                              Kh=@p1 ,
             		          FName=@p2 ,
             		          LName=@p3 ,
             		          GioiTinh=@p4 ,
             		          DOB=@p5 ,
             		          HireDay=@p6 ,
             		          QueQuan=@p7 ,
             		          Id_PB=@p8,
             		          Id_NQL=@p9 ,
             		          Kh_NQL=@p10 ,
             		          Id_CV=@p11
                        WHERE Id=@p12";
            return DataAccess.ExcuteNonQuery(query, Par);
        }

        public int XoaNhanVien(object id)
        {
            string query = @"DELETE FROM dbo.NhanVien
						WHERE dbo.NhanVien.Id=@p1";
            return DataAccess.ExcuteNonQuery(query,id);
        }

        public SqlDataReader GetAdmin(params object[] Par)
        {

            string query = @"SELECT *FROM dbo.Admin WHERE UserName= @UN AND PassWord= @PW ";
            return DataAccess.GetDataDTO( query, Par);

        }
        public int KiemTra(params object[] Par)
        {
            string query = @"SELECT dbo.KiemTra( @US )";
            return DataAccess.ExcuteScalar( query,true, Par);
        }

        public int LuuThongTin(params object[] Par)
        {
            string query = @"INSERT dbo.ADMIN
            ( UserName, PassWord, FullName )
             VALUES  ( @un , @pw, @adname)";
            return DataAccess.ExcuteNonQuery( query, Par);
        }
        public DataSet GetNhanVien(params object[] Par)
        {
            string query = @"SELECT  Id,FName ,LName,GioiTinh,DOB,QueQuan FROM	dbo.NhanVien
		                WHERE Id_PB=@pb1 or Id_PB = @pb2 ";
            return DataAccess.ExcuteQuery( query, Par);
        }
        public DataSet Xuat(params object[] Par)
        {
            string query = @"SELECT  ID,FName ,LName,GioiTinh,DOB,QueQuan FROM	dbo.NhanVien
		                WHERE MaPB=@pb1 or MaPB =@pb2 ";
            return DataAccess.ExcuteQuery( query, Par);
        }

    }
}

//string query = @"INSERT dbo.NhanVien
//        ( KH ,
//          FName ,
//          LName ,
//          GioiTinh ,
//          DOB ,
//          HD ,
//          QueQuan ,
//          MaPB ,
//          MaCV ,
//          ID_NQL ,
//          KH_NQL
//        )
//VALUES  ( @kh ,
//          @fn, 
//          @fl , 
//          @sex ,
//          @dt1 , 
//          @dt2 ,
//          @qq ,
//          @mpb ,
//          @mcv ,
//          @idql , 
//          @khql  
//        )";