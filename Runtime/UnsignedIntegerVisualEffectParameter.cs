using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	[AddComponentMenu("Visual Effect Parameters/Unsigned Integer Visual Effect Parameter")]
	public class UnsignedIntegerVisualEffectParameter : VisualEffectParameter<uint>
	{
		protected override uint GetValue(VisualEffect effect, IReadOnlyList<int> ids)
		{
			return effect.GetUInt(ids[0]);
		}

		protected override void SetValue(VisualEffect effect, IReadOnlyList<int> ids, uint value)
		{
			effect.SetUInt(ids[0], value);
		}
	}
}
