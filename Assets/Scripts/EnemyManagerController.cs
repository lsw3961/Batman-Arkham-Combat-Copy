using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerController : MonoBehaviour
{
    [SerializeField] private CombatScript playerCombat;
    [SerializeField] private EnemyManager enemyManager;
    [SerializeField] private  float assignmentDistance;
    public void SetEnemyManager() 
    {
        if ((playerCombat.gameObject.transform.position - this.transform.position).magnitude <= assignmentDistance) 
        {
            Debug.LogWarning("Hit");
            playerCombat.enemyManager = enemyManager;
        }
    }

    void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, assignmentDistance);
    }

}
