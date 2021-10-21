using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilderUse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Engineer engineer = new Engineer();
        CarBuilder carbuilder = new CarBuilder();
        MotorCycleBuilder motorCycleBuilder = new MotorCycleBuilder();

        engineer.Construct(carbuilder);
        engineer.Construct(motorCycleBuilder);

        Vehicle car = carbuilder.GetVehicle();
        Debug.Log(car.GetPartsList());

        Vehicle motorcylce = motorCycleBuilder.GetVehicle();
        Debug.Log(motorcylce.GetPartsList());
    }


}
