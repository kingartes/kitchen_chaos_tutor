using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateIconsUI : MonoBehaviour
{
    [SerializeField]
    private PlateKitchenObject plateKitchenObject;
    [SerializeField]
    private Transform iconTemplate;

    private void Start()
    {
        plateKitchenObject.OnIgredientAdded += PlateKitchenObject_OnIgredientAdded;
    }

    private void PlateKitchenObject_OnIgredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
        UpdateVisual();
    }

    private void UpdateVisual()
    {
        foreach (Transform child in transform)
        {
            if (child == iconTemplate) continue;
            Destroy(child.gameObject);
        }
        foreach (KitchenObjectSO kitchenObjectSO in plateKitchenObject.GetKichenObjectSOList())
        {
            Transform icon = Instantiate(iconTemplate, transform);
            icon.GetComponent<PlateIconsSingleUI>().SetKitchenObjectSO(kitchenObjectSO);
        }
    }
}
