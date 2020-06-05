using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableBabyHead : MonoBehaviour
{
    [SerializeField]
    private GameObject _babyHeadExplosion;

    [SerializeField]
    private AudioClip _explosionAudio;
        

    public void DestroyBabyHead ()
    {
        Instantiate(_babyHeadExplosion, transform.position, transform.rotation);

        AudioSource.PlayClipAtPoint(_explosionAudio, Camera.main.transform.position, 0.8f);

        Destroy(this.gameObject);    
        
    }

    private void Update()
    {
        if (transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

}
