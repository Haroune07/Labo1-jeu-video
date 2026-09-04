using UnityEngine;

// Script facultatif : il sert uniquement à observer le cycle de vie de Unity.
public class TestRobot : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake : le robot est créé.");
    }

    private void Start()
    {
        Debug.Log("Start : le jeu commence.");
    }

    // Décommentez temporairement cette méthode pour observer Update.
    /*
    private void Update()
    {
        Debug.Log("Update : nouvelle image.");
    }
    */
}
