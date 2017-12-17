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
        public DataSet GetNhanVien2(params object[] Par)
        {
            string query = @"SELECT  Id,Kh,FName ,LName FROM	dbo.NhanVien
		                WHERE Id_PB=@p1 AND Id_CV=@p2 ";
           
            return DataAccess.ExcuteQuery(query, Par);
        }
        public int ThemNVKTKL(params object[] Par)
        {
            string query = @"INSERT NV_KTKL
             		        ( Id_KTKL ,
             		          Id_NV ,
             		          Kh_NV
             		        )
             		VALUES  (@p1,@p2,@p3)";
            
            return DataAccess.ExcuteNonQuery(query, Par);
        }
        public SqlDataReader GetChucVuDTO(object Id)
        {
            string query = @"SELECT Id,Name,Id_PB FROM ChucVu,PhongBan_ChucVu
                             WHERE Id_CV=ChucVu.Id AND Id_PB=@p1";
           
            return DataAccess.GetDataDTO(query, Id);
        }
        public int XoaKTKLNV(object id1, object id2)
        {
            string query = @"DELETE FROM NV_KTKL
						WHERE Id_NV=@p1 AND ID_KTKL=@p2";
           
            return DataAccess.ExcuteNonQuery(query, id1, id2);
        }
        public int XoaKTKL(object id)
        {
            string query = @"DELETE FROM KTKL
						WHERE Id=@p1";
          
            return DataAccess.ExcuteNonQuery(query, id);
        }
        public int EditKTKL(params object[] Par)
        {
            string query = @"UPDATE	KTKL
							  SET 
                             NameKTKL=@p1,
                             HinhThuc=@p2,
                              Money=@p3
                        WHERE Id=@p4";
           
            return DataAccess.ExcuteNonQuery(query, Par);
        }
        public DataSet GetKTKLNV1(params object[] Par)
        {
            string query = @"Select	NhanVien.Id,Kh,FName,LName,KTKL.Id,KTKL.NameKTKL,KTKL.HinhThuc,KTKL.Money FROM NhanVien,KTKL,NV_KTKL WhERE KTKL.Id=NV_KTKL.Id_KTKL AND NhanVien.Id=NV_KTKL.Id_NV AND Kh=NV_KTKL.Kh_NV";
           
            return DataAccess.ExcuteQuery(query, Par);
        }
        public DataSet GetKTKL(params object[] Par)
        {
            string query = @"SElect * From KTKL";
            return DataAccess.ExcuteQuery(query, Par);
        }
        public int ThemKTKL(params object[] Par)
        {
            string query = @"INSERT KTKL
             		        ( NameKTKL ,
             		          HinhThuc ,
             		          Money 
             		        )
             		VALUES  (@p1,@p2,@p3)";
          
            return DataAccess.ExcuteNonQuery(query, Par);
        }
        public int EditSalary(params object[] Par)
        {
            string query = @"UPDATE	MucLuong
							  SET 
                             Money=@p1
                        WHERE Id=@p2";

            return DataAccess.ExcuteNonQuery(query, Par);
        }
        public DataSet GetSalary(params object[] Par)
        {
            string query = @"SElect * From MucLuong";
            return DataAccess.ExcuteQuery(query, Par);
        }
        public DataSet GetTablesaCV(params object[] Par)
        {
            string query = @"SELECT Id_PB ,ChucVu.Id as 'ID Chức vụ',Name as 'Chức vụ',MucLuong.Id as 'Mức lương',Money as 'Số tiền' FROM MucLuong,ChucVu,PhongBan_ChucVu
                               Where Id_ML=MucLuong.Id AND Id_CV=ChucVu.Id";

            return DataAccess.ExcuteQuery(query, Par);
        }
        public int DemRecord(params object[] Par)
        {
            string query = @"SELECT COUNT(*) FROM dbo.NhanVien
                        WHERE dbo.NhanVien.Id_PB=@p1";
            return DataAccess.ExcuteScalar(query, true, Par);
        }
        public int test(params object[] Par)
        {
            string query = @"SELECT dbo.test(@macv)";
            return DataAccess.ExcuteScalar(query, true, Par);
        }

        public DataSet GetKTKLNV(params object[] Par)
        {
            string query = @"SElect NameKTKL,HinhThuc,Money From KTKL,NV_KTKL 
                                Where Id_NV=@p1 AND Kh_NV=@p2 AND Id_KTKL=Id";

            return DataAccess.ExcuteQuery(query, Par);
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

        public DataSet TimKiem(int model, int MaPB, int MaCV, string Info)
        {

            object[] Par = null;
            string query = "";
            switch (model)
            {
                case 1:
                    query = @"select TOP (500) Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1  AND	(Id LIKE @p3 OR FName  LIKE @p3 OR LName  LIKE @p3 OR GioiTinh  LIKE @p3  OR DOB  LIKE @p3
                        OR QueQuan  LIKE @p3  OR HireDay  LIKE @p3  OR Id_CV  LIKE @p3  OR Id_NQL  LIKE @p3 OR Kh  LIKE @p3 ) ";
                    Par = new object[] { MaPB, Info };
                    break;
                case 2:
                    query = @"select TOP (500) Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1  AND	dbo.NhanVien.Id_CV=@p2 ";
                    Par = new object[] { MaPB, MaCV };
                    break;
                case 3:
                    query = @"select TOP (500) Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1 AND	dbo.NhanVien.Id_CV=@p2 AND	(Id LIKE @p3 OR FName  LIKE @p3 OR LName  LIKE @p3 OR GioiTinh  LIKE @p3  OR DOB  LIKE @p3
                        OR QueQuan  LIKE @p3  OR HireDay  LIKE @p3  OR Id_CV  LIKE @p3  OR Id_NQL  LIKE @p3 OR Kh  LIKE @p3 ) ";
                    Par = new object[] { MaPB, MaCV, Info };
                    break;
            }
            return DataAccess.ExcuteQuery(query, Par);

        }
        public DataSet TimKiem1(params object[] Par)
        {
            string query = @"select Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1 AND	dbo.NhanVien.Id_CV=@p2 AND	(Id LIKE @p3 OR FName  LIKE @p3 OR LName  LIKE @p3 OR GioiTinh  LIKE @p3  OR DOB  LIKE @p3
                        OR QueQuan  LIKE @p3  OR HireDay  LIKE @p3  OR Id_CV  LIKE @p3  OR Id_NQL  LIKE @p3 OR Kh  LIKE @p3 ) ";
            return DataAccess.ExcuteQuery(query, Par);
        }
        public DataSet TimKiem2(params object[] Par)
        {
            string query = @"select Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1  AND	(Id LIKE @p3 OR FName  LIKE @p3 OR LName  LIKE @p3 OR GioiTinh  LIKE @p3  OR DOB  LIKE @p3
                        OR QueQuan  LIKE @p3  OR HireDay  LIKE @p3  OR Id_CV  LIKE @p3  OR Id_NQL  LIKE @p3 OR Kh  LIKE @p3 ) ";
            return DataAccess.ExcuteQuery(query, Par);
        }
        public DataSet TimKiem3(params object[] Par)
        {
            string query = @"select Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                     WHERE dbo.NhanVien.Id_PB=@p1  AND	dbo.NhanVien.Id_CV=@p2 ";
            return DataAccess.ExcuteQuery(query, Par);
        }

        public int UpdateThongTin(params object[] Par)
        {
            string query = @"UPDATE dbo.Admin
                        SET UserName=@p1,
	                        PassWord=@p2,
	                        FullName=@p3,
                            DOB =@p4,
                            PhoneNumber=@p5 ,
                            Sex=@p6
	                        WHERE UserName=@p7";

            return DataAccess.ExcuteNonQuery(query, Par);
        }



        public SqlDataReader GetNhanVienDTO(object Id)
        {
            string query = @"SELECT *FROM dbo.NhanVien
                             WHERE dbo.NhanVien.Id = @p1";
            return DataAccess.GetDataDTO(query, Id);
        }

        public int GetIDNV()
        {
            string query = @"SELECT IDENT_CURRENT('NhanVien')";
            return DataAccess.ExcuteScalar(query, false);
        }

        public SqlDataReader GetPhongBan(params object[] Par)
        {

            string query = @"SELECT dbo.PhongBan.NamePB ,dbo.PhongBan.KyHieu,dbo.ChucVu.Id AS idcv,dbo.ChucVu.Name
                            FROM dbo.PhongBan,dbo.ChucVu,dbo.PhongBan_ChucVu
                            WHERE dbo.PhongBan.Id=@mbp
                                    AND dbo.PhongBan.Id=dbo.PhongBan_ChucVu.Id_PB
                                    AND dbo.PhongBan_ChucVu.Id_CV=dbo.ChucVu.Id ";
            return DataAccess.GetDataDTO(query, Par);

        }

        public int ThemThanNhan(params object[] Par)
        {
            string query = @"INSERT dbo.ThanNhan
                    ( Id_NV, Kh_NV , NameTN, DOB,QuanHe )
                    VALUES(@p1,@p2,@p3,@p4,@p5) ";
            return DataAccess.ExcuteNonQuery(query, Par);
        }

        public int UpdateDataSet(DataSet ds, params object[] Par)
        {

            string query = string.Format("SELECT *FROM	{0}", ds.Tables[0].TableName);
            return DataAccess.UpdateDataSet(query, ds, Par);
        }

        public DataSet GetThanNhan(params object[] par)
        {
            //             string query = @"SELECT NameTN N'Tên Thân Nhân',DOB N'Ngày Sinh',QuanHe N'Quan Hệ'
            //                                                 FROM dbo.ThanNhan
            //                                                 WHERE Id_NV=@p1";
            string query = @"SELECT *
                                FROM dbo.ThanNhan
                                WHERE dbo.ThanNhan.Id_NV = @p1";
            return DataAccess.ExcuteQuery(query, par);
        }

        public int XoaThanNhan(params object[] par)
        {
            string query = @" DELETE FROM dbo.ThanNhan 
		                            WHERE Id_NV=@p1";
            return DataAccess.ExcuteNonQuery(query, par);
        }

        public SqlDataReader GetChucVu(object[] Par)
        {
            string query = @"SELECT Id,NameCV FROM dbo.ChucVu,dbo.PhongBan_ChucVu
                           WHERE Id=dbo.PhongBan_ChucVu.Id_CV AND Id_PB=@mpb  ";
            return DataAccess.GetDataDTO(query, Par);
        }

        public DataSet GetNhanVienPT(int FirstRow, int PageSize, string nameTable, params object[] Par)
        {
            string query = @"select Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                        WHERE dbo.NhanVien.Id_PB=@p1";
            return DataAccess.ExcuteQuery2(query, FirstRow, PageSize, nameTable, Par);
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
            return DataAccess.ExcuteNonQuery(query, id);
        }

        public SqlDataReader GetAdmin(params object[] Par)
        {

            string query = @"SELECT *FROM dbo.Admin WHERE UserName= @UN AND PassWord= @PW ";
            return DataAccess.GetDataDTO(query, Par);

        }
        public int KiemTra(params object[] Par)
        {
            string query = @"SELECT dbo.KiemTra( @US )";
            return DataAccess.ExcuteScalar(query, true, Par);
        }

        public int LuuThongTin(params object[] Par)
        {
            string query = @"INSERT dbo.ADMIN
            ( UserName, PassWord, FullName )
             VALUES  ( @un , @pw, @adname)";
            return DataAccess.ExcuteNonQuery(query, Par);
        }
        public DataSet GetNhanVien(params object[] Par)
        {
            string query = @"SELECT  Id,FName ,LName,GioiTinh,DOB,QueQuan FROM	dbo.NhanVien
		                WHERE Id_PB=@pb1 or Id_PB = @pb2 ";
            return DataAccess.ExcuteQuery(query, Par);
        }
        public DataSet Xuat(params object[] Par)
        {
            string query = @"SELECT  ID,FName ,LName,GioiTinh,DOB,QueQuan FROM	dbo.NhanVien
		                WHERE MaPB=@pb1 or MaPB =@pb2 ";
            return DataAccess.ExcuteQuery(query, Par);
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