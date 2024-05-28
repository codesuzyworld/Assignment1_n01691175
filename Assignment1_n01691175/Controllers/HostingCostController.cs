using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1_n01691175.Controllers
{
    public class HostingCostController : ApiController
    {
        /// GET http://localhost/api/HostingCost/{id}

        /// <summary>
        /// This GET request recieves a number, and calculates how many fortnights,
        /// gives the price, the HST, and the final price for web hosting, then ouputs 
        /// three strings that shows the user the full reciept. 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// “ {fortnight} fortnights at $5.50/FN = ${prices} CAD” 
        /// “HST 13% = ${HST} CAD” 
        /// “Total = ${finalprice} CAD”
        /// </returns>
        /// <example>
        /// curl https://localhost:44339/api/HostingCost/0
        /// “ 2 fortnights at $5.50/FN = $11.00 CAD” 
        /// “HST 13% = $1.43 CAD” 
        /// “Total = $12.43 CAD”
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            // First, we calculate how many fortnights is within the total days.
            // Even if the customer hosted for 3 hours, 0 days, we still charge our customer one fortnight. 
            // Therefore, we add one to our fortnight number. 
            int fortnight = id / 14 + 1;

            // Then, we calculate the price of the hosting cost BEFORE TAX.
            double prices = fortnight * 5.50;

            // Now, we calculate the tax 13%, which is 0.13.
            double HST = prices * 0.13;

            // Finally, the final price would be after tax, and rounded off two decimals. 
            double finalprice = Math.Round(prices + HST, 2);

            // Here are the three strings. 
            string tellprice = (fortnight + " " + "fortnights at $5.50/FN = $" + prices + " CAD ");
            string tellhst = (" HST 13% = " + HST + " CAD ");
            string telltotal = ("Total = $" + finalprice + " CAD");

            //Output three strings 
            return new string[] {tellprice, tellhst, telltotal};
        }



        }
    }

