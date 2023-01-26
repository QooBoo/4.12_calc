using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{

    [SerializeField] private GameObject mainScreen;
    [SerializeField] private GameObject calcScreen;
    [SerializeField] private GameObject comparerScreen;

    private GameObject currentScreen;

    private void Start()
    {
        mainScreen.SetActive(true);
        currentScreen = mainScreen;
    }


    public void ChangeState(GameObject state)
    {

        if (currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }
}
