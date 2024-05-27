using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{
    public class ExampleController : ApiController
    {
        //We have the ability to listen for http requests and provide 
        // responses to those requests

        //Framework: a set of tools that allow us to achieve a given task
        //Abstraction: obfuscating the details of an implementation to allow
        //a user to focus on the overall strategy e.g. hide stuff so ppl wont be overwhelmed
        //Convention: A set of predefined processes or forms which allow us to achieve
        //our given tasks

        //Get:localhost:xx/api/Example -> "My http response"
        // go to the command prompt and type 
        // curl https://localhost:44339/api/example
        public string Get()
        {
            string response = "A GET request";
            return response;
        }

        //POST: localhost:xx/api/Example
        // go to the command prompt and type 
        // Post request requires you to send some form data to get a response
        // let's send some empty data to get the post response here. 
        // curl -d "" https://localhost:44339/api/example   
        
        /// <summary>
        /// This method listens for a post request and provides a string response
        /// </summary>
        /// <returns>
        /// A response to a post request
        /// </returns>
        /// <example>
        /// Post:localhost:xx/Apli/Example -> "A response to a POST request"
        /// /// curl -d "" https://localhost:44339/api/example
        /// </example>
        
        public string Post()
        {
            string response = "A POST REQUEST";
            return response;
        }



        //Get:localhost:xx/api/Example/id number -> "Get with number input"
     /// <summary>
     /// Recieves a number and returns a message indicating what number was entered.
     /// </summary>
     /// <param name="id"></param>
     /// <returns>
     /// "You entered the number {id}"
     /// </returns>
    /// <example>
    /// 
    /// </example>

        public string GET(int id)
        {
            string message = "You entered number ";
            message = message + id;
            return message;
        }


    }
}
