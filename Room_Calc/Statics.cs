using System;
using System.Collections.Generic;

namespace Room_Calc
{
    public class Statics
    {
         public List<Item> items = new List<Item>();
        
        
        public Statics()
        {

        }

        
    }
}

public struct Item
{
    public int type;
    public string desc;
    public string id;
    public string defaultValue;

}