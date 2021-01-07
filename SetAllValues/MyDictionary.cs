using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The provided implementation of a data structure for which 
 * Get(int index), 
 * Set(int index, int value), 
 * and SetAll(int value) are all O(1).
 */

namespace SetAllValues
{
    public class MyDictionary : Dictionary<int, MyData>
    {
        //Addes a key and a value
        public void Add(int key, int value)
        {
            MyData data = new MyData();
            data.Value = value;
            this.Add(key, data);
        }

        //Gets the value of a key or returns 0 if no key exists 
        //In case the GlobalCounter is greater than the keys counter update the value to GlobalVal
        public int Get(int key)
        {
            MyData data;
            if (this.TryGetValue(key, out data))
            {
                if (Globals.GlobalCounter > 0 && data.Counter != Globals.GlobalCounter)
                {
                    Set(key, Globals.GlobalVal, true);
                    return Globals.GlobalVal;
                }
                else
                {
                    return data.Value;
                }
            }
            return 0;
        }

        //Sets a value of a key if the key exists
        public void Set(int key, int value, bool SetAllFlag = false)
        {
            if (this.ContainsKey(key))
            {
                this[key].Value = value;
                if (SetAllFlag)
                {
                    this[key].Counter = Globals.GlobalCounter;
                }
            }
            else
            {
                Console.WriteLine("cannot set a value to {0} key because it does not exist", key);
            }
        }

        //Set the GlobalVal and increase GlobalCounter
        public void SetAll(int value)
        {
            Globals.GlobalVal = value;
            Globals.GlobalCounter++;
        }

        //Print the key and matching value
        public void PrintValueOfKey(int key)
        {
            int val = this.Get(key);
            if (val > 0)
            {
                Console.WriteLine("performing get Key = {0}, Value = {1}", key, val);
            }
            else
            {
                Console.WriteLine("cannot get a value to {0} key because it does not exist", key);
            }
        }

        //Print all keys and corresponding values
        public void PrintDictionary()
        {
            Console.WriteLine("----------------------printing dictionary----------------------");
            foreach (KeyValuePair<int, MyData> item in this)
            {
                PrintValueOfKey(item.Key);
            }
            Console.WriteLine("----------------------end of dictionary----------------------");
        }
    }
}
