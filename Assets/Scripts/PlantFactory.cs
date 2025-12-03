using UnityEngine;
using System.Collections.Generic;

// Enum ประกาศชื่อประเภทต้นไม้ (วางไว้นอก Class)
public enum PlantType
{
   pot01, // 0
   pot02,  // 1
    pot03,
    pot04,
    pot05,
    pot06,
    pot07   // 2
}

public class PlantFactory : MonoBehaviour
{
    [System.Serializable]
    public struct PlantData
    {
        public string name;           
        public PlantType type;        
        public GameObject prefab;     
        public float baseScale;       
        public int cost;              
    }

    public List<PlantData> plantCatalog; // ตั้งค่ารายการสินค้าใน Inspector

    // ฟังก์ชันผลิตต้นไม้
    public GameObject CreatePlant(PlantType type, Vector3 position)
    {
        PlantData data = plantCatalog.Find(p => p.type == type);

        if (data.prefab == null) return null;

        GameObject newPlant = Instantiate(data.prefab, position, Quaternion.identity);
        
        // ตั้งค่าขนาด
        Vector3 finalScale = new Vector3(data.baseScale, data.baseScale, data.baseScale);
        newPlant.transform.localScale = finalScale;

        // ตั้งค่า Script เสริม (ถ้ามี)
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