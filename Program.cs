using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> firstSetlist = new HashSet<string>();
            firstSetlist.Add("My Best Friend's Girlfriend");
            firstSetlist.Add("Thick as a Brick");
            firstSetlist.Add("Kashmir");
            firstSetlist.Add("Blue Suede Shoes");
            firstSetlist.Add("Master Blaster");
            firstSetlist.Add("Fly by Night");

            HashSet<string> secondSetlist = new HashSet<string>();
            secondSetlist.Add("Born in the USA");
            secondSetlist.Add("Goody-Two-Shoes");
            secondSetlist.Add("Jump");
            secondSetlist.Add("Workin' for the Weekend");
            secondSetlist.Add("Jenny Jenny");
            secondSetlist.Add("She's a Beauty");

            HashSet<string> thirdSetlist = new HashSet<string>();
            thirdSetlist.Add("Paperback Writer");
            thirdSetlist.Add("My Best Friend's Girlfriend");
            thirdSetlist.Add("And She Was");
            thirdSetlist.Add("Master Blaster");
            thirdSetlist.Add("Play That Funky Music");
            thirdSetlist.Add("Night Moves");

            Console.WriteLine("Combined list of the first and second setlists:");
            Console.WriteLine();

            firstSetlist.UnionWith(secondSetlist);
            foreach (string song in firstSetlist)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();

            Console.WriteLine("Songs that are in more than one setlist");
            HashSet<string> bothLists = new HashSet<string>();
            bothLists = firstSetlist;
            bothLists.IntersectWith(thirdSetlist);
            foreach (string song in bothLists)
            {
                Console.WriteLine(song);
            }
        }
    }
}
