using UnityEngine;

public class InstancingBehaviourSimple : MonoBehaviour
{
    public GameObject prefab;

    public void InstanceAtTransform()
    {
        Instantiate(prefab, transform);
    }
}