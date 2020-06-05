using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostTrigger4 : MonoBehaviour
{
    [SerializeField]
    private GameObject _ghost;

    [SerializeField]
    private Collider _collider;

    [SerializeField]
    private Animator _animator;
    	
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                _ghost.SetActive(true);                 

                _collider.enabled = false;

                _animator.SetBool("hasPlayerTriggered", true);

                Destroy(this.gameObject, 39f);
            }
        }
    }
}
