using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject _light;

    [SerializeField]
    private AudioClip _lightTurningOnAudio;

    public bool lightIsOff;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && lightIsOff)
        {
            lightIsOff = false;

            AudioSource.PlayClipAtPoint(_lightTurningOnAudio, _light.transform.position);

            _light.SetActive(true);
        }
    }

}
