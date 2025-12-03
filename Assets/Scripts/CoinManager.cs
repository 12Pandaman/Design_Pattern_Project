using System;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    public int coinCount = 5; // เงินเริ่มต้น

    // Event สำหรับแจ้งเตือนเมื่อเงินเปลี่ยน (Observer Pattern)
    public event Action<int> OnCoinChanged; 

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        // แจ้งเตือนค่าเริ่มต้นตอนเกมเริ่ม
        OnCoinChanged?.Invoke(coinCount);
    }

    public void AddCoins(int amount)
    {
        coinCount += amount;
        OnCoinChanged?.Invoke(coinCount); // แจ้ง UI
    }

    public bool SpendCoins(int amount)
    {
        if (coinCount >= amount)
        {
            coinCount -= amount;
            OnCoinChanged?.Invoke(coinCount); // แจ้ง UI
            return true;
        }
        return false;
    }
}