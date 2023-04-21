using UnityEngine;

[RequireComponent(typeof(ConfigurableJoint))]
public class PhysicalBodyPart : MonoBehaviour
{
    [SerializeField] private Transform target;

    private ConfigurableJoint joint;
    private Quaternion startRotation;

    private void Start()
    {
        joint = GetComponent<ConfigurableJoint>();
        startRotation = transform.localRotation;
    }

    private void FixedUpdate()
    {
        joint.targetRotation = Quaternion.Inverse(target.localRotation) * startRotation;
    }

}
