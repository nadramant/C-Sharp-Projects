using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicle
    {
        public enum eLicenseType
        {
            A, A1, AA, B
        }

        private eLicenseType m_LicenseType;
        private int m_EngineCapacity;
    }
}
