MeowGarden - Simulation Game Prototype 

คลิปสาธิต : https://youtu.be/g9Eaz8TXLds


โปรเจกต์เกมจำลองการปลูกต้นไม้และจัดการทรัพยากร พัฒนาด้วย Unity (C#) โดยเน้นการนำ Design Patterns มาประยุกต์ใช้เพื่อแก้ปัญหาการเขียนโค้ด ให้มีความยืดหยุ่น (Flexible), ลดการยึดติดกันของระบบ (Decoupling), และง่ายต่อการขยายเพิ่มเติม (Scalable)

ฟีเจอร์หลัก (Gameplay)
ระบบร้านค้า: เลือกซื้อต้นไม้ประเภทต่างๆ ได้

การปลูกและดูแล: ต้นไม้มีการเจริญเติบโตตามลำดับขั้น (เมล็ด -> ต้นกล้า -> โตเต็มวัย)

ระบบเศรษฐกิจ: เก็บเกี่ยว/ขายต้นไม้เพื่อรับเงิน (Coin) และนำไปซื้อต้นไม้ใหม่

Drag & Drop System: ลากวางไอเทมเพื่อจัดวางหรือขาย

-Design Patterns ที่ใช้ (Architecture)
โปรเจกต์นี้มีการ Refactor โค้ดจากรูปแบบเดิม มาใช้ Design Patterns 3 รูปแบบ ดังนี้:

1. Observer Pattern (สำหรับระบบ UI และการเงิน)
ปัญหาเดิม: CoinManager ต้องถือ Reference ของ UI เพื่อสั่งอัปเดตตัวเลข ทำให้โค้ดผูกติดกันแน่นเกินไป (Tightly Coupled) การแก้ไข: ใช้ Observer Pattern ให้ CoinManager เป็นผู้ส่งสาร (Subject) และ UIController เป็นผู้รับสาร (Observer)

การทำงาน: เมื่อค่าเงินเปลี่ยนแปลง CoinManager จะประกาศ Event OnCoinChanged ออกไป โดยไม่สนว่าใครฟังอยู่บ้าง ส่วน UI ที่ลงทะเบียนฟังไว้จะอัปเดตตัวเองอัตโนมัติ

ไฟล์ที่เกี่ยวข้อง:

CoinManager.cs (Subject)

UIController.cs (Observer)

นี่คือไฟล์ README.md ฉบับสมบูรณ์ที่เขียนเป็นภาษาไทยแบบมืออาชีพ เหมาะสำหรับส่งงานอาจารย์ครับ

ไฟล์นี้จะอธิบายภาพรวมของเกม และเน้นเจาะลึกเรื่อง Design Patterns ที่เรานำมาใช้ เพื่อแสดงให้เห็นว่าเราเข้าใจโครงสร้างโค้ดจริงๆ

คุณสามารถ Copy ข้อความทั้งหมดด้านล่างนี้ ไปสร้างไฟล์ชื่อ README.md ไว้ในหน้าแรกของ Repository (โฟลเดอร์นอกสุดที่เก็บงาน) ได้เลยครับ

MeowGarden - Simulation Game Prototype 
โปรเจกต์เกมจำลองการปลูกต้นไม้และจัดการทรัพยากร พัฒนาด้วย Unity (C#) โดยเน้นการนำ Design Patterns มาประยุกต์ใช้เพื่อแก้ปัญหาการเขียนโค้ด ให้มีความยืดหยุ่น (Flexible), ลดการยึดติดกันของระบบ (Decoupling), และง่ายต่อการขยายเพิ่มเติม (Scalable)

ฟีเจอร์หลัก (Gameplay)
ระบบร้านค้า: เลือกซื้อต้นไม้ประเภทต่างๆ ได้

การปลูกและดูแล: ต้นไม้มีการเจริญเติบโตตามลำดับขั้น (เมล็ด -> ต้นกล้า -> โตเต็มวัย)

ระบบเศรษฐกิจ: เก็บเกี่ยว/ขายต้นไม้เพื่อรับเงิน (Coin) และนำไปซื้อต้นไม้ใหม่

Drag & Drop System: ลากวางไอเทมเพื่อจัดวางหรือขาย

-Design Patterns ที่ใช้ (Architecture)
โปรเจกต์นี้มีการ Refactor โค้ดจากรูปแบบเดิม มาใช้ Design Patterns 3 รูปแบบ ดังนี้:

1. Observer Pattern (สำหรับระบบ UI และการเงิน)
ปัญหาเดิม: CoinManager ต้องถือ Reference ของ UI เพื่อสั่งอัปเดตตัวเลข ทำให้โค้ดผูกติดกันแน่นเกินไป (Tightly Coupled) การแก้ไข: ใช้ Observer Pattern ให้ CoinManager เป็นผู้ส่งสาร (Subject) และ UIController เป็นผู้รับสาร (Observer)

การทำงาน: เมื่อค่าเงินเปลี่ยนแปลง CoinManager จะประกาศ Event OnCoinChanged ออกไป โดยไม่สนว่าใครฟังอยู่บ้าง ส่วน UI ที่ลงทะเบียนฟังไว้จะอัปเดตตัวเองอัตโนมัติ

ไฟล์ที่เกี่ยวข้อง:

CoinManager.cs (Subject)

UIController.cs (Observer)

2. Factory Method Pattern (สำหรับระบบสร้างต้นไม้)
ปัญหาเดิม: การเสกต้นไม้ (Instantiate) ถูกเขียนฝังไว้ในปุ่มกด (Hardcode) ทำให้เพิ่มต้นไม้ประเภทใหม่ยาก และโค้ดซ้ำซ้อน การแก้ไข: ใช้ Factory Pattern สร้าง "โรงงานผลิตต้นไม้" แยกออกมาจัดการ Logic การสร้างและการตั้งค่าเริ่มต้น

การทำงาน: PlantSpawner จะส่งคำสั่งเป็นแค่ Type (Enum) ไปหา PlantFactory จากนั้น Factory จะจัดการค้นหา Prefab, คำนวณราคา, และกำหนดขนาด (Scale) ให้เสร็จสรรพ ก่อนส่ง Object กลับมา

ข้อดี: รองรับการเพิ่มปุ่มซื้อสินค้าหลายปุ่มได้ง่าย โดยใช้ Spawner ตัวเดิม

ไฟล์ที่เกี่ยวข้อง:

PlantFactory.cs (Creator)

PlantSpawner.cs (Client)
Assets/
├── Scripts/
│   ├── Factory/
│   │   ├── PlantFactory.cs
│   │   └── PlantSpawner.cs
│   ├── Observer/
│   │   ├── CoinManager.cs
│   │   └── UIController.c
├── Prefabs/
└── Scenes/
-----------------------------------------------------------------------------------------------
using System; // จำเป็นสำหรับการใช้ Action
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance;
    public int coinCount = 5; // เงินเริ่มต้น

    // Event สำหรับตะโกนบอกเมื่อเงินเปลี่ยน (Observer Pattern)
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
        OnCoinChanged?.Invoke(coinCount); // แจ้ง UI ให้ทำงาน
    }

    public bool SpendCoins(int amount)
    {
        if (coinCount >= amount)
        {
            coinCount -= amount;
            OnCoinChanged?.Invoke(coinCount); // แจ้ง UI ให้ทำงาน
            return true;
        }
        return false;
    }
}
-----------------------------------------------------------------------------------------------
using UnityEngine;
using TMPro; // จำเป็นสำหรับ TextMeshPro

public class UIController : MonoBehaviour
{
    [Header("Displays")]
    public TextMeshProUGUI coinText; // ลาก TextMeshPro มาใส่ตรงนี้ใน Inspector

    private void Start()
    {
        // ลงทะเบียนฟังข่าวจาก CoinManager (Subscribe)
        if (CoinManager.Instance != null)
        {
            CoinManager.Instance.OnCoinChanged += UpdateCoinDisplay;
            
            // อัปเดตทันทีหนึ่งครั้งเผื่อค่าเพี้ยน
            UpdateCoinDisplay(CoinManager.Instance.coinCount);
        }
    }

    private void OnDestroy()
    {
        // ยกเลิกการฟังเมื่อ UI ถูกทำลาย (Unsubscribe)
        if (CoinManager.Instance != null)
        {
            CoinManager.Instance.OnCoinChanged -= UpdateCoinDisplay;
        }
    }

    // ฟังก์ชันนี้จะทำงานเองอัตโนมัติเมื่อเงินเปลี่ยน
    private void UpdateCoinDisplay(int amount)
    {
        if (coinText != null)
        {
            coinText.text = amount.ToString();
        }
    }
}
-----------------------------------------------------------------------------------------------
using UnityEngine;
using System.Collections.Generic;

// Enum ประกาศชื่อประเภทต้นไม้ (วางไว้นอก Class เพื่อให้เรียกใช้ง่าย)
public enum PlantType
{
    pot01, // 0
    pot02, // 1
    flower // 2 (เพิ่มต่อได้เรื่อยๆ)
}

public class PlantFactory : MonoBehaviour
{
    [System.Serializable]
    public struct PlantData
    {
        public string name;           // ชื่อ (ตั้งไว้กันงง)
        public PlantType type;        // ประเภท (Enum)
        public GameObject prefab;     // ตัวโมเดลที่จะเสก
        public float baseScale;       // ขนาดเริ่มต้น (เช่น 0.39...)
        public int cost;              // ราคาขาย
    }

    // List นี้จะโผล่ใน Inspector ให้คุณกด + เพิ่มต้นไม้ได้ตามใจชอบ
    public List<PlantData> plantCatalog; 

    // ฟังก์ชันผลิตต้นไม้ (Factory Method)
    public GameObject CreatePlant(PlantType type, Vector3 position)
    {
        // ค้นหาข้อมูลจาก List
        PlantData data = plantCatalog.Find(p => p.type == type);

        if (data.prefab == null) 
        {
            Debug.LogError("ไม่พบข้อมูลต้นไม้: " + type);
            return null;
        }

        // สร้าง Object
        GameObject newPlant = Instantiate(data.prefab, position, Quaternion.identity);
        
        // ตั้งค่าขนาดให้ถูกต้องตามข้อมูล
        Vector3 finalScale = new Vector3(data.baseScale, data.baseScale, data.baseScale);
        newPlant.transform.localScale = finalScale;

        // ตั้งค่า Script ปรับขนาด (ถ้ามี)
        PlantSizeAdjust plantScript = newPlant.GetComponent<PlantSizeAdjust>();
        if (plantScript != null)
        {
            plantScript.SetOriginalScale(finalScale);
        }

        return newPlant;
    }

    // ฟังก์ชันเช็คราคา
    public int GetPlantCost(PlantType type)
    {
        PlantData data = plantCatalog.Find(p => p.type == type);
        return data.cost;
    }
}
-----------------------------------------------------------------------------------------------
using UnityEngine;

public class PlantSpawner : MonoBehaviour
{
    [Header("Dependencies")]
    public PlantFactory factory;    // ลาก GameObject ที่มี PlantFactory มาใส่
    public Transform spawnPoint;    // ลากจุดที่อยากให้เกิดมาใส่

    // ฟังก์ชันนี้จะถูกเรียกจากปุ่ม UI (Button OnClick)
    // typeIndex: 0 = pot01, 1 = pot02, etc.
    public void BuySpecificPlant(int typeIndex)
    {
        PlantType selectedType = (PlantType)typeIndex;

        // 1. ถามราคาจากโรงงาน
        int cost = factory.GetPlantCost(selectedType);

        // 2. จ่ายเงิน (CoinManager จะจัดการแจ้ง UI เอง)
        if (CoinManager.Instance.SpendCoins(cost))
        {
            // 3. สั่งโรงงานผลิต
            factory.CreatePlant(selectedType, spawnPoint.position);
            Debug.Log("ซื้อสำเร็จ: " + selectedType);
        }
        else
        {
            Debug.Log("เงินไม่พอซื้อ: " + selectedType);
        }
    }
}
-----------------------------------------------------------------------------------------------
ผู้จัดทำ
รหัสนักศึกษา: Kanitnan Chatsetthakul GDM 66120501074 วิชา: GDM 330 Design Pattern Project


