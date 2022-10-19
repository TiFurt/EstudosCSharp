using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public static class MajorityElement
    {
        public static int majorityElement(this int[] nums)
    {
        Array.Sort(nums);
        (int Number, int Rep) major = (nums[0], 1);
        int count = 1;
        for (int i = 1; i < nums.Length-1; i++)
        {
            if (major.Number == nums[i])
            {
                major.Rep++;
                
            }
            else
            {
                if (nums[i] == nums[i+1])
                {
                    count++;
                }else
                {
                    count = 1;
                }
                if (count > major.Rep)
                {
                    major = (nums[i], count);
                }
            }
        }
        return major.Number;
    }
    }
}