using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using System;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Graphics Buffer Visual Effect Parameter")]
	public class GraphicsBufferVisualEffectParameter : VisualEffectParameter<GraphicsBuffer>
	{
		protected override GraphicsBuffer GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			throw new NotImplementedException("Graphics buffer visual effect parameters cannot be read");
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, GraphicsBuffer value)
		{
			effect.SetGraphicsBuffer(ids[0], value);
		}
	}
}
