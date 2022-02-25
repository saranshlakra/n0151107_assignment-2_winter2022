using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n0151107_assignment_2_winter2022.Controllers
{


    public class menuTypeTwoController : ApiController
    {

        /// <summary>
        /// This controller will add choosen array value according to user input and return the value
        /// burgers, drinks, sides, desserts array contains calories in number
        /// int cal will be the total value that user choose from different arrays
        /// </summary>
        /// <param name="idB"> option for burger by user</param>
        /// <param name="idD"> option for drinks by user</param>
        /// <param name="idS"> option for sides by user</param>
        /// <param name="idl"> option for deserts by user</param>
        /// <returns>Total calories (CalConsumed)</returns>

        [HttpGet]
        [Route("api/menuTypeTwo/{idB}/{idD}/{idS}/{idl}")]
        public string Burgers(int idB, int idD, int idS, int idl)
        {
            
            int[] burgers = {0, 461, 431, 420, 0 }; // I used '0' here (on the first place) in these array because it is the easiest thing I can do here as we need '4' as our last option in the menu.
            int[] drinks = {0, 130, 160, 118, 0}; // and in array index starts from 0.
            int[] sides = {0, 100, 57, 70, 0 };
            int[] desserts = {0, 167, 266, 75, 0 };

          int  calConsumed = burgers[idB] + drinks[idD] + sides[idS] + desserts[idl];
            return "Your total Calories are " + calConsumed.ToString(); //tostring to change number into string
        }

    }
}
 