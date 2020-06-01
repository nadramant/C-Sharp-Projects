using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public abstract class Vehicle
    {
        public enum eVehicleType
        {
           Car = 1, Motorcycle, Truck
        }

        public const int k_NumOfLettersInLicense = 8; // think about other access maybe
        protected string m_ModelName;
        protected readonly string m_LicenseNumber;
        protected float m_PercentOfEnergyRemaining = 0;
        protected Engine m_Engine;
        protected List<Wheel> m_Wheels;

        public int NumOfLettersInLicense
        {
            get
            {
                return k_NumOfLettersInLicense;
            }
        }
    }
}
