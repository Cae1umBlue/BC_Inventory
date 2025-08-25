using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Button backBtn;

    [SerializeField] private TextMeshProUGUI attackValue;
    [SerializeField] private TextMeshProUGUI defenceValue;
    [SerializeField] private TextMeshProUGUI healthValue;
    [SerializeField] private TextMeshProUGUI criticalValue;
    private void Start()
    {
        backBtn.onClick.AddListener(() => UIManager.Instance.MainMenu.OpenMainMenu());
    }
}
