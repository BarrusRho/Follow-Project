using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCleanup : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(this.gameObject, 20f);
        }
    }

}
