using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KhasanovRV.Sprint1.Task6.V17.Lib
{
    public class DataService : ISprint1Task6V17
    {
        public bool CheckPalindrome(string value)
        {
            value = value.ToLower();
            char[] arr = value.ToCharArray();
            Array.Reverse(arr);
            string value2 = new string(arr);
            if (String.Compare(value, value2) == 0)
                return true;
            else
                return false;
        }
    }
}
