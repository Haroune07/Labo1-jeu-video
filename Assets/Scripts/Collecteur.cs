using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO : valider la référence, puis cacher la porte au démarrage.
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer les objets qui ne sont pas des batteries.
        // TODO : ramasser la batterie et mettre le compteur à jour.
        // TODO : déverrouiller la porte lorsque l'objectif est atteint.
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Certaines lignes doivent être placées à l'intérieur d'un if.
     * Ajoutez les accolades et l'indentation nécessaires.
     *
     * Debug.Log("PORTE DÉVERROUILLÉE !");
     * return;
     * porteSortie.SetActive(false);
     * if (batteriesCollectees >= objectif)
     * batteriesCollectees++;
     * Debug.LogError("La porte de sortie n'est pas assignée.");
     * if (!autre.CompareTag("Batterie"))
     * porteSortie.SetActive(true);
     * Destroy(autre.gameObject);
     * if (porteSortie == null)
     * Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
     * return;
     */
}
