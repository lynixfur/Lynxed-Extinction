using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimalDrop : MonoBehaviour
{
    public PrimalGameData pgd;
    public GameObject drop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D ic) {
        Debug.LogWarning("PrimalItem: Picked Up Item Event Failed! (94)");
        Debug.Log(pgd.GetItem(1).name);
        Destroy(drop);
    }
}
