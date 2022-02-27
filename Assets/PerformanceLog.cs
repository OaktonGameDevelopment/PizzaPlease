using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PerformanceLog : MonoBehaviour //Keeps track of your preformance for each day and opens a UI Panel at the end of the day
{
    public int money;
    [HideInInspector] public int realSubmittedNum = 0;
    [HideInInspector] public int realRejectedNum = 0;
    [HideInInspector] public int fakeSubmittedNum = 0;
    [HideInInspector] public int fakeRejectedNum = 0;
    public TextMeshProUGUI moneyTMP;
    public TextMeshProUGUI realSubmitted;
    public TextMeshProUGUI fakeRejected;
    public TextMeshProUGUI realRejected;
    public TextMeshProUGUI fakeSubmitted;
    private GameObject Panel;
    public void Start()
    {
        Panel = gameObject.transform.Find("PerformanceDisplay").gameObject;
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            panelEnable();
        }        
        if(Input.GetKeyDown(KeyCode.K))
        {
            next();
        }
    }
    public void changeMoney(int changeInMoney)
    {
        money += changeInMoney;
    }

    public void submittedReal()
    {
        realSubmittedNum++;
        changeMoney(10);
    }
    public void submittedFake()
    {
        fakeSubmittedNum++;
        changeMoney(-5);
    }
    public void rejectedReal()
    {
        realRejectedNum++;
        changeMoney(-5);
    }
    public void rejectedFake()
    {
        fakeRejectedNum++;
    }
    public void panelEnable()
    {
        Debug.Log("panelEnable");
        Panel.SetActive(true);
        realSubmitted.text = realSubmittedNum.ToString();
        fakeRejected.text = fakeRejectedNum.ToString();
        realRejected.text = realRejectedNum.ToString();
        fakeSubmitted.text = fakeSubmittedNum.ToString();
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void next()
    {
        Debug.Log("next");
        Debug.Log(Panel);
        Panel.SetActive(false);
        realSubmittedNum = 0;
        fakeRejectedNum = 0;
        fakeSubmittedNum = 0;
        realRejectedNum = 0;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
