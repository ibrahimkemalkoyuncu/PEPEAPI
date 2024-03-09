﻿namespace API.Logging
{
    public class Loging : ILogging
    {
        public void Log(string message, string type)
        {
            if(type == "error")
            {
                Console.WriteLine("ERROR - " + message); 
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
