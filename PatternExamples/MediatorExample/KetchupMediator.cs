using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorExample
{
    internal class KetchupMediator : Mediator
    {
        private Fermer? _fermer;
        private Distributor? _distributor;
        private Plant? _plant;
        private const string mediatorColor = "\x1b[36m"; // Cyan
        private const string resetColor = "\x1b[0m";

        public void SetContagents(Fermer fermer, Distributor distributor, Plant plant)
        {
            _fermer = fermer;
            _distributor = distributor;
            _plant = plant;
        }

        public override void Send(double message, Colleague colleague)
        {
            switch (colleague)
            {
                case Distributor:
                    Console.WriteLine($"{mediatorColor}[MEDIATOR] 🔄 Distributor requests: {message} kg → Sending to FARMER{resetColor}");
                    _fermer?.Request(message);
                    break;
                case Fermer fermer:
                    Console.WriteLine($"{mediatorColor}[MEDIATOR] 🔄 Farmer sent: {message} kg → Sending to PLANT{resetColor}");
                    _plant?.Request(message);
                    break;
                case Plant plant:
                    Console.WriteLine($"{mediatorColor}[MEDIATOR] 🔄 Plant ready: {message} kg of ketchup → Sending to DISTRIBUTOR{resetColor}");
                    _distributor?.Notify(message);
                    break;
                default:
                    throw new InvalidOperationException("Unknown colleague type.");
            }
        }
    }
}
