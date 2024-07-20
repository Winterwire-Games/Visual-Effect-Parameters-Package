using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Boolean Visual Effect Parameter")]
	public class BooleanVisualEffectParameter : VisualEffectParameter<bool>
	{
		protected override bool GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetBool(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, bool value)
		{
			effect.SetBool(ids[0], value);
		}
	}
}
