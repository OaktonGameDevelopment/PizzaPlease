using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer_Manager : MonoBehaviour
{
    public List<GameObject> customers;
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
        foreach(GameObject c in customers)
        {
            Customer cScript = c.GetComponent<Customer>();
            cScript.decresePatience();
            if(cScript.patience<=0)
            {
                cScript.leave();
            }
        }
        if (!customerQueued)
            curCustomerDelay -= Time.deltaTime * curLevelDifficulty.customerPatienceDecay;
        else if (customers.Count < curLevelDifficulty.maxNumCustomers)
        {
            customers.Add(Instantiate(customerPrefab));
            customerQueued = false;
        }
        if(curCustomerDelay<=0)
        {
            if (customers.Count >= curLevelDifficulty.maxNumCustomers)
            {
                customers.Add(Instantiate(customerPrefab));
            }
            else
                customerQueued = true;
            curCustomerDelay = curLevelDifficulty.customerDelay;
        }
    }
}
