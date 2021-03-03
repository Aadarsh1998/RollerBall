//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class BallRoller2 : MonoBehaviour
//{
//    public float speed;
//    Rigidbody rb2;
//    // Start is called before the first frame update
//    void Start()
//    {
//        rb2 = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        float horizontalMovement = Input.GetAxis("newHorizontal");
//        float verticalMovement = Input.GetAxis("newVertical");
//        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
//        rb2.AddForce(movement * speed * Time.deltaTime);
//    }
//}
