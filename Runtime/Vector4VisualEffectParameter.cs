using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Vector4 Visual Effect Parameter")]
	public class Vector4VisualEffectParameter : VisualEffectParameter<Vector4>
	{
		protected override Vector4 GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetVector4(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Vector4 value)
		{
			effect.SetVector4(ids[0], value);
		}
	}
}
