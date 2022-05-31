using UnityEngine;

public class AI : MonoBehaviour
{
    /// <summary>
    /// This script is for the enemy movement and AI.
    /// </summary>
    

    public Transform playerTransform;
    public Rigidbody enemyRB;
    public float speed;

    private void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 playerPos = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.fixedDeltaTime);
        enemyRB.MovePosition(playerPos);
        transform.LookAt(playerTransform);
    }
}