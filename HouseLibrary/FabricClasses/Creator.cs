using System;
using System.Collections;

namespace HouseLibrary
{
    public class Creator
    {
        public static Hashtable HouseTable { get; private set; }

        static Creator()
        {
            HouseTable = new Hashtable();
        }

        public static short CreateBuild()
        {
            House house = new House();
            HouseTable.Add(house.HouseNum, house);
            return house.HouseNum;
        }

        public static short CreateBuild(double height)
        {
            House house = new House(height);
            HouseTable.Add(house.HouseNum, house);
            return house.HouseNum;
        }

        public static short CreateBuild(short numberOfFloors)
        {
            House house = new House(numberOfFloors);
            HouseTable.Add(house.HouseNum, house);
            return house.HouseNum;
        }

        public static short CreateBuild(double height, short numberOfFloors)
        {
            House house = new House(height, numberOfFloors);
            HouseTable.Add(house.HouseNum, house);
            return house.HouseNum;
        }

        public static short CreateBuild(double height, short numberOfFloors, short numberOfFlats, short numberOfEntrances)
        {
            House house = new House(height, numberOfFloors, numberOfFlats, numberOfEntrances);
            HouseTable.Add(house.HouseNum, house);
            return house.HouseNum;
        }

        public static void DestroyBuild(short houseNum)
        {
            HouseTable.Remove(houseNum);
        }
    }
}
