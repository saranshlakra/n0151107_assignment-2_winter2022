using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace n0151107_assignment_2_winter2022.Controllers
{
    public class CellPhoneMessagingController : ApiController
    {
        /// <summary>
        /// This messanger will calculate the minimum time to type any message 
        /// </summary>
        /// <param name="code">Input by user like 'a', 'cell, 'bob', 'www'</param>
        /// <returns>It will return minimum time to type a message</returns>
        /// 
        [HttpGet]
        [Route("api/CellPhoneMessaging/{code}")]
        public string Phone(string code)
        {
            int time = 0;
            string[] codeArr = new string[code.Length];
            for (int i = 0; i < codeArr.Length; i++) {
                codeArr[i] = code[i].ToString();
            }
               
            string[] check= new string[20];
            string[] takeOneSecond = {"a", "d", "g" , "j" , "m" , "p" , "t" , "w"}; // These all are alphabets that are on first place on the key takes one second
            string[] takeTwoSeconds = { "b", "e", "h" , "k" , "n" , "q" , "u" , "x" };// These all are alphabets that are on second place on the key takes two seconds
            string[] takeThreeSeconds = { "c", "f", "i" , "l" , "o" , "r" , "v" , "y"};// These all are alphabets that are on third place on the key takes three seconds
            string[] takeFourSeconds = { "s", "z"};// These all are alphabets that are on fourth place on the key takes four seconds

            // so they all take at least time according to their palce.
            if (code == "halt") return time.ToString(); // checking for "halt" keyword


            for (int i = 0; i < codeArr.Length; i++)
            {
                // matching to the given array and addding time accordingly
                if (takeOneSecond.Contains(codeArr[i])) time += 1;

                if (takeTwoSeconds.Contains(codeArr[i])) time += 2;

                if (takeThreeSeconds.Contains(codeArr[i])) time += 3;

                if (takeFourSeconds.Contains(codeArr[i])) time += 4;

                check[i] += codeArr[i];

            }

            for (int k = 0; k < codeArr.Length; k++) // checking for pause if any two consecutive alphabets are same it will add 2 seconds in the main time
            {
                if (check[k] == check[k+1]) time += 2;
            }

              return time.ToString();

           // return string.Join(",", codeArr); // for checking purposes only
        }
    }
}






