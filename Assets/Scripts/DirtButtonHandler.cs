﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtButtonHandler : MonoBehaviour
{
   
    public bool inFrame = false;

   void Update()
    {
        //if (inFrame == true)
        //{
        //    Debug.Log("true dirt");
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
