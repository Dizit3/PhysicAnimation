using UnityEngine;

public class IgnoreCollisions : MonoBehaviour
{
    [SerializeField] private Collider[] allColliders;

    private void Awake()
    {
        for (int a = 0; a < allColliders.Length; a++)
        {
            for (int b = 0; b < allColliders.Length; b++)
            {
                Physics.IgnoreCollision(allColliders[a], allColliders[b], true);
            }
        }
    }


}
