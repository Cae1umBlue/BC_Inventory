using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] ItemData item;

    [SerializeField] UIInventory inventory;
    [SerializeField] private Image icon;
    private Outline outline;

    public int index;
    public bool equipped;

    private void Awake()
    {
        outline = GetComponent<Outline>();
    }

    private void OnEnable()
    {
        outline.enabled = equipped;
    }

    public void SetItem()
    {
        icon.gameObject.SetActive(true);
        icon.sprite = item.icon;

        if(outline != null )
        {
            outline.enabled = equipped;
        }
    }

    public void RefreshItem()
    {
        item = null;
        icon.gameObject.SetActive(false);
    }
}
