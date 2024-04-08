using Assets.Scripts;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Person : MonoBehaviour
{
   
    protected string _name;
    protected int _health;

    protected Person(string name, int health)
    {  
        _name = name; _health = health;
    }

    public string Name 
    {
        get { return _name; }
    }

    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0 || value > 100)
            {
                Debug.LogError("Значення здоров'я має бути в діапазоні від 0 до 100.");
            }
            else
            {
                _health = value;
            }
        }
    }
    

    public virtual void ShowStat()
    {
        Debug.Log("Ім'я: " + Name);
    }
    public void SetName(string name)
    {
        _name = name;
    }

    
    public void ChangeHealth(int amount)
    {
        Health += amount;
    }

 
    public void PrintInfo()
    {
        Debug.Log("Ім'я: " + Name + ", Здоров'я: " + Health);
    }

    public abstract void TakeDamage(int damageValue);

    void Start()
    {
/*
        Person person1 = gameObject.AddComponent<Person>();
        person1.SetName("Дурник");
        person1.Health = 80;

        person1.PrintInfo(); 

        person1.ChangeHealth(20);  
        person1.PrintInfo(); 

        person1.ChangeHealth(-30);  
        person1.PrintInfo();  
*/
    }
}