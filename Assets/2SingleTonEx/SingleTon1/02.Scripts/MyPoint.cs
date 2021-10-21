using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPoint : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
     if(Input.GetButtonDown("Fire1"))
        {
            int nResult = AudioManager.Instance().GetPoint();
            Debug.Log("My Point : " + nResult);
        }
    }
}
