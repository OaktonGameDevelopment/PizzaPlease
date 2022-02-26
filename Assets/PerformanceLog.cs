using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PerformanceLog : MonoBehaviour //Keeps track of your preformance for each day and opens a UI Panel at the end of the day
{
    public int money;
    [HideInInspector] public int realSubmittedNum;
    [HideInInspector] public int realRejectedNum;
    [HideInInspector] public int fakeSubmittedNum;
    [HideInInspector] public int fakeRejectedNum;
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
    public void changeMoney(int changeInMoney)
    {
        money += changeInMoney;
    }

    public void submittedReal()
    {
        realSubmittedNum++;
        changeMoney(10);
    }
    public void sumittedFake()
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
        Panel.SetActive(true);
        realSubmitted.text = realSubmittedNum.ToString();
        fakeRejected.text = fakeRejectedNum.ToString();
        realRejected.text = realRejected.ToString();
        fakeSubmitted.text = fakeSubmitted.ToString();
    }
    public void next()
    {
        Panel.SetActive(false);
    }
}
