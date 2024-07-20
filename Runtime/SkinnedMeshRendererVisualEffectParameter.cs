using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Skinned Mesh Renderer Visual Effect Parameter")]
	public class SkinnedMeshRendererVisualEffectParameter : VisualEffectParameter<SkinnedMeshRenderer>
	{
		protected override SkinnedMeshRenderer GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetSkinnedMeshRenderer(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, SkinnedMeshRenderer value)
		{
			effect.SetSkinnedMeshRenderer(ids[0], value);
		}
	}
}
