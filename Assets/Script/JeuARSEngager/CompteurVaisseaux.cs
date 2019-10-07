using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompteurVaisseaux : MonoBehaviour
{
    //Variables
    private int nbVaisseaux;

    public bool once;
    public GameObject enemy;
    public bool once1;
    public GameObject enemy1;
    public bool once2;
    public GameObject enemy2;
    public bool once3;
    public GameObject enemy3;
    public bool once4;
    public GameObject enemy4;
    public bool once5;
    public GameObject enemy5;
    
    // Start is called before the first frame update
    void Start()
    {
        nbVaisseaux = 6;
        once = true;
        once1 = true;
        once2 = true;
        once3 = true;
        once4 = true;
        once5 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null && once)
        {
            nbVaisseaux -= 1;
            once = false;
        }
        if (enemy1 == null && once1)
        {
            nbVaisseaux -= 1;
            once1 = false;
        }
        if (enemy2 == null && once2)
        {
            nbVaisseaux -= 1;
            once2 = false;
        }
        if (enemy3 == null && once3)
        {
            nbVaisseaux -= 1;
            once3 = false;
        }
        if (enemy4 == null && once4)
        {
            nbVaisseaux -= 1;
            once4 = false;
        }
        if (enemy5 == null && once5)
        {
            nbVaisseaux -= 1;
            once5 = false;
        }

        //On affiche le nombre de vaisseaux à abattre
        GameObject.Find("Canvas/Text").GetComponent<Text>().text = "Nombre de vaisseaux à abattre : " + nbVaisseaux;
    }
}
