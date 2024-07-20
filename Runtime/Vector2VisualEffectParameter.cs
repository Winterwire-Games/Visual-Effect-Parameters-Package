using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Vector2 Visual Effect Parameter")]
	public class Vector2VisualEffectParameter : VisualEffectParameter<Vector2>
	{
		protected override Vector2 GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetVector2(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Vector2 value)
		{
			effect.SetVector2(ids[0], value);
		}
	}
}
