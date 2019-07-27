using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            // Enter numbers
            int[] nums = new int[7];
            Console.WriteLine("Write seven numbers");

            for(int i = 0; i<nums.Length; i++)
            {

                Console.Write("{0} number: ", i + 1);
                nums[i] = Int32.Parse(Console.ReadLine());

            }

            // Sorting numbers 

            int temp;
            for (int i = 0; i < nums.Length-1; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                    if (nums[i] > nums[j])
                    {

                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;

                    }

                }

            }

            //output

            Console.WriteLine("Output sorted massive");

            for (int i = 0; i < nums.Length; i++)
            {

                Console.WriteLine(nums[i]);

            }

            Console.ReadLine();


        }
    }
}
