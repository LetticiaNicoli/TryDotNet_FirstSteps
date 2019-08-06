using System;
using Newtonsoft.Json;

namespace TryDotNet_FirstSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (args[1])
            {
                case "FollowMeExample":
                    FollowMeExample();
                    break;
                case "JsonExample":
                    JsonExample();
                    break;
            }
        }

        static void FollowMeExample()
        {
            #region FollowMeExample
            var twitter = "@LetticiaNicoli";
            Console.WriteLine($"Follow me: {twitter}!");
            #endregion FollowMeExample
        }

        static void JsonExample()
        {
            #region JsonExample
            var times = new { text = "Now", time = DateTime.Now };
            var json = JsonConvert.SerializeObject(times);

            Console.WriteLine(json);
            #endregion JsonExample
        }
    }
}
