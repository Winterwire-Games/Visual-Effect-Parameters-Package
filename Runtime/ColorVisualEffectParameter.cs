using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Color Visual Effect Parameter")]
	public class ColorVisualEffectParameter : VisualEffectParameter<Color>
	{
		protected override Color GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetVector4(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Color value)
		{
			effect.SetVector4(ids[0], value);
		}
	}
}
