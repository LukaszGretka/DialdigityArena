
namespace Assets._Scripts.OutputMessages
{
    internal static class ErrorMessages
    {
        #region Abilities errors

        public const string FirstDefaultAbilityDebug = "Im first default ability implementation method!";
        public const string FirstSpecialAbilityDebug = "Im first special ability implementation method!";
        public const string SecondDefaultAbilityDebug = "Im second default ability implementation method!";
        public const string SecondSpecialAbilityDebug = "Im second special ability implementation method!";
        public const string ThirdSpecialAbilityDebug = "Im third default ability implementation method!";

        public const string NotAllAbilitiesSetDebug = "Not all abilities has been set";

        public const string FirstDefaultAbilityNotSet = "First Default Ability was not set";
        public const string SecondDefaultAbilityNotSet = "Second Default Ability was not set";
        public const string FirstSpecialAbilityNotSet = "First Special Ability was not set";
        public const string SecondSpecialAbilityNotSet = "Second Special Ability was not set";
        public const string ThirdSpecialAbilityNotSet = "Third Special Ability was not set";

        public const string WrongTypeOfAbility = "Can't perform action for this type of ability.";

        #endregion

        #region Statistics errors

        public const string InvalidHealthValue = "Invalid Health value";
        public const string InvalidManaValue = "Invalid Mana value";
        public const string InvalidStaminaValue = "Invalid Stamina value";
        public const string InvalidRangeValue = "Invalid Attack Range value";
        public const string InvalidSpeedValue = "Invalid Movement Speed value";

        public const string CannotSetMaximumHealthValue = "Can't set starting health - maximum health was not set";
        public const string CannotSetMaximumManaValue = "Can't set starting mana - maximum mana was not set";
        public const string CannotSetMaximumStaminaValue = "Can't set starting stamina - maximum stamina was not set";
        public const string CannotSetHealthRegenerationValue = "Can't set starting health regeneration";
        public const string CannotSetManaRegenerationValue = "Can't set starting mana regeneration";

        public const string TargetIsDead = "Target is dead.";

        #endregion

        #region Others errors
        public const string MatchmakingError = "Matchmaking is not implemented yet";
        public const string PanelList = "Panels list don't contains current panel: ";
        public const string PleaseAddPanel = ". Please add current panel to panelList";

        public const string ClassNotImlementingICharacterClassInterface = "Current class do not implementing ICharacterClass interface";

        #endregion
    }
}
