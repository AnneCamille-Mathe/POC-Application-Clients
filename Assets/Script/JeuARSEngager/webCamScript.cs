using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class webCamScript : MonoBehaviour {

    public GameObject webCameraPlane; 
    public Button fireButton;


    // Use this for initialization
    void Start () {

        
        if (Application.isMobilePlatform) {
            GameObject cameraParent = new GameObject ("camParent");
            cameraParent.transform.position = this.transform.position;
            this.transform.parent = cameraParent.transform;
            cameraParent.transform.Rotate (Vector3.right, 90);
        }

        Input.gyro.enabled = true;

        fireButton.onClick.AddListener (OnButtonDown);

        //On accède à la caméra
        WebCamTexture webCameraTexture = new WebCamTexture();
        webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
        webCameraTexture.Play();




    }


    void OnButtonDown(){
        //On instancie un prefab bullet que l'on détruit après 3 secondes et que l'on fait avancer
        GameObject bullet = Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        bullet.transform.rotation = Camera.main.transform.rotation;
        bullet.transform.position = Camera.main.transform.position;
        rb.AddForce(Camera.main.transform.forward * 1000f);
        Destroy (bullet, 3);

        GetComponent<AudioSource> ().Play ();


    }
  
    // Update is called once per frame
    void Update () {
    //On permet l'utilisation de l'accéléromètre
        Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
        this.transform.localRotation = cameraRotation;
  
    }
}