using System;
using System.Collections;
using System.Collections.Generic;

namespace leetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3,3 };

            Program pro = new Program();

            Console.WriteLine(pro.ContainsDuplicate(nums));
        }

        //public bool ContainsDuplicate(int[] nums)
        //{
        //    Hashtable hash = new Hashtable();

        //    foreach (var item in nums)
        //    {
        //        if (hash.Contains(item))
        //            return true;
        //        else
        //            hash.Add(item, null);
        //    }
        //    return false;
        //}

        public bool ContainsDuplicate(int[] nums)
        {

            foreach (var item in nums)
            {
                int[] num = { };

                if (Array.FindAll(num, u => u == item).Length > 1)
                {

                }
            }
            return false;
        }
    }
}
