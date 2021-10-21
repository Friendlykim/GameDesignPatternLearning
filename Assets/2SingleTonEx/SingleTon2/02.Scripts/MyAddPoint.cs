using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAddPoint : MonoBehaviour
{
    public int myNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        MyFunc();
    }

void MyFunc()
    {
        PointManager.instance().AddPoint(myNum);
        int myResult = PointManager.instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }
}
