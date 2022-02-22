using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Grounded : MonoBehaviour
{
    GameObject Player;
    public static int nivel = 0;
    public static bool gano = false;
    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }  
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded= true;
        } else if (collision.collider.tag == "Victoria")
        {
            gano = true;
            nivel = SceneManager.GetActiveScene().buildIndex; 
            SceneManager.LoadScene(6);
        }
    }
        void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground"){
            Player.GetComponent<PlayerMoveScript>().isGrounded= false;
        }
    }
}
