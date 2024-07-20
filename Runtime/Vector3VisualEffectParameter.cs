using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Vector3 Visual Efect Parameter")]
	public class Vector3VisualEffectParameter : VisualEffectParameter<Vector3>
	{
		protected override Vector3 GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetVector3(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Vector3 value)
		{
			effect.SetVector3(ids[0], value);
		}
	}
}
