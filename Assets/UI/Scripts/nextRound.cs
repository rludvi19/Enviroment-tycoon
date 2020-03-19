using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRound : MonoBehaviour
{
    public GameObject Manager;
    private UIManager Stats;
    // Start is called before the first frame update
    void Start()
    {
        Stats = Manager.gameObject.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
