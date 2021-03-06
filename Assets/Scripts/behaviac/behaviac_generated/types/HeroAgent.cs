﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using GameFW.Core.Base;
using UnityEngine;

public class HeroAgent : SoilderAgent
{
	private bVector3 fleePos = null;
	public void _set_fleePos(bVector3 value)
	{
		fleePos = value;
	}
	public bVector3 _get_fleePos()
	{
		return fleePos;
	}

	private bVector3 retreatPos = null;
	public void _set_retreatPos(bVector3 value)
	{
		retreatPos = value;
	}
	public bVector3 _get_retreatPos()
	{
		return retreatPos;
	}
    /// <summary>
    /// 是否到达了撤退点
    /// </summary>
    /// <returns></returns>
	public bool ArrivedRetreatPos()
	{
		return Vector3.Distance(transform.position, retreatPos.UnityVec()) <= 0.5f;
	}
    /// <summary>
    /// 呼叫友方英雄治愈自己
    /// </summary>
    /// <returns></returns>
	public behaviac.EBTStatus CallFriendHeroToHealMe()
	{
        //TODO 向友方发送支援信息
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 连招
    /// </summary>
    /// <returns></returns>
	public behaviac.EBTStatus CombooKill()
	{
        //TODO 使用技能连招
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 是否有被秒杀的危险
    /// </summary>
    /// <returns></returns>
	public bool CouldBeSecKilled()
	{
        //TODO 检查周围单位的攻击力及技能连招伤害数
		return false;
	}
    /// <summary>
    /// 是否可以使用瞬发治疗
    /// </summary>
    /// <returns></returns>
	public bool CouldUseQuickHeal()
	{
        //TODO 查看是否有瞬发技能
		return false;
	}
    /// <summary>
    /// 是否可以释放缓速治疗
    /// </summary>
    /// <returns></returns>
	public bool CouldUseSlowHeal()
	{
        //TODO 查看是否有缓速治疗技能
		return false;
	}
    /// <summary>
    /// 得到当前合理的战术进攻点
    /// </summary>
    /// <returns></returns>
	public bVector3 GetCurReseanableTacticsTarget()
	{
        //TODO 检查进攻树,得到比当前战术进攻点更容易的点
		return null;
	}
    /// <summary>
    /// 得到现在离家有多远
    /// </summary>
    /// <returns></returns>
	public float GetDistanceFromHome()
	{
		return Vector3.Distance(transform.position, _get_homePoint().UnityVec());
	}
    /// <summary>
    /// 得到视野范围内的敌方单位数目
    /// </summary>
    /// <returns></returns>
	public int GetEnemyCountInRange()
	{
		return MgrCenter.EntityMgr.GetPartEntityCountInRange(Id, transform.position, EyeRange * 3, gameObject.layer, false);
	}
    /// <summary>
    /// 得到视野范围内的敌方英雄数
    /// </summary>
    /// <returns></returns>
	public int GetEnemyHeroCountInRange()
	{
		return MgrCenter.EntityMgr.GetPartHeroCountInRange(Id, transform.position, EyeRange*3, gameObject.layer, false);
	}
    /// <summary>
    /// 得到视野范围内的友方英雄数
    /// </summary>
    /// <returns></returns>
	public int GetFirendHeroCountInRange()
	{
		return MgrCenter.EntityMgr.GetPartHeroCountInRange(Id, transform.position, EyeRange*3, gameObject.layer, true);
	}
    /// <summary>
    /// 得到视野范围内的友方单位数
    /// </summary>
    /// <returns></returns>
	public int GetFriendCountInRange()
	{
		return MgrCenter.EntityMgr.GetPartEntityCountInRange(Id, transform.position, EyeRange * 3, gameObject.layer, true);
	}
    /// <summary>
    /// 找出视野范围内最弱的敌人
    /// </summary>
    /// <returns></returns>
	public FightAgent GetWeakestEnemy()
	{
        //TODO 最弱敌人算法
		return null;
	}
    /// <summary>
    /// 找出视野范围内最弱的英雄
    /// </summary>
    /// <returns></returns>
	public FightAgent GetWeakHeroInRange()
	{
        //TODO 最弱英雄算法
		return null;
	}
    /// <summary>
    /// 是否有秒杀技能
    /// </summary>
    /// <returns></returns>
	public bool HasCombooKill()
	{
        //TODO
		return false;
	}
    /// <summary>
    /// 视野内是否有敌人
    /// </summary>
    /// <returns></returns>
	public bool HasEnemyInEyeRange()
	{
		return MgrCenter.EntityMgr.GetNearestEnemy(Id, transform.position, EyeRange, gameObject.layer) != null;
	}
    /// <summary>
    /// 是否有回城技能
    /// </summary>
    /// <returns></returns>
	public bool HasReturnHomeSkill()
	{
        //TODO 检查是否有回城技能
		return false;
	}
    /// <summary>
    /// 视野范围内是否有宝物
    /// </summary>
    /// <returns></returns>
	public bool HasTreasureInEyeRange()
	{
        //TODO 加入Treasure
		return false;
	}

    #region 敌人是否在追

    /// <summary>
    /// 敌人是否在追自己
    /// </summary>
    /// <returns></returns>
    public bool IsEnemyChasing()
	{
        //TODO 看敌人的距离是否缩小了
		return false;
	}

#endregion
    /// <summary>
    /// 是否在拾取范围内
    /// </summary>
    /// <param name="treasure"></param>
    /// <returns></returns>
    public bool IsInLootRange(FightAgent treasure)
	{
		return Vector3.Distance(treasure._get_position().UnityVec(), transform.position) <= 5f;
	}
    /// <summary>
    /// 拾取宝物
    /// </summary>
    /// <param name="treasure"></param>
    /// <returns></returns>
	public behaviac.EBTStatus LootTreasure(FightAgent treasure)
	{
        //TODO 发送拾取宝物消息，拾取宝物
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 瞬发治疗
    /// </summary>
    /// <returns></returns>
	public behaviac.EBTStatus QuickHeal()
	{
        //TODO 释放瞬发治疗法术
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 设置一个撤退点
    /// </summary>
    /// <param name="retreatPosition"></param>
	public void SetRetreatPos(bVector3 retreatPosition)
	{
        _set_retreatPos(retreatPosition);
	}
    /// <summary>
    /// 回城技能
    /// </summary>
    /// <returns></returns>
	public behaviac.EBTStatus SkillReturnHome()
	{
        //TODO 释放回城技能
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 缓速治疗自己
    /// </summary>
    /// <returns></returns>
	public behaviac.EBTStatus SlowHealSelf()
	{
        //TODO 释放缓速治疗法术
		return behaviac.EBTStatus.BT_INVALID;
	}
    /// <summary>
    /// 是否到达了战略进攻点
    /// </summary>
    /// <returns></returns>
	public bool TestArrivedTacticsTarget()
	{
		return Vector3.Distance(_get_curTacticAtkPos().UnityVec(), transform.position) <= 0.5f;
	}
    /// <summary>
    /// 得到当前的局势分析(上风、下风、分不出)
    /// </summary>
    /// <returns></returns>
	public Situation TestCurSituation()
	{
        //TODO 分析局势算法
		return Situation.CantTell;
	}
    /// <summary>
    /// 附近是否有友方英雄可以治愈自己
    /// </summary>
    /// <returns></returns>
	public bool TestFriendHeroCouldHealMe()
	{
		return false;
	}
    /// <summary>
    /// 是否还有未进攻的战术进攻点
    /// </summary>
    /// <returns></returns>
	public bool TestHasTacticsTargetLeft()
	{
        //查询进攻树，看是否有剩余的战术进攻点
		return false;
	}
    /// <summary>
    /// 在视野范围内是否有可以杀死的敌方英雄
    /// </summary>
    /// <returns></returns>
	public bool TestSomeEnemyHeroCouldBeKilled()
	{
        //TODO 1.得到最弱英雄 2.看他的血量是否能秒杀
		return false;
	}
}


