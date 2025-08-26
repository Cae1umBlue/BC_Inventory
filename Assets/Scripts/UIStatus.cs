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
        UpdateStatus();
    }

    // 플레이어 스탯데이터 연동 예정
    public void UpdateStatus()
    {
        attackValue.text = "10";
        defenceValue.text = "5";
        healthValue.text = "100";
        criticalValue.text = "10";
    }
}
