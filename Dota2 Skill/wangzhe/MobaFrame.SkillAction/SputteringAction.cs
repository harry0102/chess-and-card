using System;

namespace MobaFrame.SkillAction
{
	public class SputteringAction : BaseHighEffAction
	{
		protected override void doStartHighEffect_Perform()
		{
			if (this.performIds != null)
			{
				for (int i = 0; i < this.performIds.Length; i++)
				{
					if (this.targetUnits != null && this.targetUnits.Count > 0)
					{
						SkillDataKey skill_key = new SkillDataKey(this.skillId, 1, 0);
						ActionManager.PlayPerformMustntLive(skill_key, this.performIds[i], this.targetUnits[0], this.targetUnits, null, true, this, base.unit);
					}
				}
			}
		}

		protected override void doStartHighEffect_Damage()
		{
		}

		public override void DoDamage(Units target, int count = 1)
		{
			if (this.data.damage_ids != null && target != null && target.dataChange != null)
			{
				target.dataChange.doSkillWoundAction(this.data.damage_ids, base.unit, true, new float[]
				{
					(float)count
				});
			}
		}
	}
}
