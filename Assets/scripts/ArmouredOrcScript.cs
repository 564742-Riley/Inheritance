using UnityEngine;

public class ArmouredOrcScript : OrcScript
{
    public void Start()
    {
        AttackPlayer();

    }

    public override void AttackPlayer()
    {
        print("ArmouredOrc: Armoured Orc is attacking player");
    }
}
