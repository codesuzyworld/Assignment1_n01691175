using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{
    ///Get localhost/Addten/{id}

    /// <summary>
    /// Recieves a number and returns the number with ten added.
    /// </summary>
    /// <return>
    /// id + 10 
    /// </return>
    /// <example>
    /// curl https://localhost:44339/api/AddTen/{id}
    /// </example>
    public class AddTenController : ApiController
    {
        public int Get(int id)
        {
            int sum = id + 10;
            return sum;
        }
    }
}
