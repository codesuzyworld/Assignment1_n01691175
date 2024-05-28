using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{


    public class GreetingController : ApiController
    {
        /// GET http://localhost/api/Greeting/{id}
        /// <summary>
        /// This GET request recieves number, and returns a greeting that greets the number of people that the user inputs
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// Greetings to {id} people!
        /// </returns>
        /// <example>
        /// curl " https://localhost:44339/api/greeting/{id}
        /// </example>
        public string Get(int id)
        {
            string response = "Greetings to " + id + " people!";
            return response;
        }

    }
}
