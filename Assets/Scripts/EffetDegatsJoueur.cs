using System.Collections;
using UnityEngine;

public class EffetDegatsJoueur : MonoBehaviour
{
    [Header("Robot")]
    [SerializeField] private SpriteRenderer renduRobot;

    [Header("Interface")]
    [SerializeField] private CanvasGroup flashEcran;

    [Header("Animation")]
    [SerializeField]
    private Color couleurDegat =
        new Color(1f, 0.25f, 0.25f);

    [SerializeField] private float dureeEffet = 0.45f;
    [SerializeField] private int nombreClignotements = 3;
    [SerializeField] private float agrandissement = 1.12f;

    private Coroutine animationEnCours;
    private Color couleurInitiale;
    private Vector3 tailleInitiale;

    private void Awake()
    {
        // TODO 1 : récupérer le SpriteRenderer s'il n'est pas assigné.
        if (renduRobot == null)
            renduRobot = GetComponent<SpriteRenderer>();
        // TODO 2 : mémoriser la couleur et la taille initiales.
        couleurInitiale = renduRobot.color;
        tailleInitiale = transform.localScale;
        // TODO 3 : cacher le flash au lancement.
        if (flashEcran != null)
            flashEcran.alpha = 0f;

    }

    public void JouerEffetDegat()
    {
        // TODO 4 : arrêter l'animation précédente, si elle existe.
        if (animationEnCours != null)
        {
            flashEcran.alpha = 0f;
            StopCoroutine(animationEnCours);
            animationEnCours = null;
        }

        // TODO 5 : démarrer la coroutine de dégâts.
        animationEnCours = StartCoroutine(AnimerDegat());
    }

    private IEnumerator AnimerDegat()
    {
        // TODO 6 : calculer la durée d'un clignotement.
        float dureeClignotement = dureeEffet / (nombreClignotements * 2f);
        // TODO 7 : afficher le flash.
        flashEcran.alpha = 0.35f;
        // TODO 8 : faire clignoter et agrandir le robot.

        for (int i = 0; i < nombreClignotements; i++)
        {
            if (flashEcran != null)
            {
                
                renduRobot.color = couleurDegat;
                transform.localScale = tailleInitiale * agrandissement;

                yield return new WaitForSeconds(dureeClignotement);

                transform.localScale = tailleInitiale;
                renduRobot.color = couleurInitiale;
            }
        }


        // TODO 9 : faire disparaître progressivement le flash.
        float progression = 0f;
        while (progression < 1f)
        {
            if (flashEcran != null)
            {
                progression += Time.deltaTime / 0.2f;
                flashEcran.alpha = Mathf.Lerp(0.35f, 0f, progression);
                yield return new WaitForSeconds(dureeClignotement);
            }
        }

        // TODO 10 : restaurer l'apparence et terminer proprement.
        if (flashEcran != null)
        {
            renduRobot.color = couleurInitiale;
            transform.localScale = tailleInitiale;
            flashEcran.alpha = 0f;
        }

        yield return null;
    }

    /*
     * BANQUE DE LIGNES — À REPLACER ET À INDENTER
     *
     * Toutes les lignes de la solution sont présentes.
     * Supprimez « yield break; » lorsque la coroutine est complétée.
     * Ajoutez les accolades des if, de la boucle for et de la boucle while.
     *
     * if (flashEcran != null)
     */
}
