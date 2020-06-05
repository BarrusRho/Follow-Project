using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _babyHead;

    [SerializeField]
    private GameObject _key;

    [SerializeField]
    private AudioClip _cryingBabyAudio;

    [SerializeField]
    private AudioClip _keySpawnAudio;

    public Transform keySpawnPoint;

    public Transform[] spawnPoints;


    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));

        Instantiate(_babyHead, spawnPoints[Random.Range(0, spawnPoints.Length)].position, Quaternion.identity);

        AudioSource.PlayClipAtPoint(_cryingBabyAudio, Camera.main.transform.position, 0.5f);

        StartCoroutine(StartSpawning());

        Destroy(this.gameObject, 60f);

    }

    IEnumerator KeySpawn()
    {
        yield return new WaitForSeconds(59.5f);

        Instantiate(_key, keySpawnPoint.position, Quaternion.identity);

        AudioSource.PlayClipAtPoint(_keySpawnAudio, Camera.main.transform.position);      

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(KeySpawn());

            StartCoroutine(StartSpawning());
        }
    }

}
