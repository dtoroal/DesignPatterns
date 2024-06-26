﻿using DesignPatterns.CreationalPatterns.FactoryMethod.Vehicles;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    internal class FactoryMethod
    {
        public IVehicle CreateVehicle(string patternName)
        {
            return patternName.ToUpper() switch
            {
                "SHIP" => new Ship(),
                "CAR" => new Car(),
                _ => new DefaultVehicle(),
            };
        }
    }
}
