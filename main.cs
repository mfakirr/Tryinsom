using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    imaginaryplane ImaginaryPlane;

    public List<GameObject> Circles = new List<GameObject>();

    public GameObject circlePrefab;

    GameObject CircleObject;

    float top, bottom, right, left;

    float circleSpace;

    float FirstPosCon;

    

    Vector2 CirclesPos;


    public float howmanyx = default,howmanyy=default; 

    
    void Start()
    {
        ImaginaryPlane = Camera.main.GetComponent<imaginaryplane>();
        //
        bottom = ImaginaryPlane.Bottom;
        right = ImaginaryPlane.Right;
        left = ImaginaryPlane.Left;
        top = ImaginaryPlane.Top;
        //
        FirstPosCon = Mathf.Abs((2*left) / 3);
       
        //
        SpaceFinder();
        
      
  
    }


    void SpawnCircles()
    {

        //Debug.Log(left); Debug.Log(bottom); Debug.Log(right); Debug.Log(top);
        ScaleCon();
        float yIncerease = 0; float xIncerease = 0;
       
        for (int j = 0; j < howmanyy; j++)
        {

            for (int i = 0; i < howmanyx; i++)
            {


                // CirclesPos = new Vector2(left + xIncerease + (circleSpace / 2),
                //   (top - yIncerease) - (-circleSpace / 2) - FirstPosCon);
                CirclesPos = new Vector2( xIncerease -FirstPosCon,
                   ( - yIncerease)+ FirstPosCon);


                xIncerease = circleSpace + xIncerease;
                GameObject circleelement = Instantiate(circlePrefab, CirclesPos, Quaternion.identity);

                Circles.Add(circleelement);

            }
            xIncerease = 0;
            yIncerease = yIncerease + circleSpace;
        }
        circlePrefab.transform.localScale = new Vector2(1,1);
    }

    public void SpaceFinder()
    {

        if (howmanyx >= howmanyy || howmanyy == 4)
        {

            circleSpace = Mathf.Abs((left * 2) / howmanyx);
        }
        else
        {

            circleSpace = Mathf.Abs((left * 2) / howmanyy);

        }
       // circleSpace = Mathf.Abs((left * 2) / howmanyx);
            SpawnCircles();

            
        
    }
    void FindPos()
    {
       /* if (howmanyx >= howmanyy)
        {
            Vector2 CirclesPos = new Vector2(left + xIncerease + (circleSpace / 2),
                (top - yIncerease) - (-circleSpace / 2) - FirstPosCon);
           
        }
        else
        {
            circleSpace = Mathf.Abs((left * 2) / howmanyx);
            SpawnCircles();

        }*/
    }

    void ScaleCon()
    {

        Vector2 ScaleVector = new Vector2(3 / howmanyx, 3 / howmanyx);
        circlePrefab.transform.localScale = ScaleVector;
        //y de fazla ise how many y ye böl

    }


}
