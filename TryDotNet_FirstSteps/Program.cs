using System;
using Newtonsoft.Json;
using Serilog;

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
                case "SerilogExample":
                    SerilogExample();
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

        static void SerilogExample()
        {
            #region SerilogExample
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Ah, there you are!");

            #endregion SerilogExample
        }
    }
}
