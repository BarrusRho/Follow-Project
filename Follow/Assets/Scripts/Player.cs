using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController _controller;

    [SerializeField]
    private float _speed = 3.5f;
    [SerializeField]
    private float _gravity = 9.81f;

    public bool hasKey = false;

    public bool hasLetters = false;

    private UIManager _uiManager;
	
	void Start ()
    {
        _controller = GetComponent<CharacterController>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
	}
	
	void Update ()
    {
        Movement();

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    Cursor.visible = true;
        //    Cursor.lockState = CursorLockMode.None;
        //}
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = direction * _speed;
        velocity.y -= _gravity;
        velocity = transform.transform.TransformDirection(velocity);
        _controller.Move(velocity * Time.deltaTime);
    }

    void Shoot()
    {
        Ray rayOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));        
        RaycastHit hitInfo;

        if (Physics.Raycast(rayOrigin, out hitInfo))
        {
            Debug.Log("Hit: " + hitInfo.transform.name);

            DestructableCrate crate = hitInfo.transform.GetComponent<DestructableCrate>();
            if (crate != null)
            {
                crate.DestroyCrate();
            }

            DestructableBabyHead babyHead = hitInfo.transform.GetComponent<DestructableBabyHead>();
            if (babyHead != null)
            {
                babyHead.DestroyBabyHead();
            }

        }

    }

}
