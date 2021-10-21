using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    IUnit Clone();
}

public class PMarine : IUnit
{
    public int Hp { get; set; }
    public int Ap { get; set; }

    public IUnit Clone()
    {
        return this.MemberwiseClone() as IUnit;
    }
}
