using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMovement : Movement
{
    public SlowMovement()
    {
        speed = 3.0f;
    }

    public override void Walk(float x, float z)
    {
        transform.position += new Vector3(x, 0, z) * speed * Time.deltaTime;
    }
}
