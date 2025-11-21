using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Target;   // El jugador
    public int Life = 3;
    public float speed = 3f;    // Velocidad del enemigo

    void Start()
    {
        // Busca al jugador por Tag
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (Target == null) return;

        // Dirección hacia el jugador
        Vector3 direction = Target.transform.position - transform.position;
        direction.Normalize();

        // Movimiento hacia el jugador
        transform.position += direction * speed * Time.deltaTime;

        // Hacer que el enemigo mire al jugador
       // transform.LookAt(Target.transform);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger entro: " + collision.tag);

        if (collision.tag == "Bullet")
        {
            Life--;
            if (Life <= 0)
                Destroy(gameObject);
        }
    }
    /* private void OnTriggerExit2D(Collider2D collision)
     {
         print("trigger salio");
     }
     private void OnTriggerStay2D(Collider2D collision)
     {
         print("trigger mantuvo");
     }*/
}
