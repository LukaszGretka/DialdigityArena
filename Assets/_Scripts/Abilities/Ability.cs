using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Ability
{
    protected string Name { get; set; }

    protected int ManaCost { get; set; }

    protected int StaminaCost { get; set; }

    protected float Cooldown { get; set; }

    protected float Range { get; set; }

}
