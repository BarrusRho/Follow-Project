using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _key;

    [SerializeField]
    private AudioClip _keySpawnAudio;

    public Transform keySpawnPoint;

    IEnumerator KeySpawn()
    {
        yield return new WaitForSeconds(5f);

        Instantiate(_key, keySpawnPoint.position, Quaternion.identity);

        AudioSource.PlayClipAtPoint(_keySpawnAudio, Camera.main.transform.position);

        //StartCoroutine(KeySpawn());

        //Destroy(this.gameObject, 10f);
               
    }

    private void OnTigggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(KeySpawn());
        }
    }
	
}
