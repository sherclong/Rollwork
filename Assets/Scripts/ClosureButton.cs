using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosureButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TogglePanel(GameObject panel)
    {
        if (panel.activeSelf == false){
            panel.SetActive(true);
        }
        else
        {
            panel.SetActive(false);
        }
    }
}
