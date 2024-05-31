using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // ������ ���� ����

    private void OnCollisionEnter(Collision collision)
    {
        // ĳ����(Player)�� �浹���� ��
        if (collision.gameObject.CompareTag("Player"))
        {
            // ĳ���Ϳ� �������� ���� ���� ���� ������Ų��.
            collision.rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}