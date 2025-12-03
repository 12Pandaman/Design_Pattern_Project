using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [Header("Panels")]
    public GameObject uiPanel;  
    public GameObject uiShop;
    public GameObject uiStart;

    [Header("Displays")]
    public TextMeshProUGUI coinText; // ลาก TextMeshPro มาใส่ตรงนี้

    private void Start()
    {
        // ลงทะเบียนรับข่าวสาร (Subscribe)
        if (CoinManager.Instance != null)
        {
            CoinManager.Instance.OnCoinChanged += UpdateCoinDisplay;
            
            // อัปเดตทันทีหนึ่งครั้งเผื่อค่าเพี้ยน
            UpdateCoinDisplay(CoinManager.Instance.coinCount);
        }
    }

    private void OnDestroy()
    {
        // ยกเลิกการลงทะเบียน (Unsubscribe) กัน Error
        if (CoinManager.Instance != null)
        {
            CoinManager.Instance.OnCoinChanged -= UpdateCoinDisplay;
        }
    }

    // ฟังก์ชันนี้จะถูกเรียกเองอัตโนมัติเมื่อเงินเปลี่ยน
    private void UpdateCoinDisplay(int amount)
    {
        if (coinText != null)
        {
            coinText.text = amount.ToString();
        }
    }

    // ฟังก์ชันเปิดปิด UI อื่นๆ
    public void CloseUI()
    {
        uiPanel.SetActive(false);
        uiShop.SetActive(true);
    }

    public void OpenUI()
    {
        uiPanel.SetActive(true);
        uiShop.SetActive(false);
    }

    public void StartUI()
    {
        uiStart.SetActive(false);
    }
}