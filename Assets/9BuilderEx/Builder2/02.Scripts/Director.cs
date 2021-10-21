using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Engineeing
{
    public void Construct(IVehicleBuilder2 vehicleBuilder2)
    {
        vehicleBuilder2.BuildFrame();
        vehicleBuilder2.BuildWheels();
        vehicleBuilder2.BuildEngine();
    }
}

