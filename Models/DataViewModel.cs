using TRANNING.Entity;
using static Dapper.SqlMapper;

namespace TRANNING.Models
{
    public class DataViewModel
    {

        public DataViewModel(DataEntity entity)
        {
            Name = entity.Name;
            Address = entity.Address;
            Id = entity.Id;
            diachi = entity.diachi;
            tensp = entity.tensp;
            gia = entity.gia;
        }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public string diachi { get; set; }
        public string tensp { get; set; }
        public float gia { get; set; }


    }
    public class ListDataViewModel
    {
      public  List<DataViewModel> Listt { get; set; } = new List<DataViewModel>() ;

    }
}
