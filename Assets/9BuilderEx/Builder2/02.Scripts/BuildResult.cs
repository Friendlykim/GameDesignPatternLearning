using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildResult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Engineeing engineeing = new Engineeing();

        CarBuilders carBuilders = GetComponent<CarBuilders>();
        carBuilders.makeVehicle();

        MotorCycleBuilders motorCycleBuilders = GetComponent<MotorCycleBuilders>();
        motorCycleBuilders.makeVehicle();

        engineeing.Construct(carBuilders);
        engineeing.Construct(motorCycleBuilders);

        Vechicle car = carBuilders.GetVechicle();
        Debug.Log(car.GetPartList());

        Vechicle motorcycle = motorCycleBuilders.GetVechicle();
        Debug.Log(motorcycle.GetPartList());

        car.transform.position = new Vector3(-3f, 0, 0);
        motorcycle.transform.position = new Vector3(3f, 0, 0);
    }

}
