using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    private Character character;

    private void Start()
    {
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
        UpdateCharacterInfo();
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        SetActiveButton(true);
    }

    public void OpenStatus()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(true);
        UIManager.Instance.Inventory.gameObject.SetActive(false);
        SetActiveButton(false);
    }

    public void OpenInventory()
    {
        UIManager.Instance.MainMenu.gameObject.SetActive(true);
        UIManager.Instance.Status.gameObject.SetActive(false);
        UIManager.Instance.Inventory.gameObject.SetActive(true);
        SetActiveButton(false);
    }

    private void SetActiveButton(bool active)
    {
        statusBtn.gameObject.SetActive(active);
        inventoryBtn.gameObject.SetActive(active);
    }

    public void Initialize(Character target)
    {
        character = target;
        UpdateCharacterInfo();
    }

    public void UpdateCharacterInfo()
    {
        id.text = character.CharacterName;
        level.text = $"LV {character.Level}";
        description.text = character.Description;
        money.text = character.Money.ToString("#,##0");
    }
}
