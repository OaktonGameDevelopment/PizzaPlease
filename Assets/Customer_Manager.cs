using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer_Manager : MonoBehaviour
{
    public List<GameObject> customers;//Current customers in scene
    [SerializeField] private LevelDifficulty curLevelDifficulty;
    [SerializeField] private GameObject customerPrefab;
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
        foreach(GameObject c in customers)//what happens to each customer on each frame
        {
            Customer cScript = c.GetComponent<Customer>();//Customer script for each customer is customers
            cScript.patience-= (int)(curLevelDifficulty.customerPatienceDecay * Time.deltaTime);
            Debug.Log(cScript.patience);
            if(cScript.patience<=0)
            {
                customers.Remove(c);
                cScript.leave();       
            }
        }
        if (!customerQueued)//if there is a in queue dont decrease the current time it takes for the next customer to arrive
            curCustomerDelay -= Time.deltaTime * curLevelDifficulty.customerPatienceDecay;
        else if (customers.Count < curLevelDifficulty.maxNumCustomers)//if there is a customer in queue and there are less customers then max add the queued customer and resume decreaseing the current time it takes for the next customer to arrive
        {
            customers.Add(Instantiate(customerPrefab));
            customerQueued = false;
        }
        if(curCustomerDelay<=0)//when the timer for customer delay hits 0
        {
            if (customers.Count >= curLevelDifficulty.maxNumCustomers)//if the restaraunt is full put aa customer on queue
            {  
                customerQueued = true;
            }
            else
                customers.Add(Instantiate(customerPrefab));
            curCustomerDelay = curLevelDifficulty.customerDelay;
        }
    }
}
