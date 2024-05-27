using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace Assignment1_n01691175.Controllers
{
    public class RouteController : ApiController
    {
        //in webapi config(to adjust the behavior of the default route template)
        //routeTemplate: "api/{controller}/{action}/{id}",


        //Get: api/Route/Method1 -> "method 1"
        [HttpGet]
        [Route("api/Route/Method1")]
        public string Method1()
        {
            return "method 1";
        }

        //Get: api/Route/Method2 -> "method 2"
        [HttpGet]
        [Route("api/Route/Method2")]
        public string Method2()
        {
            return "method 2";
        }

        //Get: api/Route/Method3/{id}
        [HttpGet]
        [Route("api/Route/Method3/{id}")]
        public string Method3(int id)
        {
            string message = "Method 3 has an input of ";
            message = message + id;
            return message;
        }


        /// <summary>
        /// Recieves two inputs and outputs their value
        /// </summary>
        /// <param name="input1"> the first input </param>
        /// <param name="input2"> the second input </param>
        /// <returns>
        /// <example>
            ///Get: api/Route/Method4/{input1}/{input2}
            ///input 1 is {input 1} , input 2 is {input 2}
        /// </example>
        /// </returns>

        [HttpGet]
        [Route("api/Route/Method4/{input1}/{input2}")]
        public string Method4(int input1, int input2)
        {
            string output = "input 1 is " + input1;
            output = output + " and input 2 is " + input2;
            return output;
        }


        //Post: api/Route/Method5
        //>curl -d "this is post data" https://localhost:44339//api/Route/Method5
        //"our Post request"
        [HttpPost]
        [Route("api/Route/Method5")]
        public string Method5()
        {
            return "our Post request";
        }
    }
}
