using TRANNING.IRepository;
using TRANNING.Models;
using Dapper;
using TRANNING.Entity;
using System.Linq;
using System.ComponentModel;

namespace TRANNING.Repository
{

    public class GetdataRepository : IGetdataResponsitory
    {
        private IDatabaseExecuteRepository<DataEntity> _databaseExecuteRepository;
        public GetdataRepository(IDatabaseExecuteRepository<DataEntity> databaseExecuteRepository)
        {
            _databaseExecuteRepository = databaseExecuteRepository;
        }
        public ListDataEntity GetData()
        {
            string sql = "sp_GetData";
            var dParameter = new Dictionary<string, string>();
            dParameter["PageIndex"] = "1";
            dParameter["PageSize"] = "25";
        
            var result = _databaseExecuteRepository.ExcecuteProceduceQuery<DataEntity>(sql, dParameter, paramOutput : "Total");

            ListDataEntity list = new ListDataEntity();
            list.listing = result.data.ToList();
            return list ;
        }
    }
}
