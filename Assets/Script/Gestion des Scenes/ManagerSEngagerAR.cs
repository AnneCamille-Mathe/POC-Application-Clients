using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSEngagerAR : MonoBehaviour
{
    //Variables
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;

    public GameObject CanvasVictoire;
    public GameObject Canvas;
    
    
    // Use this for initialization
    void Start () {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy == null && enemy1 == null && enemy2 == null && enemy3 == null && enemy4 == null && enemy5 == null)
        {
            Canvas.SetActive(false);
            CanvasVictoire.SetActive(true);
        }
    }
}
