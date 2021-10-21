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
        Debug.Log("Marine����");
    }

    public override void move()
    {
        Debug.Log("Marine �̵�!!!");
    }
}

public class Firebat : Unit
{
    public Firebat()
    {
        Debug.Log("Firebat����");
    }

    public override void move()
    {
        Debug.Log("Firebat�̵�!!!");
    }
}

public class Medic : Unit
{
    public Medic()
    {
        Debug.Log("Medic����");
    }

    public override void move()
    {
        Debug.Log("Medic�̵�!!!");
    }
}
