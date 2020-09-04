using System;
using System.Collections.Generic;
using System.Linq;
//1108. Defanging an IP Address
namespace UnitTestProject1
{

    public class UnitTest1
    {
        public static void Main()
        {
            var sol = new UnitTest1();

            Console.WriteLine(sol.NumJewelsInStones("1.1.1.1"));
            Console.Read();

        }
        public String NumJewelsInStones(String address)
        {
            List<String> list2 = new List<String>() { };

            for (int i = 0; i < address.Length; i++){
                if (address[i] == '.') {
                    list2.Add("[.]");

                }
                else{
                    list2.Add(address[i].ToString());
                }


            }
            object obj = "";
            string str;
            str = obj.ToString();
            foreach (string ii in list2) { 
                str += ii;
            }
            return str;

        }

    }
}
