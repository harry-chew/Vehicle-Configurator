using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/ComponentScriptableObject", order = 1)]
public class ComponentScriptableObject : ScriptableObject
{
    [SerializeField] private int componentID;
    [SerializeField] private ComponentType type;
    [SerializeField] private string componentName;
    [SerializeField] private double componentPrice;
    [SerializeField] private GameObject componentModel;
}
