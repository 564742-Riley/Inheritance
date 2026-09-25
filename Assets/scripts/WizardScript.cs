using UnityEngine;

public class WizardScript : EnemyBase
{
    public void Start()
    {
        AttackPlayer();

    }

    public void AttackPlayer()
    {
        print("Wizard: Enemy is attacking player");
    }
    
}
