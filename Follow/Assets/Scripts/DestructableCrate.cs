using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableCrate : MonoBehaviour
{
    [SerializeField]
    private GameObject _crateDestroyed;

    [SerializeField]
    private AudioClip _breakingCrateAudio;

    public void DestroyCrate ()
    {
        Instantiate(_crateDestroyed, transform.position, transform.rotation);

        AudioSource.PlayClipAtPoint(_breakingCrateAudio, Camera.main.transform.position);

        Destroy(this.gameObject);
    }
}
