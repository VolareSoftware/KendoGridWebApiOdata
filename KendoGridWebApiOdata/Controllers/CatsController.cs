using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using FizzWare.NBuilder;
using KendoGridWebApiOdata.Models;

namespace KendoGridWebApiOdata.Controllers
{
    public class CatsController : ODataController
    {
        [Queryable]
        public IQueryable<Cat> Get()
        {
            return BuildTestData();
        }

        private IQueryable<Cat> BuildTestData()
        {
            return Builder<Cat>
                .CreateListOfSize(100)
                .Build()
                .AsQueryable();
        }
    }
}