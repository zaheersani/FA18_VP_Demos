using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Routine
    {
        public void wakeup() { Console.WriteLine("wakeup"); }
        public void offerFajr() { Console.WriteLine("offer Fajr"); }
        public void breakfast() { Console.WriteLine("Having Breakfast"); }
        public void gotoWork() { Console.WriteLine("Going to Work :("); }
        public static void lunch() { Console.WriteLine("lunch time"); }
        public void sportsTime() { }
        public void dinner() { }
        public void WatchTV() { }
        public void GotoBed() { }
        public void GotoHiking() { }
        public void GotoPicnic() { Console.WriteLine("Picnic time, yaaay"); }
        public void FamilyTime() { }
    }

    class Activity
    {
        Routine routine = new Routine();
        delegate void FunTime();
        FunTime delStayHome;
        public Activity()
        {
            this.delStayHome += routine.wakeup;
            this.delStayHome += routine.offerFajr;
            this.delStayHome += routine.breakfast;
            this.delStayHome += routine.GotoPicnic;
            this.delStayHome += Routine.lunch;
        }
        public void WhatToDoToday(DayOfWeek day)
        {
            if (day == DayOfWeek.Monday)
            {
                this.GoingToWork();
                //routine.wakeup();
                //routine.offerFajr();
                //routine.breakfast();
                //routine.gotoWork();
            }
            else if (day == DayOfWeek.Sunday)
            {
                this.delStayHome();
                //routine.wakeup();
                //routine.offerFajr();
                //routine.breakfast();
                //routine.GotoPicnic();
            }
        }
        private void GoingToWork()
        {
            routine.wakeup();
            routine.offerFajr();
            routine.breakfast();
            routine.gotoWork();
        }
    }
}
