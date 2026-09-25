using UnityEngine;

public class FriendlyOrcScript : OrcScript
{
    public void Start()
    {
        AttackPlayer();

    }

    public override void AttackPlayer()
    {
        print("FriendlyOrc: Friendly Orc is attacking player");
    }
}
