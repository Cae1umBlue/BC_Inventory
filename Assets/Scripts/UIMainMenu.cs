using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    /* 작성 목록
    ID(닉네임) : TextMeshproGUI
    LV(레벨)
    Description(캐릭터 설명)
    Money(소지재화)
    StatueBtn(스텟창 on 버튼) : Gameobject
    Inventory(인벤토리창 on 버튼) : Gameobject
    */

    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI money;
    [SerializeField] private GameObject statusBtn;
    [SerializeField] private GameObject inventoryBtn;

    [SerializeField] private GameObject uiStatus;
    [SerializeField] private GameObject uiInventory;
}
