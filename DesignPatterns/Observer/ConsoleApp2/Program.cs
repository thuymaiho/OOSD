using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a girl instance as subject (publisher)
            var exercises = new exercises2();

            //// Add 2 boys to her friend zone.
            exercises.AddToZone(new menbers("Thanh"));
            exercises.AddToZone(new menbers("Thuy"));

            // One day. She need some attention, so she post to facebook.
            // After she complete post facebook. These poor boys react.
            exercises.PostFacebook();
            Console.ReadKey();
        }
    }
    public class exercises2
    {
        private bool needAttention = false;

        // Some of boys crushing this instance :))
        public IList<menbers> FriendZone = new List<menbers>();

        public void PostFacebook()
        {
            Console.WriteLine("New exercises have been updated");
            NeedAttention = true;
        }

        // State of instance. When state change, observe will know and react
        private bool NeedAttention
        {
            get => needAttention;
            set
            {
                needAttention = value;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var b in FriendZone)
            {
                b.Care();
            }
        }

        // Register observer. 
        public void AddToZone(menbers b)
        {
            FriendZone.Add(b);
        }
    }

    public class menbers
    {
        public string Name;

        public menbers(string name)
        {
            Name = name;
        }

        public void Care()
        {
            Console.WriteLine($"{Name}: enjoy that exercise, now");
        }
    }
}
