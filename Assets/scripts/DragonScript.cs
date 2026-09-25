using UnityEngine;

public class DragonScript : EnemyBase
{
    public void Start()
    {
        AttackPlayer();
    }

    public override void AttackPlayer()
    {
        print("Dragon: Dragon is attacking player");
    }
 
}
 