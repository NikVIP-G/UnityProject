using UnityEngine;

public class AdaptiveFollowers : Follower
{
    protected override void Move()
    {
        transform.position = Vector3.Lerp(transform.position, Target, Speed);
        transform.LookAt(Target);
    }
}
