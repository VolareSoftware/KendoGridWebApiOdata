using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using FizzWare.NBuilder;
using KendoGridWebApiOdata.Models;

namespace KendoGridWebApiOdata.Controllers
{
    public class DogsController : ODataController
    {
        [Queryable]
        public IQueryable<Dog> Get()
        {
            return BuildTestData();
        }

        private IQueryable<Dog> BuildTestData()
        {
            return Builder<Dog>
                .CreateListOfSize(100)
                .Build()
                .AsQueryable();
        }
    }
}