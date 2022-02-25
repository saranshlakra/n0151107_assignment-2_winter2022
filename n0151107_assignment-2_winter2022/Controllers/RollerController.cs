using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n0151107_assignment_2_winter2022.Controllers
{
    public class RollerController : ApiController
    {
        /// <summary>
        /// This controller will get dice 1 and dice 2 value from user and calculate the total ways 
        /// in which user can get sum 10
        /// </summary>
        /// <param name="dice1"> dice 1 value by user</param>
        /// <param name="dice2"> dice 2 value by user</param>
        /// <returns>Total number of ways to get sum 10</returns>

        [HttpGet]
        [Route("api/roller/{dice1}/{dice2}")]
        public string Roller(int dice1, int dice2)
        {
            
            int ways = 0;
                        
            for(int k = 0; k < dice1 + 1; k++)
            {
                
                for (int l = 0; l < dice2 + 1 ; l++)
                {
                    
                    if (k+l == 10) ways++; // one line code doen't need {}.
                }
            }
            return "There are " + ways + " total ways to get the sum 10.";

        }
    }
}
