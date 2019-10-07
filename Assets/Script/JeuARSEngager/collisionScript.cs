using UnityEngine;
using System.Collections;

public class collisionScript : MonoBehaviour {
    // Update is called once per frame
    void Update () {
        
    }

    //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
    void OnTriggerEnter (Collider col)
    {
        //Utilisation des particle systems de Unity
        GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
        explosion.transform.position = transform.position;
        Destroy(col.gameObject);
        Destroy (explosion, 2);
        
        //On détruit le vaisseau
        Destroy (gameObject);
        
        
    }

}