using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance; 
    //public Rigidbody2D playerRigidBody2d; Public can be access by other classes and show on the inspector.
    [SerializeField] Rigidbody2D playerRigidBody; //SerializedField shows on the inspector but can't be access by other classes
    [SerializeField] float moveSpeed = 1;
    [SerializeField] Animator playerAnimator;
    public string transformPosition;


    // Start is called before the first frame update
    void Start()
    {
        if(instance != null && instance != this) //Singleton Pattern
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);   
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRigidBody.velocity = new Vector2(horizontalInput, verticalInput) * moveSpeed;
        playerAnimator.SetFloat("movementX", playerRigidBody.velocity.x);
        playerAnimator.SetFloat("movementY", playerRigidBody.velocity.y);


    }
}
