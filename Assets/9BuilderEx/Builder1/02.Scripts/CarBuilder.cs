using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CarBuilder : IVehicleBuilder
{
    private Vehicle _vehicle;

    public Vehicle GetVehicle()
    {
        return _vehicle;
    }

    public CarBuilder()
    {
        _vehicle = new Vehicle(VehicleType.Car);
    }

    public void BuildFrame()
    {
        _vehicle.AddPart("°­Ã¶");
    }

    public void BuildEngine()
    {
        _vehicle.AddPart("100¸¶·Â");
    }

    public void BuildWheels()
    {
        _vehicle.AddPart("¾Õ.¿ŞÂÊ ¹ÙÄû");
        _vehicle.AddPart("¾Õ.¿À¸¥ÂÊ ¹ÙÄû");
        _vehicle.AddPart("µÚ.¿ŞÂÊ ¹ÙÄû");
        _vehicle.AddPart("µÚ.¿À¸¥ÂÊ ¹ÙÄû");
    }

}
