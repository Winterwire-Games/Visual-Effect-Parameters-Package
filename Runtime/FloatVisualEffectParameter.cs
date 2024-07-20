using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Float Visual Effect Parameter")]
	public class FloatVisualEffectParameter : VisualEffectParameter<float>
	{
		protected override float GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetFloat(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, float value)
		{
			effect.SetFloat(ids[0], value);
		}
	}
}
