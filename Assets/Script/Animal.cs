using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Animal : MonoBehaviour
{
    //Attributes
    string name;
    public string Name { get { return name; } set { name = value; } }
    protected string[] food = { "Meat", "Plant" };
    public int Hp = 10;
    public int Health { get { return Hp; } set {Health = Hp; } }
    private float speed = 3f;
    public float Speed { get { return speed; } private set { Speed = speed; } }
    private float hunger;
    //hunger
    public float GetHunger()
    {
        return hunger;
    }
    private void SetHunger(float _hunger) 
    {
        _hunger = 0;
        hunger = _hunger;
    }
    //Method
    public void Eat(string food)
    {
        Debug.Log($"{Name} Eat {food}.");
    }
    public void Move()
    {
        Debug.Log($"{Name} Move.");
    }
    public void Sleep()
    {
        Debug.Log($"{Name} Sleep.");
    }
    
}
    

