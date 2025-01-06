using UnityEngine;
using UnityEngine.UI;

public class Interactions : MonoBehaviour
{
    public Ingredients[] slots;         // Inventory slots
    public Image[] slotImage;           // Images for each slot (UI)
    public int[] slotAmount;            // Amount of ingredients in each slot
    private Collider currentIngredient; // Track the ingredient currently in the trigger

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            Debug.Log("Ingredient detected!");
            currentIngredient = other; // Store the reference to the ingredient in the trigger
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ingredient"))
        {
            currentIngredient = null;
            Debug.Log("Ingredient exited trigger.");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && currentIngredient != null)
        {
            IngredientType ingredientType = currentIngredient.GetComponent<IngredientType>();
            if (ingredientType != null)
            {
                bool added = false;

                for (int i = 0; i < slots.Length; i++)
                {
                    if (slots[i] == null || slots[i].ingredientName == ingredientType.Ingredients.ingredientName)
                    {
                        if (slots[i] == null)
                        {
                            slots[i] = ingredientType.Ingredients;
                            slotAmount[i] = 1; // Initialize with 1
                            slotImage[i].sprite = ingredientType.Ingredients.ingredientSprite; // Corrected sprite assignment
                            Debug.Log("Ingredient added to empty slot.");
                        }
                        else
                        {
                            slotAmount[i]++;
                            Debug.Log("Ingredient amount increased.");
                        }

                        // Debugging: Check if the sprite is being assigned
                        Debug.Log("Assigning sprite: " + slots[i].ingredientSprite.name);

                        // Assign the sprite to the UI slot
                        slotImage[i].sprite = slots[i].ingredientSprite;

                        // Confirm that sprite was updated
                        Debug.Log("Sprite assigned: " + slotImage[i].sprite.name);

                        added = true;
                        break;
                    }
                }

                if (!added)
                {
                    Debug.LogWarning("Inventory is full or ingredient cannot be added.");
                }

                Destroy(currentIngredient.gameObject);
                currentIngredient = null;
            }
            else
            {
                Debug.LogWarning("The object does not have the IngredientType component.");
            }
        }
    }
}
