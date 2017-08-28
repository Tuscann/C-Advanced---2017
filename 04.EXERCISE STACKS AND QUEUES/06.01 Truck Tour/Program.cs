using System;
using System.Collections.Generic;
using System.Linq;
public partial class StacksAndQueues
{
    public static class _06TruckTour
    {
        private const int DistancePerLitre = 1;

        public static void Main() // 100/100
        {
            int n = int.Parse(Console.ReadLine());

            Queue<GasStation> gasStations = new Queue<GasStation>();
            Truck truck = new Truck();

            while (n-- > 0)
            {
                int[] gasStationParams = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int fuel = gasStationParams[0];
                int distanceToNextGasStation = gasStationParams[1];

                GasStation gasStation = new GasStation(new Pump(fuel), distanceToNextGasStation);

                gasStations.Enqueue(gasStation);
            }

            while (true)
            {
                GasStation current = gasStations.Dequeue();
                gasStations.Enqueue(current);
                truck.DumpFuel();

                int startId = current.Id;

                if (!current.EntryPoint)
                    continue;

                truck.GasStop(current);
                truck.Travel(current);

                while (truck.Fuel >= 0)
                {
                    current = gasStations.Dequeue();
                    gasStations.Enqueue(current);

                    truck.GasStop(current);
                    truck.Travel(current);


                    if (startId.Equals(current.Id))
                    {
                        Console.WriteLine(startId);
                        Environment.Exit(0);
                    }
                }
            }
        }

        private class GasStation
        {
            private static int _id = 0;

            public GasStation(Pump pump, int distanceToNextGasStation)
            {
                this.Id = _id++;
                this.Pump = pump;
                this.DistanceToNextGasStation = distanceToNextGasStation;
                this.EntryPoint = pump.Fuel >= distanceToNextGasStation;
            }

            public int Id { get; }
            public Pump Pump { get; }
            public int DistanceToNextGasStation { get; }
            public bool EntryPoint { get; }
        }

        private class Pump
        {
            public Pump(int fuel)
            {
                this.Fuel = fuel;
            }

            public int Fuel { get; }
        }

        private class Truck
        {
            public int? Fuel { get; private set; }

            public void GasStop(GasStation station)
            {
                this.Fuel += station.Pump.Fuel;
            }

            public void Travel(GasStation destination)
            {
                this.Fuel -= destination.DistanceToNextGasStation * DistancePerLitre;
            }

            public void DumpFuel()
            {
                this.Fuel = 0;
            }
        }
    }
}