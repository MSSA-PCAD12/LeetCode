using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace RomanNumeral
{
    public static class Function2
    {
        [FunctionName("RomanToInteger")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string roman = req.Query["Roman"];

            int result = RomanToInt(roman);

            string responseMessage = string.IsNullOrEmpty(roman)
                ? "This HTTP triggered function executed successfully. Pass a Roman Numeral String query string ?Roman=MMMDCCXLIX"
                : $"{result}";

            return new OkObjectResult(responseMessage);
        }
        public static int RomanToInt(string s)
        {
            int result = 0;
            Dictionary<string, int> lookup = new Dictionary<string, int>() {
            { "I",1 },
            { "V",5 },
            { "X",10 },
            { "L",50 },
            { "C",100 },
            { "D",500 },
            { "M",1000 },
            { "IV",4 },
            { "IX",9 },
            { "XL",40 },
            { "XC",90 },
            { "CD",400 },
            { "CM",900 }
            };
            for (int i = 0; i < s.Length; i++)
                if (i + 1 < s.Length)
                {
                    if (lookup.ContainsKey(string.Concat(s[i], s[i + 1])))
                    {
                        result += lookup[string.Concat(s[i], s[i + 1])];
                        i += 1;
                        continue;
                    }
                    result += lookup[s[i].ToString()];
                }
                else
                { result += lookup[s[i].ToString()]; }
            return result;
        }
    }
}
