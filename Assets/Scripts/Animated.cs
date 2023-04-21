using UnityEngine;

public class Animated : MonoBehaviour
{

    [SerializeField] private PhysicMaterial zeroFriction;
    [SerializeField] private PhysicMaterial highFriction;

    [SerializeField] private Collider leftCollider;
    [SerializeField] private Collider rightCollider;


    public void SetLeftFriction()
    {
        leftCollider.material = highFriction;
        rightCollider.material = zeroFriction;
    }

    public void SetRightFriction()
    {
        leftCollider.material = zeroFriction;
        rightCollider.material = highFriction;
    }
}
