using System;
using System.Collections.Generic;
using UnityEngine;

class CarBuilders : MonoBehaviour, IVehicleBuilder2
{
    public GameObject ParentVehicle;
    public GameObject frame;
    public GameObject engine;
    public GameObject wheel1;
    public GameObject wheel2;
    public GameObject wheel3;
    public GameObject wheel4;

    private Vechicle _vehicle;

    public Vechicle GetVechicle()
    {
        return _vehicle;
    }

    public void makeVehicle()
    {
        GameObject obj = Instantiate(ParentVehicle) as GameObject;
        _vehicle = obj.GetComponent<Vechicle>();
        _vehicle.setVehicleType(VechicleType.Car2);

        
    }

    public void BuildFrame()
    {
        _vehicle.AddPart(frame, Vector3.zero);
    }
    public void BuildEngine()
    {
        _vehicle.AddPart(engine, new Vector3(0, 0.5f, 0));
    
    }
    public void BuildWheels()
    {
        _vehicle.AddPart(wheel1, new Vector3(0.75f, -0.5f, 0.5f));
        _vehicle.AddPart(wheel2, new Vector3(-0.75f, -0.5f, 0.5f));
        _vehicle.AddPart(wheel3, new Vector3(-0.75f, -0.5f, -0.5f));
        _vehicle.AddPart(wheel4, new Vector3(0.75f, -0.5f, -0.5f));
    }
}

