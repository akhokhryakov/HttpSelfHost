using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost2
{
    public class ValuesController : ApiController
    {
        string[] list = new string[] { "value1", "value2", "bugga" };
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            return "value";
        }

        public bool Put(int id, [FromBodyAttribute] string value)
        {
            switch (id)
            {
                case 1: list[0] = value;
                    return true;
                case 2: list[1] = value;
                    return true;
                default: throw  new IndexOutOfRangeException("list");
            }
        }
        

        // DELETE api/values/5 
        public void Delete(int id)
        {
        }
    }
}
