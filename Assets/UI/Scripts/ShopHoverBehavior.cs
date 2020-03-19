using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopHoverBehavior : MonoBehaviour
{
    public GameObject Information;
    void OnMouseOver()
    {
        Information.SetActive(true);
    }

    void OnMouseExit()
    {
        Information.SetActive(false);
    }
}
