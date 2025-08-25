using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    /* �ۼ� ���
    ID(�г���) : TextMeshproGUI
    LV(����)
    Description(ĳ���� ����)
    Money(������ȭ)
    StatueBtn(����â on ��ư) : Gameobject
    Inventory(�κ��丮â on ��ư) : Gameobject
    */

    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;
    [SerializeField] private Button backBtn;

    [SerializeField] private GameObject uiStatus; // ����â
    [SerializeField] private GameObject uiInventory; // �κ��丮â

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

    public void OnStatus() // ����â Ȱ��ȭ
    {
        UIManager.Instance.SetActiveUIStatus(true);
        SetActiveButton(false);
        
    }

    public void OnInventory() // �κ��丮â Ȱ��ȭ
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
