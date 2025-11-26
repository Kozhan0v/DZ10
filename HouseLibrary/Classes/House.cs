using System;

namespace HouseLibrary
{
    internal class House
    {
        private static short _staticHouseNum = 0;
        public short HouseNum { get; private set; }
        public double Height { get; private set; }
        public short NumberOfFloors { get; private set; }
        public short NumberOfFlats { get; private set; }
        public short NumberOfEntrances { get; private set; }

        public House()
        {
            HouseNum = CreateNewHouseNum();
        }

        public House(double height)
        {
            HouseNum = CreateNewHouseNum();
            Height = height;
        }

        public House(short numberOfFloors)
        {
            HouseNum = CreateNewHouseNum();
            NumberOfFloors = numberOfFloors;
        }

        public House(double height, short numberOfFloors)
        {
            HouseNum = CreateNewHouseNum();
            Height = height;
            NumberOfFloors = numberOfFloors;
        }

        public House(double height, short numberOfFloors, short numberOfFlats, short numberOfEntrances)
        {
            HouseNum = CreateNewHouseNum();
            Height = height;
            NumberOfFloors = numberOfFloors;
            NumberOfFlats = numberOfFlats;
            NumberOfEntrances = numberOfEntrances;
        }
        private short CreateNewHouseNum()
        {
            return ++_staticHouseNum;
        }

        public double CalcHeightOfFloor()
        {
            return NumberOfFloors == 0 ? 0 : Height / NumberOfFloors;
        }

        public short CalcFlatsInEntrance()
        {
            return (short)(NumberOfEntrances == 0 ? 0 : NumberOfFlats / NumberOfEntrances);
        }

        public short CalcFlatsOnFloor()
        {
            return (short)(NumberOfFloors == 0 ? 0 : CalcFlatsInEntrance() / NumberOfFloors);
        }
    }
}
