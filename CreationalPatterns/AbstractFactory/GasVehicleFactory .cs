﻿using DesignPatterns.CreationalPatterns.AbstractFactory.BikeGroup;
using DesignPatterns.CreationalPatterns.AbstractFactory.VehicleGroup;

namespace DesignPatterns.CreationalPatterns.AbstractFactory;

internal class GasVehicleFactory : IVehicleFactory
{
    public IBike CreateBike()
    {
        return new GasBike();
    }

    public ICar CreateCar()
    {
        return new GasCar();
    }
}
