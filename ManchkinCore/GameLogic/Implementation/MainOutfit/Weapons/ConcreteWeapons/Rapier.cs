﻿using ManchkinCore.Enums.Accessory;
using ManchkinCore.GameLogic.Implementation.MainOutfit.Weapons;
using ManchkinCore.Interfaces;

namespace ManchkinCore.Implementation;

public class Rapier : SingleHandWeapon
{
    public Rapier()
    {
        Price = 600;
        Damage = 3;
        Weight = Bulkiness.SMALL;
        Fullness = Arms.SINGLE;
        Descriptions = new List<string>();
        FlushingBonus = 0;
        TextRepresentation = "Рапира такнечестности";
    }

    public override bool CanBeUsed(IRace? race) => true;

    public override bool CanBeUsed(IClass? _class) => true;

    public override bool CanBeUsed(Genders gender) => true;
}