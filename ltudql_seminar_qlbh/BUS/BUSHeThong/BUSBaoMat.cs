using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUSBaoMat
    {
        public DataTable getHangHoa()
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getHangHoa();

            return dt;
        }
        public int removeHangHoa(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.removeHangHoa(mahanghoa);

            return dt;
        }

        public bool insertHangHoa(DTOHangHoa hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            bool dt = um.insertHangHoa(hanghoa);

            return dt;
        }

        public int updateHangHoa(DTOHangHoa hanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            int dt = um.updateHangHoa(hanghoa);

            return dt;
        }

        public DTOHangHoa getHangHoaDetail(string mahanghoa)
        {
            DALKhoHang um = new DALKhoHang();

            DataTable dt = um.getHangHoaDetail(mahanghoa);
            DTOHangHoa a = new DTOHangHoa();
            a.id = dt.Rows[0]["id"].ToString();
            a.MASP = dt.Rows[0]["MASP"].ToString();
            a.TENSP = dt.Rows[0]["TENSP"].ToString();
            a.DVT = dt.Rows[0]["DVT"].ToString();
            a.NUOCSX = dt.Rows[0]["NUOCSX"].ToString();
            a.GIA = dt.Rows[0]["GIA"].ToString();
            return a;
        }

        public DataTable getRoleList()
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getRoleList();

            return dt;
        }

        public bool updateRoleList(DataTable dt)
        {
            DALBaoMat um = new DALBaoMat();
            if (um.updateRoleList(dt))
            {
                return true;
            }
            return false;
        }

        public DataTable getUserList()
        {
            DALBaoMat um = new DALBaoMat();

            DataTable dt = um.getUserList();

            return dt;
        }


    }
}
