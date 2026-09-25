using UnityEngine;
using UnityEngine.Rendering.Universal;


public class OrcScript : EnemyBase
{
    public void Start()
    {
        AttackPlayer();
        
    }

    public override void AttackPlayer()
    {
        print("Orc: Orc is attacking player");
    }
    
}   
