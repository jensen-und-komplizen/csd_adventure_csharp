using System;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace CsdTextAdventure
{
    public class TimeService
    {
        private static readonly HttpClient Client = new();
        private readonly string _tz;

        public TimeService()
        {
            _tz = "Europe/Berlin";
        }

        public long CurrentTime()
        {
            return CurrentTime(_tz);
        }

        public static long CurrentTime(string tz)
        {
            try
            {
                var response = Client.GetAsync("https://csd-timeservice.idiot.games/").Result;
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Wrong status: " + (int)response.StatusCode);
                }

                var match = Regex.Match(response.Content.ReadAsStringAsync().Result, "(-?\\d+)");
                if (match.Success)
                {
                    return long.Parse(match.Groups[1].Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return -1L;
        }
    }
}
