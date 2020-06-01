using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class FuelEngine : Engine
    {
        public enum eFuelType
        {
            Octan98,
            Octan96,
            Octan95,
            Soler
        }

        private eFuelType m_FuelTupe;
        private float m_CurrentAmountOfFuel;
        private float m_MaximumAmountOfFuel;

        public void Refuling(float i_AmountOfFuelToAdd, eFuelType i_FuelType)
        {

        }
    }
}
