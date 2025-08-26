using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private GameObject equip; // 장착 표시
    [SerializeField] private Image icon; // 아이템 아이콘
    private Outline outline;

    private ItemData item;
    public bool isEquipped;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    public void SetItem(ItemData newItem, bool equipped = false)
    {
        item = newItem;
        isEquipped = equipped;
        icon.sprite = item.icon;
    }

    public void RefreshUI()
    {
        if(item == null)
        {
            icon.sprite = null;
            if(outline != null) outline.enabled = false;
            equip.SetActive(false);
            return;
        }

        icon.sprite = item.icon;
        if (outline != null) outline.enabled = isEquipped;
        equip.SetActive(true);
    }
}
