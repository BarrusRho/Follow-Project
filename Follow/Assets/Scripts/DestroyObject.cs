using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _light;

    [SerializeField]
    private GameObject _light2;

    [SerializeField]
    private GameObject _light3;

    public bool lightIsOff;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && lightIsOff)
        {
            lightIsOff = false;

            _light.SetActive(true);
            _light2.SetActive(true);
            _light3.SetActive(true);

            Destroy(this.gameObject);
        }
    }
   
}
