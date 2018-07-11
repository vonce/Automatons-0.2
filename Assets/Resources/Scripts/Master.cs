using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public enum UnitTypeE { Command, Factory, Refinery, Drone, Soldier, Bruiser, Tank };
public enum FactoryUnitTypeE { Drone, Soldier, Bruiser, Tank };
public enum ObjectE { AllyCommand, EnemyCommand, LowestHealthEnemy, NearestAlly, NearestEnemy, Self};
public enum ConditionE { Always, LessThanHealth, MoreThanHealth };
public enum ActionE { Attack, Move, Special };
public enum UnitBuildingE { Unit, Building };
public enum AttackTypeE { Laser, Beam, Grenade };
public enum SpecialTypeE { Rocket, HealBeam, AttackSpeedAura, DefenseAura }


public class Master : MonoBehaviour {

}
