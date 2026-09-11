using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;
    [SerializeField] private EffetDegatsJoueur effetDegatsJoueur;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (!autre.CompareTag("Player")) return;

        if (pointDepart == null) Debug.LogError("Le point de départ n'est pas assigné.");
        if (pointDepart == null)
        {
            Debug.LogError("Le point de départ n'est pas assigné.");
            return;
        }

        effetDegatsJoueur?.JouerEffetDegat();
        autre.transform.position = pointDepart.position;
        Debug.Log("Le robot retourne au point de départ.");
    }
}
