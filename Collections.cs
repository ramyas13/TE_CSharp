using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    /// <summary>
    /// Collections -> type of class -> dynamic memory allocation -> store and retrieve data
    /// </summary>
    internal class Collections
    {
        /// <summary>
        /// Dictionary - generic->using System.Collections.Generic;
        /// key-value pair
        /// </summary>
        public static void Dictionary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(10, "Ten");
            dic.Add(20, "Twenty");
            dic.Add(30, "Thirty");
            dic.Add(40, "Fourty");
            Console.WriteLine("DICTIONARY");
            foreach (var obj in dic)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var key = new List<int>(dic.Keys);
            foreach (var obj in key)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            var values = new List<string>(dic.Values);
            foreach (var obj in values)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Key: {dic[40]}");

        }
        /// <summary>
        /// Hashtable -> class -> using System.Collections;
        /// not type specific
        /// key-value pair
        /// </summary>

        public static void Hashtable()
        {
            Hashtable h = new Hashtable();
            h.Add(1, "what");
            h.Add(2, "are");
            h.Add(3, "you");
            h.Add(4,"doing");
            h.Add(5, 1);
            Console.WriteLine("HASHTABLE");
            //ICollection Interface
            ICollection key = h.Keys;
            foreach (var obj in key)
            {
                Console.WriteLine(h[obj]);
            }
            Console.WriteLine($"Key: {h[4]}");
            Console.WriteLine($"Key: {h[2]}");//If the key is not found -> null value
        }

        public static void Main()
        {
            
            Dictionary();
            Console.WriteLine("-----------------------------------------");
            Hashtable();
        }

    }
}
