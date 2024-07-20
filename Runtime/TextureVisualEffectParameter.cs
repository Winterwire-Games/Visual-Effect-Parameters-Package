using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Texture Visual Effect Parameter")]
	public class TextureVisualEffectParameter : VisualEffectParameter<Texture>
	{
		protected override Texture GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetTexture(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, Texture value)
		{
			effect.SetTexture(ids[0], value);
		}
	}
}
