using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    public GameObject panelFin; // Le menu fin (panel)
    public GameObject uiGolf;
    public GameObject camera;

    // si on touche un trigger
    void OnTriggerEnter(Collider other)
    {
        // Si le Tag du trigger est Ocean
        if(other.gameObject.tag == "Ocean")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        // Si le Tag du trigger est Fin
        if (other.gameObject.tag == "Fin")
        {
            // D�clencher fin de niveau
            uiGolf.SetActive(false);
            camera.GetComponent<BallCamera>().enabled = false;
            panelFin.SetActive(true);
            // R�cup�rer le niveau 
            // 0: menu, 1: neveau1, 2: niveau2,...
            int niveauActuel = SceneManager.GetActiveScene().buildIndex;
            // Sauvegarde le num�ro du dernier niveau termin�
            PlayerPrefs.SetInt("DernierNiveau", niveauActuel+1);
        }
    }
}
