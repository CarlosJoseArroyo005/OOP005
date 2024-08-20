using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bird
{
    int wings = 2;
    int legs = 2;

    public void fly()
    {
        Debug.Log("I'm flying.");
    }


    public void sing()
    {
        Debug.Log("I'm singing.");
    }

}
public class Crow : Bird
{
    Bomb bomb1 = new Bomb();

    int steal = 1;

    public void rude()
    {
        Debug.Log("I'm stealing.");
    }

    public void attack()
    {
        Bomb bomb01 = new Bomb();
    }
}
public class Bomb
    {
        public void exeplosion()
        {
            Debug.Log("BOOM!");
        }
    }

public class Spider
    {
        int jaw = 1;
        int legs = 8;

        public void walk()
        {
            Debug.Log("I'm walking.");
        }


        public void hunt()
        {
            Debug.Log("I'm hunting.");
        }

    }

public class Animal2 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Bird sompong = new Bird();

            sompong.fly();
            sompong.sing();

            Spider muffet = new Spider();

            muffet.walk();
            muffet.hunt();

            Crow somjid = new Crow();

            somjid.sing();
            somjid.rude();

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

