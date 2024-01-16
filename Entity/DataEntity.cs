using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TRANNING.Entity
{
    

    public class DataEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public string diachi { get; set; }
        public string tensp { get; set; }
        public float gia { get; set; }

    }
    public class ListDataEntity
    {
         public List<DataEntity> listing { get; set; } = new List<DataEntity>();

    }
}
