using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    static class VehiclesCreator
    {
        public static Vehicle createCar(Vehicle.eVehicleType i_VehicleType, string i_lisence)
        {
            Vehicle vehicle;

            if (i_VehicleType == Vehicle.eVehicleType.Car)
            {
                vehicle = new Car();
            }
            else if (i_VehicleType == Vehicle.eVehicleType.Motorcycle)
            {
                vehicle = new Motorcycle();
            }
            else
            {
                vehicle = new Truck();
            }

            return vehicle;
        }
    }
}
