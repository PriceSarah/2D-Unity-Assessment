using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterButtonHandler : MonoBehaviour
{
    [SerializeField]
    public bool inFrame = false;

    
    private void Update()
    {
        //if (inFrame == true)
        //{
        //    Debug.Log("true water");
            
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
