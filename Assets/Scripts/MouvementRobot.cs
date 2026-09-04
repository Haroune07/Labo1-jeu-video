using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MouvementRobot : MonoBehaviour
{
    [SerializeField] private float vitesse = 5f;

    private Rigidbody2D corps;
    private Vector2 direction;

    private void Awake()
    {
        corps = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // TODO : reconstruire la lecture des commandes et la direction normalisée.
    }

    private void FixedUpdate()
    {
        // TODO : déplacer le robot en tenant compte du temps physique.
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Les lignes ne sont pas dans le bon ordre.
     *
     * direction = new Vector2(horizontal, vertical).normalized;
     * float horizontal = Input.GetAxisRaw("Horizontal");
     * corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
     * float vertical = Input.GetAxisRaw("Vertical");
     */
}
