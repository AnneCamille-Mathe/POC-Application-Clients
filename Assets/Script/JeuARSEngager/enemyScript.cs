using UnityEngine;
using System.Collections;

public class enemyScript : MonoBehaviour {



    // Use this for initialization
    void Start () {

        StartCoroutine ("Move");
    }

    // Update is called once per frame
    void Update () {
        //On fait avancer le vaisseau
        transform.Translate(Vector3.forward * 3f * Time.deltaTime); 
    }

    IEnumerator Move() {
        //On permet la rotation des objets
        while (true) {
            yield return new WaitForSeconds (3.5f);
            transform.eulerAngles += new Vector3 (0, 180f, 0);
        }
    }
}