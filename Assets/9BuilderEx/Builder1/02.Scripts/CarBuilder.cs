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
        _vehicle.AddPart("��ö");
    }

    public void BuildEngine()
    {
        _vehicle.AddPart("100����");
    }

    public void BuildWheels()
    {
        _vehicle.AddPart("��.���� ����");
        _vehicle.AddPart("��.������ ����");
        _vehicle.AddPart("��.���� ����");
        _vehicle.AddPart("��.������ ����");
    }

}
