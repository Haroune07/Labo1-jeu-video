using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (!autre.CompareTag("Player")) return;

        if (pointDepart == null) Debug.LogError("Le point de départ n'est pas assigné.");
        if (pointDepart == null)
        {
            Debug.LogError("Le point de départ n'est pas assigné.");
            return;
        }

        autre.transform.position = pointDepart.position;
        Debug.Log("Le robot retourne au point de départ.");
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * La ligne return; doit être utilisée aux deux endroits appropriés.
     *
     * autre.transform.position = pointDepart.position;
     * Debug.Log("Le robot retourne au point de départ.");
     * 
     */
}
