using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] UIMainMenu uiMainMenu;
    [SerializeField] UIStatus uiStatus;
    [SerializeField] UIInventory uiInventory;

    public UIMainMenu MainMenu {  get { return uiMainMenu; } }
    public UIInventory Inventory {  get { return uiInventory; } }
    public UIStatus Status {  get { return uiStatus; } }

    protected override void Initialize()
    {
        base.Initialize();
        MainMenu.gameObject.SetActive(true);
        Inventory.gameObject.SetActive(false);
        Status.gameObject.SetActive(false);
    }
}
