using UnityEngine;

[CreateAssetMenu(fileName = "New Achievment", menuName = "Achievments/Achievment")]
public class Achievment : ScriptableObject
{
    new public string name = "New Achievment";
    public Sprite icon = null;
    new public string description = "descricao";
}