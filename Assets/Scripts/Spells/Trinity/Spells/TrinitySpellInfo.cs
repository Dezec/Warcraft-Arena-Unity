﻿using UnityEngine;
using System.Collections.Generic;

public class TrinitySpellInfo
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int Dispel { get; set; }
    public int Mechanic { get; set; }
    public int Attributes { get; set; }
    public int AttributesEx { get; set; }
    public int AttributesEx2 { get; set; }
    public int AttributesEx3 { get; set; }
    public int AttributesEx4 { get; set; }
    public int AttributesEx5 { get; set; }
    public int AttributesEx6 { get; set; }
    public int AttributesEx7 { get; set; }
    public int AttributesEx8 { get; set; }
    public int AttributesEx9 { get; set; }
    public int AttributesEx10 { get; set; }
    public int AttributesEx11 { get; set; }
    public int AttributesEx12 { get; set; }
    public int AttributesEx13 { get; set; }
    public int AttributesCu { get; set; }
    public long Stances { get; set; }
    public long StancesNot { get; set; }
    public int Targets { get; set; }
    public int TargetCreatureType { get; set; }
    public int RequiresSpellFocus { get; set; }
    public int FacingCasterFlags { get; set; }
    public int CasterAuraState { get; set; }
    public int TargetAuraState { get; set; }
    public int ExcludeCasterAuraState { get; set; }
    public int ExcludeTargetAuraState { get; set; }
    public int CasterAuraSpell { get; set; }
    public int TargetAuraSpell { get; set; }
    public int ExcludeCasterAuraSpell { get; set; }
    public int ExcludeTargetAuraSpell { get; set; }
    public SpellCastTimesEntry CastTimeEntry { get; set; }
    public int RecoveryTime { get; set; }
    public int CategoryRecoveryTime { get; set; }
    public int StartRecoveryCategory { get; set; }
    public int StartRecoveryTime { get; set; }
    public int InterruptFlags { get; set; }
    public int AuraInterruptFlags { get; set; }
    public int ChannelInterruptFlags { get; set; }
    public int ProcFlags { get; set; }
    public int ProcChance { get; set; }
    public int ProcCharges { get; set; }
    public int ProcCooldown { get; set; }
    public float ProcBasePPM { get; set; }
    public List<SpellProcsPerMinuteModEntry> ProcPPMMods { get; set; }
    public int MaxLevel { get; set; }
    public int BaseLevel { get; set; }
    public int SpellLevel { get; set; }
    public SpellDurationEntry DurationEntry { get; set; }
    public List<SpellPowerEntry> PowerCosts { get; set; }
    public int RangeIndex { get; set; }
    public SpellRangeEntry RangeEntry { get; set; }
    public float Speed { get; set; }
    public int StackAmount { get; set; }
    public int SpellIconID { get; set; }
    public int ActiveIconID { get; set; }
    public int MaxTargetLevel { get; set; }
    public int MaxAffectedTargets { get; set; }
    public int SpellFamilyName { get; set; }
    public int DmgClass { get; set; }
    public int PreventionType { get; set; }
    public int SchoolMask { get; set; }
    public int ChargeCategoryId { get; set; }
    public int ExplicitTargetMask { get; set; }
}