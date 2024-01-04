using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankerClass : ClassType
{
    public TankerClass(float lifePoints, Movement movementType) 
    {
        base.lifePoints = lifePoints;
        base.movementType = movementType;
    }

    public override void Attack()
    {
        base.Attack();
    }

    public override void Deffense()
    {
        base.Deffense();
    }
}
