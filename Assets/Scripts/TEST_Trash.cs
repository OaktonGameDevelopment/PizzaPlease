using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST_Trash : Interactable
{
    [SerializeField] private Orders_Note orders;
    protected override void interact()
    {
        orders.submit();
        print("trash functions");
    }
}
