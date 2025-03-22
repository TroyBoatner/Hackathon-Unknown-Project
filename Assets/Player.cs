using UnityEngine;



public class Player : MonoBehaviour
{
    private int money = 0;

    public int Money
    {
        get { return money; }
        set { money = value; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 0f, 0f);
        
    }

    public void Talk()
    {
        Debug.Log("I'm yapping... ");
    }
}
