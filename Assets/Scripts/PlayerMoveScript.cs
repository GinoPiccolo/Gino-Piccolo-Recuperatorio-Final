using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMoveScript : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float camSweetSpot = 5.5f;
    public float moveSpeed = 5f;
    public float jumpForce = 5f;

    private Vector2 mouse_pos;
    public Transform target;
    private Vector2 object_pos;
    private float angle;
    float mx;
    public Renderer playerRenderer;
    public Camera cam;
    Vector2 mousePos;
    public bool isGrounded = false;
    void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if   (rb2d.transform.position.y < cam.transform.position.y - camSweetSpot) //si el pj es invisible y su posicion esta por debajo de la camara
        {
            DeathPlayer();
        }
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        mx = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        { 
            Jump();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            SceneManager.LoadScene(0);
        }
    }
    private void FixedUpdate() // esto sirve para trabajar con fisicas porque iguala el rendimiento del juego sin importar la máquina
        {   
            Vector2 movement = new Vector2(mx * moveSpeed, rb2d.velocity.y);
            rb2d.velocity = movement;
            mouse_pos = Input.mousePosition;                                    // este codigo es para rotar el transform de FirePoint basado en donde esta el puntero del mouse
            object_pos = Camera.main.WorldToScreenPoint(target.position); 
            mouse_pos.x = mouse_pos.x - object_pos.x;                     
            mouse_pos.y = mouse_pos.y - object_pos.y;                      
            angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg - 90f;
            target.transform.rotation = Quaternion.Euler(0, 0, angle);
        } 

        void Jump()
        {
             Vector2 movement = new Vector2(rb2d.velocity.x, jumpForce);
             rb2d.velocity = movement;
        } 

        void DeathPlayer()
        {
            SceneManager.LoadScene(1);
        }
}
