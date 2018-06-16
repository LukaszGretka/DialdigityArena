﻿using Assets._Scripts.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets._Scripts.Characters.Abstract
{
    interface ICharacterClass
    {
        List<IAbility> GetCharacterAbilitiesList();
    }
}
