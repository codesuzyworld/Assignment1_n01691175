using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{
    ///Get localhost/Square/{id}

    /// <summary>
    /// Recieves a number and returns square of the number.
    /// </summary>
    /// <return>
    /// id*id
    /// </return>
    /// <example>
    /// curl https://localhost:44339/api/Square/{id}
    /// </example>
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            int sum = id * id;
            return sum;
        }
    }
}
