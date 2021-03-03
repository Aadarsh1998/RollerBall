using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallCollision : MonoBehaviour
{
    public Material[] wallMat;
    Renderer rend;
    public Text displayText;
    //public Text displayText2;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        displayText.text = "";
        //displayText2.text = "";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall") 
        {
            displayText.text = "Player 1 hit the wall";
            rend.sharedMaterial = wallMat[1];
        }
        //if (collision.gameObject.name == "ball2")
        //{
        //    displayText2.text = "Player 2 hit the wall";
        //    rend.sharedMaterial = wallMat[1];
        //}
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag=="Wall")
        {
            rend.sharedMaterial = wallMat[0];
            displayText.text = "Player 1 keep rolling";
        }
        //if (collision.gameObject.name == "ball2")
        //{
        //    rend.sharedMaterial = wallMat[0];
        //    displayText2.text = "Player 2 keep rolling";
        //}
    }
}
