using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class MotorCycleBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }

    public MotorCycleBuilder()
    {
        _vehicle = new Vehicle(VehicleType.MotorCycle);
    }

    public void BuildFrame()
    {
        _vehicle.AddPart("¾Ë·ç¹Ì´½");
    }

    public void BuildEngine()
    {
        _vehicle.AddPart("50¸¶·Â");
    }

    public void BuildWheels()
    {
        _vehicle.AddPart("¾Õ¹ÙÄû");

        _vehicle.AddPart("µÚ¹ÙÄû");
    }

}
