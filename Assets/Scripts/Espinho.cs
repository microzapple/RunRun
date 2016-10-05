using UnityEngine;
using System.Collections;

public class Espinho : MonoBehaviour
{
    private Rigidbody2D espinhoRb;
    private int atrito;
    public int atritoMax;
    public int atritoMin;
    public Vector3 posicao;
    public GameObject espinhoPreFab;

    // Use this for initialization
    void Start()
    {
        espinhoRb = GetComponent<Rigidbody2D>();
        atrito = Random.Range(atritoMin, atritoMax);
        espinhoRb.drag = atrito;

        posicao = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        //Criar novos espinhos
        Instantiate(espinhoPreFab, posicao, transform.localRotation);
        Pontuacao.pontos += 1;
        //Destruir os anteriores
        Destroy(gameObject);
    }
}
