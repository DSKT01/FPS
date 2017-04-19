using UnityEngine;
using System.Collections;

public class Disparar : MonoBehaviour {

    [SerializeField]
    private GameObject Bala;
	// Use this for initialization
	void Start () {
        StartCoroutine(spawnear(2f));
	}
	private IEnumerator spawnear (float time)
    {
        yield return new WaitForSeconds(time);
        GameObject.Instantiate(Bala);
    }
	
}
