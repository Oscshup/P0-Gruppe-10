using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownController : MonoBehaviour
{
    public GameObject dropdownPanel;  // Assign the panel in the Inspector

    private bool isDropdownVisible = false;

    public void ToggleDropdown()
    {
        isDropdownVisible = !isDropdownVisible;
        dropdownPanel.SetActive(isDropdownVisible);
    }
}

