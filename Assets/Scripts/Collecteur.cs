using UnityEngine;

public class Collecteur : MonoBehaviour
{
    [SerializeField] private int objectif = 3;
    [SerializeField] private GameObject porteSortie;

    private int batteriesCollectees = 0;

    private void Start()
    {
        // TODO : valider la référence, puis cacher la porte au démarrage.
        porteSortie.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // TODO : ignorer les objets qui ne sont pas des batteries.
        if (autre.CompareTag("Batterie"))
        {
            batteriesCollectees++;
            Debug.Log($"Batteries : {batteriesCollectees}/{objectif}");
            Destroy(autre.gameObject);

            if (batteriesCollectees >= objectif)
            {
                if (porteSortie == null)
                {
                    Debug.LogError("La porte de sortie n'est pas assignée.");
                    return;
                }

                porteSortie.SetActive(true);
                Debug.Log("PORTE DÉVERROUILLÉE !");
            }
        }
        // TODO : ramasser la batterie et mettre le compteur à jour.
        // TODO : déverrouiller la porte lorsque l'objectif est atteint.
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * Certaines lignes doivent être placées à l'intérieur d'un if.
     * Ajoutez les accolades et l'indentation nécessaires.
   
     */
}
