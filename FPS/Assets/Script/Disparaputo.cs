using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class Disparaputo : MonoBehaviour
{
   private void OnColliderEnter(Collider otherCollision)
    {
        if (otherCollision.tag.Equals("Player"))
        {
            Debug.Log("El proyectil choco con el player");
        }
        else if (otherCollision.tag.Equals("Enemy"))
        {
            Debug.Log("El proyectil choco con el Enemigo");
        }

        Destroy(this);
    }
}
