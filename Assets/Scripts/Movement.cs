using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public abstract class Movement : MonoBehaviour
{
    protected float speed;

    public virtual void Walk(float x, float z)
    {
        Debug.Log("Caminhando");
        transform.position += new Vector3(x, 0 , z);
    }

    public virtual void Jump()
    {
        Debug.Log("Pulando");
    }

    public virtual void Dash()
    {
        Debug.Log("Dashou");
    }
}