using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    int myPoint = 0;
    // Start is called before the first frame update
    static PointManager _instance = null;
    public static PointManager instance()
    {
        return _instance;
    }

    private void Awake()
    {
        if(_instance ==null)
        {
            _instance = this;
        }
    }

    public void AddPoint(int num)
    {
        myPoint = myPoint + num;
    }

    public int GetPoint()
    {
        return myPoint;
    }

}
