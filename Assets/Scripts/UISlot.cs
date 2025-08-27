using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private GameObject equip; // 장착 표시
    [SerializeField] private Image icon; // 아이템 아이콘
    [SerializeField] private Button button; // 장착용 버튼

    private ItemData item;
    public bool isEquipped;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    public void SetItem(ItemData newItem)
    {
        item = newItem;
        icon.sprite = item.icon;
        button.onClick.AddListener(ToogleEquip);
    }

    public void RefreshUI()
    {
        if(item == null)
        {
            icon.sprite = null;
            equip.SetActive(false);
            return;
        }

        icon.sprite = item.icon;

        isEquipped = item.isEquipped;

        equip.SetActive(isEquipped);
    }

    private void ToogleEquip()
    {
        if (item == null) return;

        if (item.isEquipped)
            GameManager.Instance.Player.UnEquip(item);
        else
            GameManager.Instance.Player.Equip(item);

        RefreshUI();
        UIManager.Instance.Status.UpdateStatus();
    }
    
}
