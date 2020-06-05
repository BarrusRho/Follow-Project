using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScareTrigger : MonoBehaviour
{   
    [SerializeField]
    private Image _jumpScare;

    [SerializeField]
    private Collider _collider;

    [SerializeField]
    private AudioClip _jumpScareAudio;

	// Use this for initialization
	
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                _jumpScare.enabled = true;

                AudioSource.PlayClipAtPoint(_jumpScareAudio, Camera.main.transform.position);

                _collider.enabled = false;

                Destroy(_jumpScare.gameObject, 0.5f);
            }
        }
    }
}
