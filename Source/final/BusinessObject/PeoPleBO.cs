using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.DataObject;
using project.Provider;
using System.Windows.Forms;

namespace project.BusinessObject
{
    class PeoPleBO
    {
        /// <summary>
        /// Lấy mã nhân viên tiếp theo
        /// </summary>
        /// <returns>mã nhân viên</returns>
        public int GetIDNV()
        {
            Providers provi = new Providers();
            int kq = provi.GetIDNV();
            if (kq >= 0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return -1;
            }
        }
        /// <summary>
        /// Kiểm tra đã tồn tại trưởng phòng hay chưa
        /// </summary>
        /// <param name="Par">mã phòng ban</param>
        /// <returns>1--đẫ tồn tại/0--chưa tồn tại</returns>
        public int test(params object[] Par)
        {
            Providers provi = new Providers();
            int kq = provi.test(Par);
            if (kq >= 0)
            {
                return kq;
            }
            else
            {
                MessageBox.Show("Không lấy được dữ liệu", "Error");
                return -1;
            }
        }
    }
}
