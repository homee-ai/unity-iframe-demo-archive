using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate( new Vector3(0.05f, 0.05f, 0.05f), Space.Self );
    }

    public void UpdateModel(string modelId)
    {
        var col = new Color(1f, 1f, 1f, 0.5f);

        if (modelId == "47164333326626"){
            col = new Color(1f, 0f, 0f, 0.5f);
        } else if (modelId == "47164333359394"){
            col = new Color(1f, 1f, 0f, 0.5f);
        } else if (modelId == "47164333392162"){
            col = new Color(0f, 1f, 0f, 0.5f);
        } else if (modelId == "47164333424930"){
            col = new Color(0f, 0f, 1f, 0.5f);
        }
        
        GetComponent<Renderer>().material.color = col;
    }
}
