using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeral
{
    public static class Function1
    {
        [FunctionName("IntegerToRoman")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            int.TryParse(req.Query["int"],out int fromInt);

            string result = IntToRoman(fromInt);
          

            string responseMessage = string.IsNullOrEmpty(result)
                ? "This HTTP triggered function executed successfully. Pass an integer query ?int=1977 to get Roman Numeral back."
                : $"{result}";

            return new OkObjectResult(responseMessage);
        }

        public static string IntToRoman(int num)
        {
            var sb = new StringBuilder();
            Dictionary<int, string> lookup = new Dictionary<int, string>() {
                 { 1 ,"I"},
                 { 4 ,"IV"},
                 { 5 ,"V"},
                 { 9 ,"IX"},
                 { 10 ,"X"},
                 { 40 ,"XL"},
                 { 50 ,"L"},
                 { 90 ,"XC"},
                 { 100 ,"C"},
                 { 400 ,"CD"},
                 { 500 ,"D"},
                 { 900,"CM" },
                 { 1000 ,"M"},
                };//set up dictionary to match number to roman numeral, in ascending order
            while (num > 0)
            { //this loop continues as long as there are left over num to subtract from
                int largestSoFar = 0; //variable to keep track of the largest number that can be substracted from num
                foreach (var item in lookup)
                {
                    if (item.Key <= num) { largestSoFar = item.Key; }//if item.Key is less than or equal to num, update the largestSoFar with current item key
                    else { break; }// item.key is now greater than num, stop the for loop
                }
                num = num - largestSoFar;//subtract largestSoFar from num
                sb.Append(lookup[largestSoFar]); //append to the output string
            }
            return sb.ToString();
        }
    }
}
