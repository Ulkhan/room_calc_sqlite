using System;
using Room_Calc;

namespace Room_Calc
{
    public class RoomSet : IRoomSetResponse
    {

        public string GetRoom(Room room)
        {
            float area = room.length * room.width;
            string desc = area + " m^2 " + room.type + " needed.";
            float total = area * (room.tPrice + room.colorPrice);
            float salary = room.employees * room.empSalary;
            float money = salary + total;
            return "CalcResult.aspx?area=" + area + "&desc=" + desc + "&total=" + total + "&color=" + room.color + "&worker=" + room.employees + "&salary=" + salary + "&money=" + money;
        }
    }
}

