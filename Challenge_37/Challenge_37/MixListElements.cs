using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_37
{
    static class MixListElements
    {
        /*
         აღნიშნული მეთოდი ერეილისტის ელემენტებს ურევს და სხვადასხვა თანმიმდევრობით აბრუნებს
        */
        public static ArrayList Blend(this ArrayList mainList)
        {
            ArrayList newArrayList = new ArrayList();
            while(mainList.Count != 0)
            {
                newArrayList.AddElementAndRemove(mainList);
            }
            return newArrayList;
        }
        /*
        აღნიშნული ფუნქცია მეორე მასივიდან ელემენტს რანდომულად ჩაწერს პირველ მასივში და ამ ელემენტს 
        მასივიდან შლის.
        */
        private static void AddElementAndRemove(this ArrayList main, ArrayList other)
        {
            Random rand = new Random();
            var element = other[rand.Next(0, other.Count)];
            other.Remove(element);
            main.Add(element);
        }
    }
}
