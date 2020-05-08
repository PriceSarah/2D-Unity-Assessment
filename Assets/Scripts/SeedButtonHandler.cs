using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeedButtonHandler : MonoBehaviour
{
   public bool inFrame = false;

    void Update()
    {
        //if (inFrame == true)
        //{
        //    Debug.Log("true seed");
        //    return;
        //}
        //else
        //{
        //    return;
        //}

    }

    public void MoveImage()
    {
        if (inFrame == false)
        {
            this.transform.position += new Vector3(0, 0, -3f);
            inFrame = true;
        }
        else
        {
            return;
        }
    }

    
}
