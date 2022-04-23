using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageControl : MonoBehaviour
{
    public List<GameObject> viewPorts;

    // Start is called before the first frame update
    void Start()
    {
        viewPorts[0].SetActive(true);

        for (int i = 1; i < viewPorts.Count; i++)
        {
            viewPorts[i].SetActive(false);
        }
        StartCoroutine(PlayLoading());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayLoading()
    {
        yield return new WaitForSeconds(7);
        viewPorts[1].SetActive(true);
    }

    public void SwitchToView(int viewIndex)
    {
        viewPorts[viewIndex].SetActive(true);

        for (int i = 0; i < viewPorts.Count; i++)
        {
            if (i != viewIndex)
            {
                viewPorts[i].SetActive(false);
            }
        }
    }

    public void OpenPanel(GameObject panel)
    {
        panel.SetActive(true);
    }

    public void ClosePanel(GameObject panel)
    {
        panel.SetActive(false);
    }

}
