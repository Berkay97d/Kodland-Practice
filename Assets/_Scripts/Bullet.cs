using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private static int killedEnemyCount = 0;
    private float speed = 3;
    private Vector3 direction;

    private void FixedUpdate()
    {
        transform.position += direction * speed * Time.deltaTime;
        speed += 1f;

        Collider[] targets = Physics.OverlapSphere(transform.position, 1);
        foreach (var item in targets)
        {
            if (item.tag == "Enemy")
            {
                killedEnemyCount++;
                Destroy(item.gameObject);
                Destroy(gameObject);
            }
        }
    }
    
    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }

    public static int GetKilledEnemyCount()
    {
        return killedEnemyCount;
    }

    public static void ResetKilledEnemyCount()
    {
        killedEnemyCount = 0;
    }
}
