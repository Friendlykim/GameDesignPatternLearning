using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit
{
    public abstract void move();
}

public class Marine : Unit
{
    public Marine()
    {
        Debug.Log("Marine积己");
    }

    public override void move()
    {
        Debug.Log("Marine 捞悼!!!");
    }
}

public class Firebat : Unit
{
    public Firebat()
    {
        Debug.Log("Firebat积己");
    }

    public override void move()
    {
        Debug.Log("Firebat捞悼!!!");
    }
}

public class Medic : Unit
{
    public Medic()
    {
        Debug.Log("Medic积己");
    }

    public override void move()
    {
        Debug.Log("Medic捞悼!!!");
    }
}
