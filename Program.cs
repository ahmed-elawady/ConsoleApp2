using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {

            string[] peopleLikes = new string[] { "Ahmed","Mohammed","Ragaa","mustafa"};
            List<string> peopleLikeList = peopleLikes.ToList<string>();
            int numperOfPeople = peopleLikeList.Count;
            string message = "" ;
            if (numperOfPeople == 0)
            {
                message = "no one likes this";
            }else if (numperOfPeople == 1)
            {
                message = $"{peopleLikeList[0]} likes this";
            }else if (numperOfPeople > 1 && numperOfPeople< 3)
            {
                message = $"{peopleLikeList[0]} and {peopleLikeList[1]} like this";
            }else if (numperOfPeople == 3 )
            {
                message = $"{peopleLikeList[0]}, {peopleLikeList[1]} and {peopleLikeList[2]} like this";
            }else if (numperOfPeople > 3 )
            {
                message = $"{peopleLikeList[0]}, {peopleLikeList[1]} and {numperOfPeople - 2} others like this";
            }

            Console.WriteLine(message);
        }


    }
}
