using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D playerRb;
    private SpriteRenderer playerSprite;
    public float velocidade;
    public bool flipX;


    // Use this for initialization
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        playerSprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //0 - botao esquerdo, 1-botao direito, 2 -scroll
        if (Input.GetMouseButtonDown(0))
        {
            velocidade *= -1;
            flipX = !flipX;
            playerSprite.flipX = flipX;
        }



        //Andar
        playerRb.velocity = new Vector2(velocidade, playerRb.velocity.y);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.ToUpper() == "ESPINHO")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag.ToUpper() == "ESPINHO")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
