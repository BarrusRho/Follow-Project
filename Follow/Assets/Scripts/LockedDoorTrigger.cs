using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorTrigger : MonoBehaviour
{       
    private Animator _animator = null;

    [SerializeField]
    private AudioClip _doorOpeningAudio;

    [SerializeField]
    private GameObject _lockedDoor;

    [SerializeField]
    private Collider _collider;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                //AudioSource audio = GetComponent<AudioSource>();
                AudioSource.PlayClipAtPoint(_doorOpeningAudio, _lockedDoor.transform.position);

                _animator.SetBool("hasPlayerTriggered", true);

                _collider.enabled = false;
            }
        }
    }
    
}
