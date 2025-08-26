using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] Button backBtn;

    [SerializeField] UISlot itemSlotPrefab;
    [SerializeField] Transform slotParent;

    private List<UISlot> slotList = new List<UISlot>();
    [SerializeField] private List<ItemData> itemDatas;

    private void Start()
    {
        backBtn.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        foreach(Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }
        slotList.Clear();

        foreach (var item in itemDatas)
        {
            var slot = Instantiate(itemSlotPrefab, slotParent);
            slot.SetItem(item);
            slotList.Add(slot);
        }
    }
}
