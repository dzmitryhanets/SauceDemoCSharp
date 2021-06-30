using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SauceDemoCSharp.Utils
{
    public static class StringExtensions
    {
        public static readonly string TestDataDirectory =
            string.Format("{0}{1}TestData{1}", Directory.GetCurrentDirectory(), Path.DirectorySeparatorChar);
        public static string GetTestData(this string value)
        {
            const string jsonPattern = @"^@(.*?)\.(.*)";
            JToken testValue = null;
            if (Regex.IsMatch(value, jsonPattern))
            {
                var match = Regex.Match(value, jsonPattern);
                var filePath = $"{TestDataDirectory}{match.Groups[1]}.json";
                try
                {
                    var jObject = JObject.Parse(FileUtils.ReadAllText(filePath));
                    testValue = jObject.SelectToken(match.Groups[2].ToString(), errorWhenNoMatch: false);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }

            return testValue?.ToString();
        }
    }
}
