using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    /* �ۼ� ���
    ID(�г���) : TextMeshproGUI
    LV(����)
    Description(ĳ���� ����)
    Money(������ȭ)
    StatueBtn(����â on ��ư) : Gameobject
    Inventory(�κ��丮â on ��ư) : Gameobject
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
