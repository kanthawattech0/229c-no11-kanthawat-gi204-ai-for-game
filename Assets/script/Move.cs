using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("ตั้งค่าการเดิน")]
    public float moveSpeed = 3f; // ปรับความเร็วในการเดินได้ตรงนี้

    void Update()
    {
        // สั่งให้ตัวละครเคลื่อนที่ไปข้างหน้า (แกน Z) อย่างต่อเนื่อง
        // Time.deltaTime ช่วยให้ความเร็วในการเดินคงที่ ไม่ขึ้นอยู่กับความแรงของคอมพิวเตอร์
        transform.Translate(-Vector3.up * moveSpeed * Time.deltaTime);
    }
}