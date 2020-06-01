using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Car : Vehicle
    {
        public enum eCarColor
        {
            Red, White, Black, Silver
        }

        public enum eNumOfDoors
        {
            twoDoors, ThreeDoors, FourDoors, FiveDoors
        }

        private eNumOfDoors m_NumOfDoors;
        private eCarColor m_CarColor;
    }
}
