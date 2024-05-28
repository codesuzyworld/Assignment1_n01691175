using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// GET http://localhost/api/NumberMachine/{id}

        /// <summary>
        /// This Get request recieves a number, then returns the number after + 100,
        /// divided by 2, then minus by (10*2)
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// an integer after the formula (({id} + 100)/2) - (10*2) is applied
        /// </returns>
        public int get(int id)
        {
            int sum = ((id + 100)/2) - (10*2);
            return sum;
        }
    }
}
