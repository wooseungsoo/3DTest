using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프력 조절 변수

    private void OnCollisionEnter(Collision collision)
    {
        // 캐릭터(Player)와 충돌했을 때
        if (collision.gameObject.CompareTag("Player"))
        {
            // 캐릭터에 순간적인 힘을 가해 위로 점프시킨다.
            collision.rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}