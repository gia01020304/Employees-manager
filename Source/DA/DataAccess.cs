using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace DA
{
    public class DataAccess
    {
        private  SqlConnection connection = null;
        /// <summary>
        /// Lấy Connection string từ file App.cofig
        /// </summary>
        public DataAccess()
        {
            ConnectionStringSettings connecsetting = ConfigurationManager.ConnectionStrings["Final"];
            connection = new SqlConnection(connecsetting.ConnectionString);
   
        }
        private  Exception error;
        public System.Exception Error
        {
            get { return error; }
            set { error = value; }
        }
        /// <summary>
        /// Update sao khi chỉnh sửa trên datagridview
        /// </summary>
        /// <param name="Query">Câu truy vấn</param>
        /// <param name="Ds">dataset chứa dữ liệu đưa vào để update</param>
        /// <param name="Param">các tham số truyền vào</param>
        /// <returns>kết quả thực hiện số lần</returns>
        public  int UpdateDataSet(string Query,DataSet Ds,params object[] Param)
        {
            error = null;
            int result = -1;
            List<string> par = XuLyChuoi(Query);
            try
            {

               
                SqlDataAdapter adapter = new SqlDataAdapter(Query, connection);
                #region Xử lý paramater
                for (int i = 0; i < par.Count; i++)
                {
                    if (i >= Param.Length)
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(par[i], "");
                    }
                    else
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(par[i], Param[i]);
                    }

                }
                #endregion
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                connection.Open();
                result = adapter.Update(Ds, Ds.Tables[0].TableName);
                

            }
            catch (Exception ex)
            {

                error = ex;
                MessageBox.Show(error.Message,"Error");
            }
            finally
            {

                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
            
        }
        /// <summary>
        /// Lấy dữ liệu của 1 đối tượng
        /// </summary>
        /// <param name="Query">Câu truy vấn</param>
        /// <param name="Param">các tham số truyền vào</param>
        /// <returns>SqlDataReader</returns>
        public  SqlDataReader GetDataDTO(string Query, params object[] Param)
        {
            SqlDataReader reader = null;
            SqlCommand command = null;
            List<string> par = XuLyChuoi(Query);
            error = null;
            try
            {
                connection.Open();
                command = new SqlCommand(Query, connection);
                #region Xử lý para
                for (int i = 0; i < par.Count; i++)
                {
                    if (i >= Param.Length)
                    {
                        command.Parameters.AddWithValue(par[i], "");
                    }
                    else
                    {
                        command.Parameters.AddWithValue(par[i], Param[i]);
                    }

                }
                #endregion
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;

            }
            catch (Exception ex)
            {
                error = ex;
                
                MessageBox.Show(error.Message, "Error");
                if (connection != null && connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                return null;
            }
        }
        /// <summary>
        /// Lấy dữ liệu từ DB theo câu truy vấn 
        /// </summary>
        /// <param name="Query">Câu truy vấn </param>
        /// <param name="param">các tham số được truyền vào</param>
        /// <returns>1 table chứa dữ liệu theo yêu cầu câu Query</returns>
        public  DataSet ExcuteQuery(string Query, params object[] Param)
        {
            error = null;
            List<string> par = XuLyChuoi(Query);
            DataSet table = new DataSet();
            try
            {

                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                #region Xử lý para
                for (int i = 0; i < par.Count; i++)
                {
                    if (i >= Param.Length)
                    {
                        command.Parameters.AddWithValue(par[i], "");
                    }
                    else
                    {
                        command.Parameters.AddWithValue(par[i], Param[i]);
                    }

                }
                #endregion
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                error = ex;
                MessageBox.Show(error.Message, "Error");
                return null;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return table;
        }
        /// <summary>
        /// Lấy dữ liệu từ DB theo câu truy vấn hổ trợ cho việc phân trang
        /// </summary>
        /// <param name="Query">Câu truy vấn</param>
        /// <param name="firstRow">dòng bắt đầu lấy dữ liệu</param>
        /// <param name="pageSize">số dòng để lấy</param>
        /// <param name="nameTable">tên table lấy dữ liệu</param>
        /// <param name="Param">các tham số truyền vào</param>
        /// <returns>Dataset chứa dữ liệu để phân trang</returns>
        public  DataSet ExcuteQuery2(string Query, int firstRow, int pageSize, string nameTable, object[] Param)
        {
            error = null;
            List<string> par = XuLyChuoi(Query);
            DataSet table = new DataSet();
       
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Query, connection);
                #region Xử lý para
                for (int i = 0; i < par.Count; i++)
                {
                    if (i >= Param.Length)
                    {
                        command.Parameters.AddWithValue(par[i], "");
                    }
                    else
                    {
                        command.Parameters.AddWithValue(par[i], Param[i]);
                    }

                }
                #endregion
                SqlDataAdapter adapter = new SqlDataAdapter(command);
               
                adapter.Fill(table,firstRow,pageSize,nameTable);
              
            }
            catch (Exception ex)
            {
                error = ex;
                MessageBox.Show(error.Message,"Error");
                return null;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return table;
           
        }
        /// <summary>
        /// Gọi các hàm đã cài đặt sẵn trong SQL
        /// </summary>
        /// <param name="Query">câu truy vấn</param>
        /// <param name="xuly">true--xữ lý các paramater, false--không xử lý</param>
        /// <param name="Param">các tham số truyền vào</param>
        /// <returns>trả về giá trị của hàm thực hiện</returns>
        public  object ExcuteScalar(string Query, bool xuly, params object[] Param)
        {
            error = null;
            object result=null;
            List<string> par = XuLyChuoi(Query);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(Query, connection);
                if (xuly == true)
                {
                    #region Xử lý para
                    for (int i = 0; i < par.Count; i++)
                    {
                        if (i >= Param.Length)
                        {
                            command.Parameters.AddWithValue(par[i], "");
                        }
                        else
                        {
                            command.Parameters.AddWithValue(par[i], Param[i]);
                        }

                    }
                    #endregion
                }

                result =command.ExecuteScalar();
               
            }
            catch (Exception ex)
            {

                error = ex;
                MessageBox.Show(error.Message, "Error");
                return null;
            }
            finally
            {

                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Thực hiện insert, delete, edit
        /// </summary>
        /// <param name="Query">Câu truy vấn</param>
        /// <param name="Param">Các paramater</param>
        /// <returns>-1 Không xử lý đc,!=-1 xử lý thành công</returns>
        public  int ExcuteNonQuery(string Query, params object[] Param)
        {
            error = null;
            int xulychuoi = -1;
            List<string> par = XuLyChuoi(Query);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(Query, connection);
                #region Xử lý para
                for (int i = 0; i < par.Count; i++)
                {
                    if (Param[i] == null)
                    {
                        command.Parameters.AddWithValue(par[i], DBNull.Value);
                        continue;
                    }
                    if (i >= Param.Length)
                    {
                        command.Parameters.AddWithValue(par[i], "");
                    }
                    else
                    {
                        command.Parameters.AddWithValue(par[i], Param[i]);
                    }

                }
                #endregion

                xulychuoi = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                error = ex;
                MessageBox.Show(error.Message, "Error");
            }
            finally
            {

                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return xulychuoi;
        }
        /// <summary>
        /// lọc ra các paramater kí hiệu '@paramater' trong câu Query
        /// </summary>
        /// <param name="Query">Câu truy vấn</param>
        /// <returns>danh sách các paramater</returns>
        static List<string> XuLyChuoi(string Query)
        {
            List<string> temp2 = new List<string>();
            List<string> par = new List<string>();
            int vt = Query.IndexOf("@");
            while (vt != -1)
            {
                for (int i = vt + 1; i < Query.Length; i++)
                {
                    //Query[i] == ' ' || Query[i] == ')' || Query[i] == '%' || Query[i] == '\'' || Query[i] == ','
                    if (!char.IsLetterOrDigit(Query[i]))
                    {
                        string temp = Query.Substring(vt, i - vt);
                        Query = Query.Remove(vt, i - vt);
                        if (!temp2.Contains(temp))
                        {
                            par.Add(temp);
                            temp2.Add(temp);
                        }
                        break;
                    }
                    if (i == Query.Length - 1)
                    {
                        string temp = Query.Substring(vt, i - vt + 1);
                        Query = Query.Remove(vt, i - vt + 1);
                        if (!temp2.Contains(temp))
                        {
                            par.Add(temp);
                            temp2.Add(temp);
                        }
                        break;
                    }

                }
                vt = Query.IndexOf("@");
            }
            return par;
        }

    }
}
