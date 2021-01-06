using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    main Main;
    

    private void Start()
    {
        Main = GameObject.FindGameObjectWithTag("code").GetComponent<main>(); 
        
    }
    public void UpDecrease()
    {
        if (Main.howmanyy!=3)
        {
            Main.howmanyy--;
            DestroyCircle();
            Main.SpaceFinder();
            
        }
        
    }
    public void DownIncrease()
    {

            Main.howmanyy++;
            DestroyCircle();
            Main.SpaceFinder();

    }
    public void LeftDecrease()
    {
        if (Main.howmanyx != 3)
        {
            Main.howmanyx--;
            DestroyCircle();
            Main.SpaceFinder();  
        }
    }

    public void RightIncrease()
    {

            Main.howmanyx++; 
            DestroyCircle();
            Main.SpaceFinder();

    }
    void DestroyCircle()
    {
            for (int i = 0; i < Main.Circles.Count; i++)
            {
                GameObject destroycircle = Main.Circles[i];
                Destroy(destroycircle);
        }
        CleanCircle();
    }
    void CleanCircle()
    {
        for (int i = 0; i < Main.Circles.Count; i++)
        {
            Main.Circles.Remove(Main.Circles[i]);
        }
    }
}
