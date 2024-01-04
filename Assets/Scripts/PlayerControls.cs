using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    /* nessa classe vai ser preciso definir qual o tipo de personagem que o jogador escolheu
    e com isso, definir qual o tipo de movimento e tipo de ataque, qual as limitações e vantagens
    nas ações */

    [SerializeField] ClassType classType;

    public void Start()
    {
        classType = new TankerClass(10, new SlowMovement());
    }

    public void Update()
    {
        float x, z;

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        classType.MovementType.Walk(x, z);
    }
}
