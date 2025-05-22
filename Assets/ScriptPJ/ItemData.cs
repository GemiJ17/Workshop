using UnityEngine;

[CreateAssetMenu(fileName = "NewItemData", menuName = "Workshop/ItemData")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite itemIcon;
}
