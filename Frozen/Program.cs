using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {

        class FrozenSecretSanta
        {
            string name;
            string gift;

            public FrozenSecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }
        static void Main(string[] args)
        {
            List<FrozenSecretSanta> myGifts = new List<FrozenSecretSanta>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                FrozenSecretSanta newGift = new FrozenSecretSanta(tempArray[0], tempArray[1]);
                myGifts.Add(newGift);
            }

            foreach (FrozenSecretSanta giftFromList in myGifts)
            {
                Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Gift}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\source\repos\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
