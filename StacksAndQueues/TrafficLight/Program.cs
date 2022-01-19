using System;
using System.Collections.Generic;

namespace TrafficLight
{
    class Program
    {
        static void Main(string[] args)
        {
            string car = "";
            int nrCars = Convert.ToInt32(Console.ReadLine());
            TrafficLights semafor1 = new TrafficLights(nrCars);

            while (true)
            {
                car = Console.ReadLine();
                semafor1.TrafficLightInput(car);
            }
        }
    }

    class TrafficLights
    {
        int counter = 0;
        int carPassOnGreen;
        Queue<string> myQueue = new Queue<string>();

        public int GetCounter { get => counter; }

        public TrafficLights(int carPassOnGreen)
        {
            this.carPassOnGreen = carPassOnGreen;
        }

        public void AddCarToQueue(string car)
        {
            myQueue.Enqueue(car);
        }

        public void RemoveCarFromQueue()
        {
            for (int i = 0; i < carPassOnGreen && i < myQueue.Count; i++)
            {
                counter++;
                Console.WriteLine($"{myQueue.Dequeue()} passed!");
            }
        }

        public void TrafficLightInput(string input)
        {
            if (input == "END")
            {
                Console.WriteLine(GetCounter);
            }
            if (input == "green")
            {
                RemoveCarFromQueue();
            }
            else
            {
                AddCarToQueue(input);
            }
        }
    }
}

/*
Traffic Light
Create a program that simulates the queue that forms during a traffic jam. During a traffic jam only N cars can pass the crossroads when the light goes green. 
Then the program reads the vehicles that arrive one by one and adds them to the queue. 
Input
• On the first line you will receive N – the number of cars that can pass during a green light
• On the next lines, until the "end" command is given, you will receive commands – a single string, either a car or "green"
Output
• Every time the "green" command is given, print out a message for every car that passes the crossroads in the format "{car} passed!"
• When the "end" command is given, print out a message in the format "{number of cars} cars passed the crossroads."
*/
