using System;
using System.Linq.Expressions;

namespace _4_AlexaSettings
{
    class Program
    {
        private static void Main(string[] args)
        {
            var alexa = new Alexa();
            Console.WriteLine(alexa.Talk()); //print hello, i am Alexa

            alexa.Configure(x =>
            {
                x.GreetingMessage = "Hello {OwnerName}, I'm at your service";
                x.OwnerName = "Bob Marley";
               
            });

            Console.WriteLine(alexa.Talk()); //print Hello Bob Marley, I'm at your service

            Console.WriteLine("press any key to exit ...");
            Console.ReadKey();

        }

    }

    public class Alexa
    {
        private AlexaConfiguration _alexaConfiguration;
        public class AlexaConfiguration
        {
            public string GreetingMessage { get; set; }
            public string OwnerName { get; set; }

            public string GetGreeting()
            {
                return GreetingMessage.Replace($"{{{nameof(OwnerName)}}}", OwnerName);
            }


        }
        
        public Alexa()
        {
            _alexaConfiguration = new AlexaConfiguration()
            {
                GreetingMessage = $"hello, i am {nameof(Alexa)}"
            };
        }
        public string Talk()
        {
            return _alexaConfiguration.GetGreeting();
        }
        public delegate void AlexaConfigure(AlexaConfiguration alexaConfiguration);
        public void Configure(AlexaConfigure alexaConfigure)
        {

            alexaConfigure(_alexaConfiguration);
        }

    }
    
}
