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
    private Character player;

    private void Start()
    {
        backBtn.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
    }

    public void Initialize(Character targetPlayer)
    {
        player = targetPlayer;
        InitInventoryUI();
    }

    public void InitInventoryUI()
    {
        foreach(Transform child in slotParent)
        {
            Destroy(child.gameObject);
        }
        slotList.Clear();

        foreach (var itemData in player.Inventory)
        {
            var slot = Instantiate(itemSlotPrefab, slotParent);
            slot.SetItem(itemData);
            slotList.Add(slot);
        }
    }
}
