using Unity.VisualScripting;
using UnityEngine;

//DIRECCION VELOCIDAD TIME DELTA TIME
public class Bullet : MonoBehaviour
{
    public float Speed;
    void Start()
    {
        // transform.up = Vector2.left + Vector2.down;
        Destroy(gameObject, 5);
    }


    void Update()
    {
        transform.position += transform.up * Speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //->agregar que ignore ser destruidas por otras balas
        if (collision.tag != "Player" && collision.tag != "Bullet")
            Destroy(gameObject);
    }
}
