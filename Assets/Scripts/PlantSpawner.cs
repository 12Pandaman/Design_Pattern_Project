using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    [Header("Dependencies")]
    public PlantFactory factory;    // โรงงานผลิต (ต้องลากมาใส่)
    public Transform spawnPoint;    // จุดเกิด (ต้องลากมาใส่)

    // --- ไม่ต้องมีตัวแปร Button หรือ Start() แล้ว ---

    // ฟังก์ชันนี้จะรอให้ปุ่มต่างๆ ใน UI กดเรียกใช้
    // โดยส่งเลข (int) มาบอกว่าอยากได้ต้นไม้แบบที่เท่าไหร่ใน Enum
    public void BuySpecificPlant(int typeIndex)
    {
        // แปลงตัวเลขที่ส่งมา ให้เป็นประเภทต้นไม้
        PlantType selectedType = (PlantType)typeIndex;

        // 1. ถามราคาจากโรงงาน
        int cost = factory.GetPlantCost(selectedType);

        // 2. จ่ายเงิน
        if (CoinManager.Instance.SpendCoins(cost))
        {
            // 3. สั่งโรงงานผลิต
            factory.CreatePlant(selectedType, spawnPoint.position);
            Debug.Log("ซื้อสำเร็จ: " + selectedType.ToString());
        }
        else
        {
            Debug.Log("เงินไม่พอซื้อ: " + selectedType.ToString());
        }
    }
}