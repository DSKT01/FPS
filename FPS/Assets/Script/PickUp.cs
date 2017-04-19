using UnityEngine;
using System.Collections;

public enum PickupType
{
    Health,
    Ammo,
    Key,
    Armor
}

public class PickUp : MonoBehaviour
{
    [SerializeField] private PickupType PickupType;
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.tag.Equals("Player"))
        {
            Debug.Log(string.Format("El player se choco con item de {0}", PickupType.ToString()));
        }
    }


}
