using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer_Manager : MonoBehaviour
{
    public List<Customer> customers;
    [SerializeField] private LevelDifficulty curLevelDifficulty;
    private float curCustomerDelay;
    private bool customerQueued;
    // Start is called before the first frame update
    void Start()
    {
        curCustomerDelay = curLevelDifficulty.customerDelay;
        customerQueued = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!customerQueued)
            curCustomerDelay -= Time.deltaTime;
        if(curCustomerDelay<=0)
        {
            if (customers.Count >= curLevelDifficulty.maxNumCustomers)
            {
                customers.Add(new Customer());
            }
            else
                customerQueued = true;
            curCustomerDelay = curLevelDifficulty.customerDelay;
        }
    }
}
