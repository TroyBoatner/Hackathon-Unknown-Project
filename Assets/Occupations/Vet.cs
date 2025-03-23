using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vet : Occupation
{
    public int salary;
    public bool postGrad;
    public int loan;

    public int Salary
    {
        get
        {
            return salary;
        }
    }

    public bool PostGrad
    {
        get
        {
            return postGrad;
        }
    }

    public int Loan
    {
        get
        {
            return loan;
        }
    }

    public Vet()
    {
        this.salary = 60000;
        this.postGrad = true;
        this.loan = 20000;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
