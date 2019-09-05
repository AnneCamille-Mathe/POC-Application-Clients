using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCamScript : MonoBehaviour
{
    //Variables
    int currentCamIndex = 0;
    private WebCamTexture tex;
    public RawImage display;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Fonctions
    public void StartStopCamClicked()
    {
        if (tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        WebCamDevice device = WebCamTexture.devices[currentCamIndex];
        tex = new WebCamTexture(device.name);
        display.texture = tex;
        
        tex.Play();
        
    }
    
}
