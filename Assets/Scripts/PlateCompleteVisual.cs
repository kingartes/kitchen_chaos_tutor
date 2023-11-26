using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlateCompleteVisual : MonoBehaviour
{
    [SerializeField]
    private PlateKitchenObject plateKitchenObject;
    [SerializeField]
    private List<KitchenObjectSO_Gameobject> kitchenObjectSOGameobjectList;

    [Serializable]
    public struct KitchenObjectSO_Gameobject
    {
        public KitchenObjectSO kitchenObjectSO;
        public GameObject gameObject;
    }

    private void Start()
    {
        plateKitchenObject.OnIgredientAdded += PlateKitchenObject_OnIgredientAdded;

        foreach (KitchenObjectSO_Gameobject kitchenObjectSO_Gameobject in kitchenObjectSOGameobjectList)
        {
            kitchenObjectSO_Gameobject.gameObject.SetActive(false);
        }
    }

    private void PlateKitchenObject_OnIgredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
       foreach(KitchenObjectSO_Gameobject kitchenObjectSO_Gameobject in kitchenObjectSOGameobjectList)
        {
            if (kitchenObjectSO_Gameobject.kitchenObjectSO == e.kitchenObjectSO)
            {
                kitchenObjectSO_Gameobject.gameObject.SetActive(true);
            }        
        }
    }
}
