using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Matrix4x4 Visual Effect Parameter")]
	public class Matrix4x4VisualEffectParameter : VisualEffectParameter<Matrix4x4>
	{
		protected override Matrix4x4 GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetMatrix4x4(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Matrix4x4 value)
		{
			effect.SetMatrix4x4(ids[0], value);
		}
	}
}
