using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class HatScript : EquipmentItem.EquippedEffect
{
    public int defenseChange = 5;
     public override void Equipped(CharacterData user)
     {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.defense = defenseChange;
     
     }
     
     public override void Removed(CharacterData user)
     {
        StatSystem.StatModifier modifier = new StatSystem.StatModifier();
        modifier.ModifierMode = StatSystem.StatModifier.Mode.Absolute;
        modifier.Stats.defense = defenseChange;

    }
}
