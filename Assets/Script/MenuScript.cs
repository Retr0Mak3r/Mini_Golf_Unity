using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MenuScript : MonoBehaviour
{
    Button[] btns;

    public void LoadSelectedLevel(int level)
    {
        SceneManager.LoadScene(level);

    }

    private void Start()
    {
        int lastLevel = PlayerPrefs.GetInt("DernierNiveau"); // on r�cup�re le dernier niveau d�bloqu�
        btns = GameObject.FindObjectsOfType<Button>(); // on r�cup�re tous les objets de type Button
        foreach(Button btn in btns) // on boucle sur chaque btn de btns
        {
            Debug.Log(lastLevel);
            // la fonction int.Parse convertit son param�tre en entier
            // On acc�de au premier enfant (d'index 0) de btn qui est un composant text
            int level = int.Parse(btn.transform.GetChild(0).gameObject.GetComponent<Text>().text);

            if (level <= lastLevel)
            {
                btn.interactable = true; // on rend cliquable le bouton si le niveau associ� est d�bloqu�
            }
        }

    }
}
