using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    /* 작성 목록
    ID(닉네임) : TextMeshproGUI
    LV(레벨)
    Description(캐릭터 설명)
    Money(소지재화)
    StatueBtn(스텟창 on 버튼) : Gameobject
    Inventory(인벤토리창 on 버튼) : Gameobject
    */

    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;
    [SerializeField] private Button backBtn;

    [SerializeField] private GameObject uiStatus; // 스탯창
    [SerializeField] private GameObject uiInventory; // 인벤토리창

    private void Start()
    {
        uiStatus.SetActive(false);
        uiInventory.SetActive(false);
        backBtn.gameObject.SetActive(false);
    }

    public void SetActiveButton(bool show)
    {
        statusBtn.gameObject.SetActive(show);
        inventoryBtn.gameObject.SetActive(show);
        backBtn?.gameObject.SetActive(!show);
    }

    public void OnStatus() // 스탯창 활성화
    {
        UIManager.Instance.SetActiveUIStatus(true);
        SetActiveButton(false);
        
    }

    public void OnInventory() // 인벤토리창 활성화
    {
        UIManager.Instance.SetActiveUIInventory(true);
        SetActiveButton(false);
    }

    public void OnBack()
    {
        UIManager.Instance.SetActiveUIStatus(false);
        UIManager.Instance.SetActiveUIInventory(false);
        SetActiveButton(true);

    }
}
