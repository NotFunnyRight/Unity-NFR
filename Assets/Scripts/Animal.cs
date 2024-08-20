using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird
{
    int wings   = 2;
    int legs    = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }

    public void sing()
    {
        Debug.Log("I am singing.");
    }
}


public class Crow : Bird
{
   Bomb bomb01 = new Bomb();
    public void brain()
    {
        Debug.Log("I HAVE A BIG BRAIN!");
    }

    public void attack()
    {
        bomb01.explod();
    }
}

public class Bomb
{
    public void explod()
    {
        Debug.Log("JUNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNEEEEEEEEEEEEEE!!!!!");
    }
}

public class Cat
{
    int legs = 4;
    int tail = 1;
    
    public void tailchase()
    {
        Debug.Log("I am chasing my own tail.");
    }
}

public class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bird sompong = new Bird();

        sompong.fly();

        Bird sampang = new Bird();

        sampang.sing();

        Cat musari = new Cat();

        musari.tailchase();

        Crow somjid = new Crow();

        somjid.brain();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
