using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_UnitManager : MonoBehaviour
{
    public int setcloneHp;
    public int setcloneAp;

    // Start is called before the first frame update
    void Start()
    {
        PMarine marine = new PMarine();
        marine.Hp = 25;
        marine.Ap = 5;

        PMarine marineclone = (PMarine)marine.Clone();
        marineclone.Hp = setcloneHp;
        marineclone.Ap = setcloneAp;

        Debug.Log("MarineDetail");
        Debug.LogFormat("Age: {0} / Ap : {1}", marine.Hp, marine.Ap);

        Debug.Log("CloneDetail");
        Debug.LogFormat("Age: {0} / Ap : {1}", marineclone.Hp, marineclone.Ap);


    }

}
