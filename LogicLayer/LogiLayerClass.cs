using DataLayer;
using Entity.Model;

namespace LogicLayer
{
    public class LogiLayerClass : ILogiLayerClass
    {
        private readonly IDatalayerClass _datalayerClass;
        public LogiLayerClass(IDatalayerClass datalayerClass)
        {
            _datalayerClass = datalayerClass;
        }

        public List<UserdetailsModel> actionresult()
        {
           var data = _datalayerClass.GetData();
            return data;
        }
    }
}