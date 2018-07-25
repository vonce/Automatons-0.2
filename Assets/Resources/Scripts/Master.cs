using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum UnitTypeE { Command = 0, Factory = 1, Refinery = 2, Drone = 3, Soldier = 4, Bruiser = 5, Tank = 6 };
public enum FactoryUnitTypeE { Drone = 0, Soldier = 1, Bruiser = 2, Tank = 3 };
public enum ObjectE { AllyCommand = 0, EnemyCommand = 1, LowestHealthEnemy = 2, NearestAlly = 3, NearestEnemy = 4, Self = 5 };
public enum ConditionE { Always = 0, LessThanHealth = 1, MoreThanHealth = 2 };
public enum ActionE { Attack = 0, Move = 1, Special = 2, Aura = 3 };
public enum UnitBuildingE { Unit = 0, Building = 1 };
public enum AttackTypeE { Laser = 0, Beam = 1, Grenade = 2 };
public enum SpecialTypeE { Rocket = 0, HealBeam = 1, Emp = 2 };
public enum AuraTypeE { DamageAura = 0, HealAura = 1, AttackSpeedAura = 2, DefenseAura = 3 };


public class Master : MonoBehaviour {

}
