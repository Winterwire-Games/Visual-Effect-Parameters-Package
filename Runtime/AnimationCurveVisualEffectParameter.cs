using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Animation Curve Visual Effect Parameter")]
	public class AnimationCurveVisualEffectParameter : VisualEffectParameter<AnimationCurve>
	{
		protected override AnimationCurve GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetAnimationCurve(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, AnimationCurve value)
		{
			effect.SetAnimationCurve(ids[0], value);
		}
	}
}
