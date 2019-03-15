using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buttonCompleteBehavior : MonoBehaviour
{
    [SerializeField]
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetComplete(bool complete)
    {

        if (complete == true)
        {

            image.enabled = true;

        }
        else
        {

            image.enabled = false;

        }
    }
}
