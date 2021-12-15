using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimalGameData : MonoBehaviour
{
    public List<PrimalItem> primal_items = new List<PrimalItem>();

    private void Awake() {
        BuildItemDatabase();
    }
    public PrimalItem GetItem(int id) {
        return primal_items.Find(primal_item => primal_item.id == id);
    }

    void BuildItemDatabase() {
        primal_items = new List<PrimalItem>() {
            new PrimalItem(1, "Meat","Food hunted from wildlife.", 
            new Dictionary<string, int>() {
                {"FoodBuff",5}
            }, 1,2,true)
        };
    }
}
