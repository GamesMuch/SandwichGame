using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ResultsWorker : MonoBehaviour
{
    public UnityEvent AllGood;
    public UnityEvent Ok;
    public UnityEvent AllBad;

    float timewait = 4;
    float timepassed = 0;
    bool showed = false;
    private void Update()
    {
        timepassed += Time.deltaTime;
        if (timepassed >= timewait && showed == false) {
            resultsScreen();
            showed = true;
            }
    }
    void resultsScreen()
    {
        if (ItemManager.Instance.GoodItems == 6 && ItemManager.Instance.BadItems == 0)
        {
            AllGood.Invoke();
        }
        if (ItemManager.Instance.GoodItems < 6 && ItemManager.Instance.BadItems < 6)
        {
            Ok.Invoke();
        }
        if (ItemManager.Instance.GoodItems == 0 && ItemManager.Instance.BadItems == 6)
        {
            AllBad.Invoke();
        }
    }
}
