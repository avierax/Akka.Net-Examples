using System;
using Akka.Actor;

namespace Akka.Net_Examples
{
    class Greet
    {

    }

    class GreeterActor : ReceiveActor
    {
        public GreeterActor()
        {
            Receive<Greet>(greet =>
            {
                Console.WriteLine("Actor has been greeted");
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var actorSystem = ActorSystem.Create("MainActorSystem");
            var actorRef = actorSystem.ActorOf<GreeterActor>("actorA");
            actorRef.Tell(new Greet());
            Console.ReadLine();
        }
    }
}
