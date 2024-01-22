﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoCSharp.Server.Db {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class MySqlDbManagerQueries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MySqlDbManagerQueries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CoCSharp.Server.Db.MySqlDbManagerQueries", typeof(MySqlDbManagerQueries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO clans(clan_id, name, description, exp_levels, badge, invite_type, total_trophies, required_trophies, wars_won, wars_lost, wars_tried, language, war_frequency, location, perk_points, win_streak, war_logs_public, entries)
        ///
        ///VALUES(@ClanId, @Name, @Description, @ExpLevels, @Badge, @InviteType, @TotalTrophies, @RequiredTrophies, @WarsWon, @WarsLost, @WarsTried, @Language, @WarFrequency, @Location, @PerkPoints, @WinStreak, @WarLogsPublic, @entries)
        ///
        ///ON DUPLICATE KEY UPDATE
        ///name = VALUES(name), de [rest of string was truncated]&quot;;.
        /// </summary>
        public static string InsertUpdateClan {
            get {
                return ResourceManager.GetString("InsertUpdateClan", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO clan_members(user_id, clan_id, role, troops_donated, troops_received, rank, rank_prev, new_member, war_cooldown, war_preference)
        ///
        ///VALUES(@UserId, @ClanId, @Role, @TroopsDonated, @TroopsReceived, @Rank, @PreviousRank, @NewMember, @WarCooldown, @WarPreference)
        ///
        ///ON DUPLICATE KEY UPDATE
        ///user_id = VALUES(user_id), clan_id = VALUES(clan_id), role = VALUES(role), troops_donated = VALUES(troops_donated), troops_received = VALUES(troops_received), rank = VALUES(rank), rank_prev = VALUES(rank_prev),  [rest of string was truncated]&quot;;.
        /// </summary>
        public static string InsertUpdateClanMember {
            get {
                return ResourceManager.GetString("InsertUpdateClanMember", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO levels(create_date, last_save_date, play_time_seconds, login_count, user_id, clan_id, level_json, token, name, is_named, trophies, league, exp_points, exp_levels, gems, free_gems, atk_won, atk_lost, def_won, def_lost, slots) 
        ///
        ///VALUES(@DateCreated, @DateLastSave, @PlayTime, @LoginCount, @UserId, @ClanId, @LevelJson, @Token, @Name, @IsNamed, @Trophies, @League, @ExpPoints, @ExpLevel, @Gems, @FreeGems, @AttacksWon, @AttacksLost, @DefensesWon, @DefensesLost, @slots) 
        ///
        ///ON DUPLICATE KEY UPDATE 
        ///p [rest of string was truncated]&quot;;.
        /// </summary>
        public static string InsertUpdateLevel {
            get {
                return ResourceManager.GetString("InsertUpdateLevel", resourceCulture);
            }
        }
    }
}
