using UnityEngine;

[CreateAssetMenu(fileName ="New Ingredient", menuName = "Inventory Ingredients/Create New")]
public class Ingredients : ScriptableObject
{
    public int id;
    public string ingredientName;
    public string ingredientDescription;
    public Sprite ingredientSprite;
}
