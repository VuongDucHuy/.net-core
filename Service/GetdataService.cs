using TRANNING.Entity;
using TRANNING.IRepository;
using TRANNING.IServices;
using TRANNING.Models;

namespace TRANNING.Service
{
    public class GetdataService : IGetdataService
    {
        private readonly IGetdataResponsitory _IGetdataResponsitory;
        public GetdataService(IGetdataResponsitory getdataResponsitory)
        {
            _IGetdataResponsitory = getdataResponsitory;
        }

        public ListDataViewModel GetData()
        {
            var data = _IGetdataResponsitory.GetData();
            ListDataViewModel ldt =  new ListDataViewModel()
            {
                Listt = data.listing.Select(p => new DataViewModel(p)).ToList(),

            };
            return ldt;
        }
    }
}
