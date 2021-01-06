using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imaginaryplane : MonoBehaviour
{
    screensize ScreenSize;

    float imx, imy;
    
    void Start()
    {
        ScreenSize = Camera.main.GetComponent<screensize>();
        imy = ScreenSize.Height;
        imx = ScreenSize.Width;
      

    }
    public float Height
    {
        get
        {
            return imy;
        }
    }

    public float Width
    {
        get
        {
            return imx;
        }
    }

    public float Top
    {
        get
        {
            
            return imy -(imy/3);
        }

    }
    public float Bottom
    {
        get
        {
            return -imy + (imy / 3);
        }

    }

    public float Right
    {
        get
        {
            return imx - (imx / 5);
        }

    }

    public float Left
    {
        get
        {
            return -imx + (imx / 5);
        }

    }


}
