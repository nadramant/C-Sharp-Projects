using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class VehicleInGarage
    {
        public enum eCarStatusInGarage
        {
            InRepair, Repaired, Paied
        }

        private string m_NameOfOwner;
        private string m_PhoneNumberOfOwner;
        private eCarStatusInGarage m_CarStatusInGarage = eCarStatusInGarage.InRepair;
        private Vehicle m_VechileInGarage;
    }
}
