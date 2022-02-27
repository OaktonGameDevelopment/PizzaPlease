using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_PhoneScript : Interactable//This is a Test class to Test the Interactable Script
{
    [SerializeField] private Orders_Note orders;
    public Pizza pizza;
    protected override void interact()
    {
        orders.takeOrder();
        print("phone functions");
    }
}