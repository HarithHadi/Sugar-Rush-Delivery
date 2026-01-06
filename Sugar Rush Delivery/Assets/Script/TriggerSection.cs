using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] MapSection;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Trigger")) 
        { 
            int randomindex = Random.Range(0, MapSection.Length);
            Instantiate(MapSection[randomindex], new Vector3(0, 0, 208.4f), Quaternion.identity);
        }

    }
}
