using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Mesh Visual Effect Parameter")]
	public class MeshVisualEffectParameter : VisualEffectParameter<Mesh>
	{
		protected override Mesh GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetMesh(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Mesh value)
		{
			effect.SetMesh(ids[0], value);
		}
	}
}
