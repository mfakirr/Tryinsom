using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class main : MonoBehaviour
{
    imaginaryplane ImaginaryPlane;

    public List<GameObject> Circles = new List<GameObject>();

    public GameObject circlePrefab;

    GameObject EasyWay;

    GameObject CircleObject;

    public float top, bottom, right, left;

    public float circleSpace;

    float FirstPosCon;

    float DifferenceH=0;

    float yIncerease = 0; float xIncerease = 0;

    float Howmanyholder;

    public float PositionConX=0,PositionConY=0;


    Vector2 CirclesPos;


    public float howmanyx = default,howmanyy=default; 

    
    void Start()
    {
        ImaginaryPlane = Camera.main.GetComponent<imaginaryplane>();
        //
        EasyWay = GameObject.FindGameObjectWithTag("key");
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


    void SpawnCirclesX()
    {

        //Debug.Log(left); Debug.Log(bottom); Debug.Log(right); Debug.Log(top);
        //scale yap
        //x ve y de artış durumları

        for (int j = 0; j < howmanyy; j++)
        {
            DifferenceH = FirstPosCon - circleSpace;//merkezi nokta sıfır sıfır kalsın diye
            for (int i = 0; i < howmanyx; i++)
            {
             
                CirclesPos = new Vector2(left + xIncerease + (circleSpace / 2),
            ((-yIncerease) + FirstPosCon) - DifferenceH+PositionConY);
                //
                xIncerease = circleSpace + xIncerease;
                //
                GameObject circleelement = Instantiate(circlePrefab, CirclesPos, Quaternion.identity);
                Circles.Add(circleelement);
                //
                circleelement.transform.parent = EasyWay.transform;

            }
            xIncerease = 0;//x başlangış koşuluna dönüş
            yIncerease = yIncerease + circleSpace;//y de artış
        }
        yIncerease = 0;
        circlePrefab.transform.localScale = new Vector2(1,1);//prefab default scale
    }

    void SpawnCirclesY()
    {

        //Debug.Log(left); Debug.Log(bottom); Debug.Log(right); Debug.Log(top);
        //scale yap
        //x ve y de artış durumları

        for (int j = 0; j < howmanyx; j++)
        {
            DifferenceH = FirstPosCon - circleSpace;//merkezi nokta sıfır sıfır kalsın diye
            for (int i = 0; i < howmanyy; i++)
            {

                // CirclesPos = new Vector2(xIncerease  + DifferenceH-FirstPosCon-PositionConX ,
                // (-yIncerease) +FirstPosCon + DifferenceH - (circleSpace/4));
                CirclesPos = new Vector2(left + xIncerease + (circleSpace / 2),
                ((-yIncerease) + FirstPosCon) - DifferenceH + PositionConY);

                //
                xIncerease = circleSpace + xIncerease;
                //
                GameObject circleelement = Instantiate(circlePrefab, CirclesPos, Quaternion.identity);
                Circles.Add(circleelement);
                //
                circleelement.transform.parent = EasyWay.transform;
            }
            xIncerease = 0;//x başlangış koşuluna dönüş
            yIncerease = yIncerease + circleSpace;//y de artış
        }
        yIncerease = 0;
        //
        circlePrefab.transform.localScale = new Vector2(1, 1);//prefab default scale
    }



    public void SpaceFinder()
    {

        if (howmanyx > howmanyy)
        {
            EasyWay.transform.eulerAngles = new Vector3(0, 0, 0);
            circleSpace = Mathf.Abs((left * 2) / howmanyx);
            Howmanyholder = howmanyx;
            ScaleCon();
            SpawnCirclesX();
            Rotate();

        }
        else if(howmanyx < howmanyy)
        {
            circleSpace = Mathf.Abs((left * 2) / howmanyy);
            Howmanyholder = howmanyy;
            ScaleCon();
            SpawnCirclesY();
            Rotate();
        }
        else
        {

            circleSpace = Mathf.Abs((left * 2) / howmanyx);
            Howmanyholder = howmanyx;
            ScaleCon();
            SpawnCirclesX();

        }

    }
    void Rotate()
    {
        EasyWay.transform.eulerAngles = new Vector3(0,0,90); Debug.Log(left);
    }
    void ScaleCon()
    {

       
            Vector2 ScaleVector = new Vector2(3 / Howmanyholder, 3 / Howmanyholder);
            circlePrefab.transform.localScale = ScaleVector;


 
        //y de fazla ise how many y ye böl

    }



}
