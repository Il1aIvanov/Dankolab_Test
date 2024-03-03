using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElementManager : MonoBehaviour {
    private void Start() {
        Button[] buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons) {
            button.onClick.AddListener(() => RemoveItem(button.gameObject));
        }
    }
    
    public void RemoveItem(GameObject itemToRemove) {
          Destroy(itemToRemove);
    }
}
