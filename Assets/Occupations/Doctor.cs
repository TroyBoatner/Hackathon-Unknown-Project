using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doctor : Occupation
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

    public Doctor()
    {
        salary = 100000;
        postGrad = true;
        loan = 20000;
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
