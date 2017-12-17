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
        /// <summary>
        /// KTKL của một nhân viên theo IDNV
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public SqlDataReader getIDKTKL(object Id)
        {
            string query = @"SELECT Id_KTKL FROM NV_KTKL
                             WHERE Id_NV=@p";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Id);
        }
        /// <summary>
        /// Nhân viên theo CV và phòng ban
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetNhanVien2(params object[] Par)
        {
            string query = @"SELECT  Id,Kh,FName ,LName FROM	dbo.NhanVien
		                WHERE Id_PB=@p1 AND Id_CV=@p2 ";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }
        /// <summary>
        /// Tổng lương của phòng abn
        /// </summary>
        /// <param name="Par">Mã phòng ban</param>
        /// <returns></returns>
        public object TongLuong(params object[] Par)
        {
            string query = @"SELECT dbo.TongLuong(@p1)";
            DataAccess da = new DataAccess();
            return da.ExcuteScalar(query, true, Par);
        }

        internal DataSet GetNhanVien(object[] par)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// THêm KTKL
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int ThemNVKTKL(params object[] Par)
        {
            string query = @"INSERT NV_KTKL
             		        ( Id_KTKL ,
             		          Id_NV ,
             		          Kh_NV
             		        )
             		VALUES  (@p1,@p2,@p3)";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// Chức vụ theo phòng ban
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public SqlDataReader GetChucVuDTO(object Id)
        {
            string query = @"SELECT Id,Name,Id_PB FROM ChucVu,PhongBan_ChucVu
                             WHERE Id_CV=ChucVu.Id AND Id_PB=@p1";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Id);
        }
        /// <summary>
        /// Xóa KTKL của một nhân viên
        /// </summary>
        /// <param name="id1"></param>
        /// <param name="id2"></param>
        /// <returns></returns>
        public int XoaKTKLNV(object id1, object id2)
        {
            string query = @"DELETE FROM NV_KTKL
						WHERE Id_NV=@p1 AND ID_KTKL=@p2";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, id1, id2);
        }
        /// <summary>
        /// Xóa KTKL
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int XoaKTKL(object id)
        {
            string query = @"DELETE FROM KTKL
						WHERE Id=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, id);
        }
        /// <summary>
        /// Sửa KTKL
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int EditKTKL(params object[] Par)
        {
            string query = @"UPDATE	KTKL
							  SET 
                             NameKTKL=@p1,
                             HinhThuc=@p2,
                              Money=@p3
                        WHERE Id=@p4";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// Sửa lương cho chức vụ
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int EditCVL(params object[] Par)
        {
            string query = @"UPDATE	ChucVu
							  SET 
                             Id_ML=@p1  
                        WHERE Id=@p2";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// KTKL của một nhân viên
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetKTKLNV(params object[] Par)
        {
            string query = @"SElect NameKTKL as 'Mục',HinhThuc as 'Hình thức',Money as 'Số tiền' From KTKL,NV_KTKL 
                                Where Id_NV=@p1 AND Kh_NV=@p2 AND Id_KTKL=Id";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }

        /// <summary>
        /// Thêm KTKL
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int ThemKTKL(params object[] Par)
        {
            string query = @"INSERT KTKL
             		        ( NameKTKL ,
             		          HinhThuc ,
             		          Money 
             		        )
             		VALUES  (@p1,@p2,@p3)";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
     
        /// <summary>
        /// Sửa lương
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public int EditSalary(params object[] Par)
        {
            string query = @"UPDATE	MucLuong
							  SET 
                             Money=@p1
                        WHERE Id=@p2";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        public int RestoreNhanVien(params object[] Par)
        {
            string query = @"SET IDENTITY_INSERT dbo.NhanVien ON
                            INSERT INTO dbo.NhanVien
                                    ( Id,
		                              Kh ,
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
                            SELECT    Id ,
                                      Kh ,
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
                            FROM dbo.TempNhanVien
                            WHERE dbo.TempNhanVien.Id=@p1
                            DELETE dbo.TempNhanVien
                            WHERE dbo.TempNhanVien.Id=@p2";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }

        /// <summary>
        /// Bảng lương
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetSalary(params object[] Par)
        {
            string query = @"SElect * From MucLuong";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }
        /// <summary>
        ///bảng lương theo chức vụ
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetTablesaCV(params object[] Par)
        {
            string query = @"SELECT Id_PB ,ChucVu.Id as 'ID Chức vụ',Name as 'Chức vụ',MucLuong.Id as 'Mức lương',Money as 'Số tiền' FROM MucLuong,ChucVu,PhongBan_ChucVu
                               Where Id_ML=MucLuong.Id AND Id_CV=ChucVu.Id";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }
        /// <summary>
        /// Đếm số lượng nhân viên trong 1 phòng ban
        /// </summary>
        /// <param name="Par">Mã Phòng Ban</param>
        /// <returns>kết quả</returns>
        public int DemRecord(params object[] Par)
        {
            string query = @"SELECT COUNT(*) FROM dbo.NhanVien
                        WHERE dbo.NhanVien.Id_PB=@p1";
            DataAccess da = new DataAccess();   
            return Convert.ToInt32(da.ExcuteScalar(query, true, Par));
        }
        /// <summary>
        /// Kiểm tra đã có trưởng phòng hay chưa
        /// </summary>
        /// <param name="Par">mã phong ban</param>
        /// <returns>1--đã có,0-- chưa có</returns>
        public int test(params object[] Par)
        {
            string query = @"SELECT dbo.test(@macv)";
            DataAccess da = new DataAccess();
            return Convert.ToInt32(da.ExcuteScalar(query, true, Par));
        }
        /// <summary>
        /// Bảng KTKL
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetKTKL(params object[] Par)
        {
            string query = @"SElect Id as 'ID KTKL',NameKTKL as 'Tên KTKL',HinhThuc  as 'Hình thức',Money as 'Số tiền' From KTKL";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }
        /// <summary>
        /// KTKL của tất cả nhân viên
        /// </summary>
        /// <param name="Par"></param>
        /// <returns></returns>
        public DataSet GetKTKLNV1(params object[] Par)
        {
            string query = @"Select	NhanVien.Id,Kh as 'ID Nhân viên',FName as 'Họ',LName as 'Tên',KTKL.Id 'ID KTKL',KTKL.NameKTKL as 'Tên KTKL',KTKL.HinhThuc as 'Hình thức',KTKL.Money as 'Số tiền' FROM NhanVien,KTKL,NV_KTKL WhERE KTKL.Id=NV_KTKL.Id_KTKL AND NhanVien.Id=NV_KTKL.Id_NV AND Kh=NV_KTKL.Kh_NV";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);
        }

        /// <summary>
        /// Thêm nhân viên vào DB
        /// </summary>
        /// <param name="Par">Tham số</param>
        /// <returns>số dòng thực hiện</returns>
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
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);

        }
        /// <summary>
        /// Tìm kiếm theo dữ liệu nhận được từ Form
        /// </summary>
        /// <param name="model">chế độ tìm kiếm</param>
        /// <param name="MaPB">mã phòng ban</param>
        /// <param name="MaCV">mã chức vụ</param>
        /// <param name="Info">thông tin ngư dùng nhập</param>
        /// <returns>dataset chữa dữ liệu</returns>
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
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, Par);

        }

        public int XoaKTKLNV2(int id)
        {
            string query = @" DELETE dbo.NV_KTKL 
                            WHERE Id_NV=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, id);
        }

        /// <summary>
        /// Lưu nhân viên bị xóa
        /// </summary>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
        public int SaveTemp(params object[] Par)
        {
            string query = @"INSERT INTO dbo.TempNhanVien
                            ( Id ,
                              Kh ,
                              FName ,
                              LName ,
                              GioiTinh ,
                              DOB ,
                              HireDay ,
                              QueQuan ,
                              Id_PB ,
                              Id_NQL ,
                              Kh_NQL ,
                              Id_CV ,
                              DayDelete
                            )
                    SELECT *,GETDATE()
                    FROM dbo.NhanVien
                    WHERE dbo.NhanVien.Id=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// Lấy danh sách nhân viên bị xóa
        /// </summary>
        /// <returns>DS chứa dữ liệu nhân viên bị xóa</returns>
        public DataSet LoadRemove()
        {
            string query = @" SELECT Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán'
                    FROM dbo.TempNhanVien
                    WHERE DATEDIFF(DAY,GETDATE(),dbo.TempNhanVien.DayDelete)<31";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query);
        }
        /// <summary>
        /// Update thông tin nhân viên sau khi chỉnh sửa
        /// </summary>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện được</returns>
        public int UpdateThongTin(params object[] Par)
        {
            string query = @"UPDATE dbo.Admin
                        SET UserName=@p1,
	                        PassWord=@p2,
	                        FullName=@p3,
                            DOB =@p4,
                            PhoneNumber=@p5 ,
                            Sex=@p6,
                            Rate=@p7
	                        WHERE UserName=@p8";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }


        /// <summary>
        /// Lấy dữ liệu 1 nhân viên
        /// </summary>
        /// <param name="Id">mã nhân viên</param>
        /// <returns>Reader</returns>
        public SqlDataReader GetNhanVienDTO(object Id)
        {
            string query = @"SELECT *FROM dbo.NhanVien
                             WHERE dbo.NhanVien.Id = @p1";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Id);
        }
        /// <summary>
        /// Lấy mã nhân viên tự tăng dưới DB
        /// </summary>
        /// <returns>mã nhân viên hiện tại</returns>
        public int GetIDNV()
        {
            string query = @"SELECT IDENT_CURRENT('NhanVien')";
            DataAccess da = new DataAccess();
            return Convert.ToInt32(da.ExcuteScalar(query, false));
        }
        /// <summary>
        /// Lấy dữ liệu của Phòng Ban
        /// </summary>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>reader</returns>
        public SqlDataReader GetPhongBan(params object[] Par)
        {

            string query = @"SELECT dbo.PhongBan.NamePB ,dbo.PhongBan.KyHieu,dbo.ChucVu.Id AS idcv,dbo.ChucVu.Name
                            FROM dbo.PhongBan,dbo.ChucVu,dbo.PhongBan_ChucVu
                            WHERE dbo.PhongBan.Id=@mbp
                                    AND dbo.PhongBan.Id=dbo.PhongBan_ChucVu.Id_PB
                                    AND dbo.PhongBan_ChucVu.Id_CV=dbo.ChucVu.Id ";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Par);

        }
        /// <summary>
        /// Lưu nhân viên xuống DB
        /// </summary>
        /// <param name="Par">Tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
        public int ThemThanNhan(params object[] Par)
        {
            string query = @"INSERT dbo.ThanNhan
                    ( Id_NV, Kh_NV , NameTN, DOB,QuanHe )
                    VALUES(@p1,@p2,@p3,@p4,@p5) ";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// Update DB dựa vào chỉnh sửa trên datagridview
        /// </summary>
        /// <param name="ds">Dataset</param>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
        public int UpdateDataSet(DataSet ds, params object[] Par)
        {

            string query = string.Format("SELECT *FROM	{0}", ds.Tables[0].TableName);
            DataAccess da = new DataAccess();
            return da.UpdateDataSet(query, ds, Par);
        }
        /// <summary>
        /// Lấy dữ liệu thân nhân
        /// </summary>
        /// <param name="par">tham số truyền vào</param>
        /// <returns>DataSet chứa dữ liệu</returns>
        public DataSet GetThanNhan(params object[] par)
        {
            string query = @"SELECT *
                                FROM dbo.ThanNhan
                                WHERE dbo.ThanNhan.IdNV = @p1";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery(query, par);
        }
        /// <summary>
        /// Xóa thân nhân
        /// </summary>
        /// <param name="par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
        public int XoaThanNhan(params object[] par)
        {
            string query = @" DELETE FROM dbo.ThanNhan 
		                            WHERE IdNV=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, par);
        }
        /// <summary>
        /// Lấy dữ liệu chức vụ của công ty dưới DB
        /// </summary>
        /// <param name="Par">Mã phòng ban</param>
        /// <returns>reader chứa dữ liệu chức vụ</returns>
        public SqlDataReader GetChucVu(object[] Par)
        {
            string query = @"SELECT Id,NameCV FROM dbo.ChucVu,dbo.PhongBan_ChucVu
                           WHERE Id=dbo.PhongBan_ChucVu.Id_CV AND Id_PB=@mpb  ";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Par);
        }
        /// <summary>
        /// Lấy dữ liệu nhân viên với số dòng nhất định dựa vào câu truy vấn
        /// </summary>
        /// <param name="FirstRow">dòng đầu tiên bắt đầu lấy</param>
        /// <param name="PageSize">số dòng lấy dữ liệu</param>
        /// <param name="nameTable">tên  bảng lấy dữ liệu</param>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>dataset với số dòng thảo điều kiện</returns>
        public DataSet GetNhanVienPT(int FirstRow, int PageSize, string nameTable, params object[] Par)
        {
            string query = @"select Row_number() over(order by dbo.NhanVien.Id)STT,Id AS N'Mã Nhân Viên',FName N'First Name',LName N'Last Name',GioiTinh AS N'Giới Tính',DOB,QueQuan N'Quê Quán' from dbo.NhanVien
                                        WHERE dbo.NhanVien.Id_PB=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteQuery2(query, FirstRow, PageSize, nameTable, Par);
        }
        /// <summary>
        /// Update nhân viên sau khi chỉnh sửa
        /// </summary>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
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
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }
        /// <summary>
        /// Xóa nhân viên dưới DB
        /// </summary>
        /// <param name="id">Mã nhân viên</param>
        /// <returns>số dòng thực hiện</returns>
        public int XoaNhanVien(object id)
        {
            string query = @"DELETE FROM dbo.NhanVien
						WHERE dbo.NhanVien.Id=@p1";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, id);
        }
        /// <summary>
        /// Lấy thông tin ADmin dưới DB
        /// </summary>
        /// <param name="Par">Tham số truyền vào</param>
        /// <returns>reader chứa dữ liệu Admin</returns>
        public SqlDataReader GetAdmin(params object[] Par)
        {

            string query = @"SELECT *FROM dbo.Admin WHERE UserName= @UN AND PassWord= @PW ";
            DataAccess da = new DataAccess();
            return da.GetDataDTO(query, Par);

        }
        /// <summary>
        /// Update ADmin sau khi chỉnh sửa
        /// </summary>
        /// <param name="Par">tham số truyền vào</param>
        /// <returns>số dòng thực hiện</returns>
        public int LuuThongTin(params object[] Par)
        {
            string query = @"INSERT dbo.ADMIN
            ( UserName, PassWord, FullName )
             VALUES  ( @un , @pw, @adname)";
            DataAccess da = new DataAccess();
            return da.ExcuteNonQuery(query, Par);
        }

    }
}
