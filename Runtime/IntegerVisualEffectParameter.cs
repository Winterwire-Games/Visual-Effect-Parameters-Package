using System.Collections.Generic;
using UnityEngine.VFX;
using UnityEngine;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Integer Visual Effect Parameter")]
	public class IntegerVisualEffectParameter : VisualEffectParameter<int>
	{
		protected override int GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetInt(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, int value)
		{
			effect.SetInt(ids[0], value);
		}
	}
}
