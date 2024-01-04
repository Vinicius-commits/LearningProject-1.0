using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ClassType : MonoBehaviour
{
    [SerializeField] protected float lifePoints;
    [SerializeField] protected Movement movementType;

    public Movement MovementType { get { return movementType; } }

    public virtual void Deffense()
    {

    }

    public virtual void Attack()
    {

    }
}
