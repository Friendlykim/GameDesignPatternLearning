using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IVehicleBuilder2
{
    Vechicle GetVechicle();

    void BuildFrame();
    void BuildEngine();
    void BuildWheels();
}

public enum VechicleType
{
    Car2,
    MotorCycle2
}