using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IVehicleBuilder
{
    Vehicle GetVehicle();

    void BuildFrame();
    void BuildEngine();
    void BuildWheels();
}

public enum VehicleType
{
    Car,
    MotorCycle
}
