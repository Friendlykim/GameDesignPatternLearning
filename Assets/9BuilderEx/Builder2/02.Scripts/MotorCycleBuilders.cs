using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorCycleBuilders : MonoBehaviour,IVehicleBuilder2
{
    public GameObject ParentOfVehicle;
    public GameObject frame;
    public GameObject engine;
    public GameObject wheels1;
    public GameObject wheels2;
    private Vechicle _vehicle;

    public Vechicle GetVechicle()
    {
        return _vehicle;
    }

    public void makeVehicle()
    {
        GameObject obj = Instantiate(ParentOfVehicle) as GameObject;
        _vehicle = obj.GetComponent<Vechicle>();
        _vehicle.setVehicleType(VechicleType.MotorCycle2);
    }
    public void BuildFrame()
    {
        _vehicle.AddPart(frame, Vector3.zero);
    }

    public void BuildEngine()
    {
        _vehicle.AddPart(engine,new Vector3(0,0.5f,0));
    }
    public void BuildWheels()
    {
        _vehicle.AddPart(wheels1,new Vector3(1.5f,0,0));
        _vehicle.AddPart(wheels2,new Vector3(-1.5f,0,0));
    }

}
