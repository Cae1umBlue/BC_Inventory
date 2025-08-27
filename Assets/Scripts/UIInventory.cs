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
        while (slotList.Count < player.Inventory.Count)
        {
            var slot = Instantiate(itemSlotPrefab, slotParent);
            slotList.Add(slot);
        }

        for (int i = 0; i < slotList.Count; i++)
        {
            if(i <  player.Inventory.Count)
            {
                slotList[i].gameObject.SetActive(true);
                slotList[i].SetItem(player.Inventory[i]);
            }
        }
    }
}
