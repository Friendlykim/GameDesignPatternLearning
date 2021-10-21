using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vechicle : MonoBehaviour
{
    private VechicleType vehicleType;

    public void setVehicleType(VechicleType vehicleType)
    {
        this.vehicleType = vehicleType;
    }

    public void AddPart(GameObject part, Vector3 localPos)
    {
        GameObject obj = Instantiate(part) as GameObject;
        obj.transform.localPosition = localPos;
        obj.transform.SetParent(this.transform);
    }

    public string GetPartList()
    {
        string partList = vehicleType.ToString() + "parts:\n\t";

        Transform[] trs = GetComponentsInChildren<Transform>();
        for (int i = 1; i< trs.Length; i++)
        {
            partList += trs[i].gameObject.name + " ";
        }
        return partList;
    }

}
