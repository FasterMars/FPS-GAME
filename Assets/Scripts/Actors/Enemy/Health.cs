using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;

    // Update is called once per frame
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            DestroyThisObj();
        }
    }

    // Destroy the object...
    void DestroyThisObj()
    {
        Destroy(gameObject);
    }
}
