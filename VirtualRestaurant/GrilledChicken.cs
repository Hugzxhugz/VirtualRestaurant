﻿namespace VirtualRestaurant;

public class GrilledChicken : Sandwich
{
    public GrilledChicken() : base("Grilled Chicken", 45.99m)
    {
       
        this.addons = addons;
        this.description = "Marinated chicken fillet, grilled to perfection.";
    }
}