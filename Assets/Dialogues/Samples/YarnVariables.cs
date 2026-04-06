namespace Sample {

    using Yarn.Unity;

    /// <summary>
    /// Weapon
    /// </summary>
    /// <remarks>
    /// Automatically generated from Yarn project at Assets/Dialogues/Samples/Sample.yarnproject.
    /// </remarks>
    [System.CodeDom.Compiler.GeneratedCode("YarnSpinner", "3.1.4.0")]
    public enum Weapon {

        /// <summary>
        /// None
        /// </summary>
        None = 0,

        /// <summary>
        /// Sword
        /// </summary>
        Sword = 1,

        /// <summary>
        /// Crossbow
        /// </summary>
        Crossbow = 2,

        /// <summary>
        /// PointyStick
        /// </summary>
        PointyStick = 3,
    }

    [System.CodeDom.Compiler.GeneratedCode("YarnSpinner", "3.1.4.0")]
    internal static class YarnVariablesTypeExtensions {
        internal static int GetBackingValue(this Weapon enumValue) {
            switch (enumValue) {
                    case Weapon.None:
                        return 0;
                    case Weapon.Sword:
                        return 1;
                    case Weapon.Crossbow:
                        return 2;
                    case Weapon.PointyStick:
                        return 3;
                    default:
                throw new System.ArgumentException($"{enumValue} is not a valid enum case.");
            }
        }
    }
    [System.CodeDom.Compiler.GeneratedCode("YarnSpinner", "3.1.4.0")]
    public partial class YarnVariables : Yarn.Unity.InMemoryVariableStorage, Yarn.Unity.IGeneratedVariableStorage {
        // Accessor for String $N
        public string N {
            get => this.GetValueOrDefault<string>("$N");
            set => this.SetValue<string>("$N", value);
        }

        // Accessor for Number $money
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\Commands_Example.yarn, node Commands_Example
        /// </summary>
        public float Money {
            get => this.GetValueOrDefault<float>("$money");
            set => this.SetValue<float>("$money", value);
        }

        // Accessor for Weapon $weapon
        public Weapon Weapon {
            get => this.GetEnumValueOrDefault<Weapon>("$weapon");
            set => this.SetValue("$weapon", value.GetBackingValue());
        }

        // Accessor for Number $gold_amount
        public float GoldAmount {
            get => this.GetValueOrDefault<float>("$gold_amount");
            set => this.SetValue<float>("$gold_amount", value);
        }

        // Accessor for Number $reputation
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\FlowControl_Example.yarn, node FlowControl_Example_2
        /// </summary>
        public float Reputation {
            get => this.GetValueOrDefault<float>("$reputation");
            set => this.SetValue<float>("$reputation", value);
        }

        // Accessor for Bool $player_is_thief
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\FlowControl_Example.yarn, node FlowControl_Example_3
        /// </summary>
        public bool PlayerIsThief {
            get => this.GetValueOrDefault<bool>("$player_is_thief");
            set => this.SetValue<bool>("$player_is_thief", value);
        }

        // Accessor for Bool $player_is_merchant
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\FlowControl_Example.yarn, node FlowControl_Example_3
        /// </summary>
        public bool PlayerIsMerchant {
            get => this.GetValueOrDefault<bool>("$player_is_merchant");
            set => this.SetValue<bool>("$player_is_merchant", value);
        }

        // Accessor for Bool $usedToBePirate
        public bool UsedToBePirate {
            get => this.GetValueOrDefault<bool>("$usedToBePirate");
            set => this.SetValue<bool>("$usedToBePirate", value);
        }

        // Accessor for String $gender
        public string Gender {
            get => this.GetValueOrDefault<string>("$gender");
            set => this.SetValue<string>("$gender", value);
        }

        // Accessor for Bool $has_sword
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\NodeGroups_Example.yarn, node Guard
        /// </summary>
        public bool HasSword {
            get => this.GetValueOrDefault<bool>("$has_sword");
            set => this.SetValue<bool>("$has_sword", value);
        }

        // Accessor for Bool $caves
        public bool Caves {
            get => this.GetValueOrDefault<bool>("$caves");
            set => this.SetValue<bool>("$caves", value);
        }

        // Accessor for Bool $castle
        public bool Castle {
            get => this.GetValueOrDefault<bool>("$castle");
            set => this.SetValue<bool>("$castle", value);
        }

        // Accessor for Number $gold
        public float Gold {
            get => this.GetValueOrDefault<float>("$gold");
            set => this.SetValue<float>("$gold", value);
        }

        // Accessor for Number $sam_relationship_score
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_1
        /// </summary>
        public float SamRelationshipScore {
            get => this.GetValueOrDefault<float>("$sam_relationship_score");
            set => this.SetValue<float>("$sam_relationship_score", value);
        }

        // Accessor for Bool $player_is_friends_with_sam
        public bool PlayerIsFriendsWithSam {
            get => this.GetValueOrDefault<bool>("$player_is_friends_with_sam");
        }

        // Accessor for Number $wood
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_2
        /// </summary>
        public float Wood {
            get => this.GetValueOrDefault<float>("$wood");
            set => this.SetValue<float>("$wood", value);
        }

        // Accessor for Number $nails
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_2
        /// </summary>
        public float Nails {
            get => this.GetValueOrDefault<float>("$nails");
            set => this.SetValue<float>("$nails", value);
        }

        // Accessor for Bool $has_enough_materials
        public bool HasEnoughMaterials {
            get => this.GetValueOrDefault<bool>("$has_enough_materials");
        }

        // Accessor for Number $carpentry_level
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_2
        /// </summary>
        public float CarpentryLevel {
            get => this.GetValueOrDefault<float>("$carpentry_level");
            set => this.SetValue<float>("$carpentry_level", value);
        }

        // Accessor for Bool $has_required_skill
        public bool HasRequiredSkill {
            get => this.GetValueOrDefault<bool>("$has_required_skill");
        }

        // Accessor for Bool $can_build_chair
        public bool CanBuildChair {
            get => this.GetValueOrDefault<bool>("$can_build_chair");
        }

        // Accessor for Number $game_hour
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_3
        /// </summary>
        public float GameHour {
            get => this.GetValueOrDefault<float>("$game_hour");
            set => this.SetValue<float>("$game_hour", value);
        }

        // Accessor for Bool $is_evening
        public bool IsEvening {
            get => this.GetValueOrDefault<bool>("$is_evening");
        }

        // Accessor for Bool $is_holiday
        /// <summary>
        /// Implicitly declared in D:\MyGameProjects\GMTK2025\Assets\Dialogues\Samples\SmartVariables_Example.yarn, node SmartVariables_Example_3
        /// </summary>
        public bool IsHoliday {
            get => this.GetValueOrDefault<bool>("$is_holiday");
            set => this.SetValue<bool>("$is_holiday", value);
        }

        // Accessor for Bool $town_shops_open
        public bool TownShopsOpen {
            get => this.GetValueOrDefault<bool>("$town_shops_open");
        }

        // Accessor for String $playerName
        /// <summary>
        /// The name of the player.
        /// </summary>
        public string PlayerName {
            get => this.GetValueOrDefault<string>("$playerName");
            set => this.SetValue<string>("$playerName", value);
        }

        // Accessor for Number $luck
        /// <summary>
        /// The number of gold pieces that the player has.
        /// </summary>
        public float Luck {
            get => this.GetValueOrDefault<float>("$luck");
            set => this.SetValue<float>("$luck", value);
        }

        // Accessor for Bool $doorUnlocked
        /// <summary>
        /// Is the door to the dungeon unlocked?
        /// </summary>
        public bool DoorUnlocked {
            get => this.GetValueOrDefault<bool>("$doorUnlocked");
            set => this.SetValue<bool>("$doorUnlocked", value);
        }

        // Accessor for Number $aNumber
        public float ANumber {
            get => this.GetValueOrDefault<float>("$aNumber");
            set => this.SetValue<float>("$aNumber", value);
        }

        // Accessor for String $aString
        public string AString {
            get => this.GetValueOrDefault<string>("$aString");
            set => this.SetValue<string>("$aString", value);
        }

    }
}
