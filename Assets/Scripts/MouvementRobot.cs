using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

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
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        direction = new Vector2(horizontal, vertical).normalized;
    }

    private void FixedUpdate()
    {
        // TODO : déplacer le robot en tenant compte du temps physique.
        corps.MovePosition(corps.position + direction * vitesse * Time.fixedDeltaTime);
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
