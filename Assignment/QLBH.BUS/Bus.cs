using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH.DAO;
using QLBH.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLBH.BUS
{
    public class Bus
    {
        LopDAO dao = new LopDAO();
        public DataTable datatable()
        {
             return dao.Load();
        }
        public DataTable search()
        {
            return dao.search();
        }
        public DataRow select(int index)
        {
            return dao.select(index);
        }
        public void insert(HangHoa hh)
        {
            dao.insert(hh); 
        }
        public void delete(int index)
        {
            dao.delete(index);
        }
        public void update()
        {
            dao.update();
        }
       
       
    }
}
