using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BugTrackerAssignment_2.Models
{
    public static class ExtensionMethods
    {
        public static int ToAge(this DateTime today, DateTime birthday)
        {
        today = DateTime.Now;
        birthday = new DateTime(1990, 01, 01);
        birthday = new DateTime(1987, 05, 07);
        birthday = new DateTime(1975, 10, 10);
        int dayDifference = today.ToAge(birthday);
        if (dayDifference == 0)
        {
        Console.WriteLine("It is your birthday month this Today!");
        }
        else
         {
         Console.WriteLine("It will be your birthday in " + dayDifference + ".");
         }
        }

    }
}