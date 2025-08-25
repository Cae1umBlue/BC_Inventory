using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] GameObject uiMainMenu;
    [SerializeField] GameObject uiStatus;
    [SerializeField] GameObject uiInventory;

    protected override void Initialize()
    {
        base.Initialize();
    }

    public void SetActiveUIStatus(bool show)
    {
        uiStatus.SetActive(show);
    }

    public void SetActiveUIInventory(bool show)
    {
        uiInventory.SetActive(show);
    }
}
