using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimalItem
{
    // Primal Item Identifcation
    public int id;
    public string name;
    public string description;
    public Sprite icon;

    // Primal Item Stats
    public Dictionary<string, int> stats = new Dictionary<string, int>();

    // Primal Item Quality Management
    public int quality;
    public int crafting_speed;

    // Primal Item Transfer
    public bool can_transfer;

    public PrimalItem(
        int id,
        string name,
        string description,
        Dictionary<string,int> stats,
        int quality,
        int crafting_speed,
        bool can_transfer
    ) {
        this.id = id;
        this.name = name;
        this.description = description;
        this.icon = Resources.Load<Sprite>("PrimalLynx/Items/" + name + "Icons" + name);
        this.stats = stats;
        this.quality = quality;
        this.crafting_speed = crafting_speed;
        this.can_transfer = can_transfer;
    }

    public PrimalItem(
        PrimalItem item
    ) {
        this.id = item.id;
        this.name = item.name;
        this.description = item.description;
        this.icon = Resources.Load<Sprite>("PrimalLynx/Items/" + item.name + "Icons" + item.name);
        this.stats = item.stats;
        this.quality = item.quality;
        this.crafting_speed = item.crafting_speed;
        this.can_transfer = item.can_transfer;
    }
}
