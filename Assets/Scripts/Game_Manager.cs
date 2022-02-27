using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Precondition:Make sure the script is put on an empty gameobject in the scene. That object should also have the DifficultyChanger and Customer_ManagerScript
 *              A Canvas named "Canvas" should also be on the scene
 * 
 * Postcontidion: will be in charge of ending the day and managing other scripts
 */
public class Game_Manager : MonoBehaviour //
{
    [SerializeField] private int timeInDay;
    private float timeLeftInDay;
    private GameObject gameEndPanel;
    public bool dayIsOver = false;
    void Start()
    {
        timeLeftInDay = timeInDay;
        gameEndPanel = GameObject.Find("Canvas");
        dayIsOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftInDay -= Time.deltaTime;
        if (timeLeftInDay <= 0 && !dayIsOver)
        {
            endDay();
            dayIsOver = true;
        }
    }
    void endDay()
    {
        gameEndPanel.GetComponent<PerformanceLog>().panelEnable();
        gameObject.GetComponent<DifficultyChanger>().addDifficulty(1, 1, 1);
        gameObject.GetComponent<Customer_Manager>().removeAllCustomers();
    }
}
