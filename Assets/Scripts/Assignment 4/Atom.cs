using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atom : MonoBehaviour
{
    [SerializeField] private int protons;
    [SerializeField] private int electrons;

    public int Protons { get => protons; set => protons = value; }
    public int Electrons { get => electrons; set => electrons = value; }


    public Atom(int p, int e)
    {
        protons = p;
        electrons = e;
    }

    public virtual void PrintAtom()
    {
        print("Number of Protons: " + protons + "\n Number of Electrons: "
            + electrons);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
