using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private ConfigurableJoint joint;
    [SerializeField] private Transform pelvisTransform;


    private void FixedUpdate()
    {

        Vector3 toTarget = target.position - pelvisTransform.position;
        Vector3 toTargetXZ = new Vector3(toTarget.x, 0f, toTarget.z);
        Quaternion rotation = Quaternion.LookRotation(toTargetXZ);

        joint.targetRotation = Quaternion.Inverse(rotation);
    }
}
