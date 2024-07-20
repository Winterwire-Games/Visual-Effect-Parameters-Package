using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Gradient Visual Effect Parameter")]
	public class GradientVisualEffectParameter : VisualEffectParameter<Gradient>
	{
		protected override Gradient GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetGradient(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Gradient value)
		{
			effect.SetGradient(ids[0], value);
		}
	}
}
