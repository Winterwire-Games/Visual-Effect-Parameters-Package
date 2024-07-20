using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

namespace WiniterwireGames.VisualEffectParameters
{
	public abstract class VisualEffectParameter<ValueType> : MonoBehaviour
	{
		#region Visual Effect
		[SerializeField]
		private VisualEffect _visualEffect;
		public virtual VisualEffect FindVisualEffect() => this.GetComponentInParent<VisualEffect>();
		public VisualEffect VisualEffect
		{
			get 
			{
				if (this._visualEffect == null)
					this._visualEffect = this.FindVisualEffect();
				return this._visualEffect; 
			}
			set => this._visualEffect = value;
		}
		#endregion

		#region Parameter Names
		[SerializeField]
		[Tooltip("The name of the parameter")]
		private string _parameterName;
		public string ParameterName
		{
			get => this._parameterName;
			set
			{
				this._parameterName = value;
				this.UpdateIds();
			}
		}

		protected virtual IEnumerable<string> GetParameterNames(string parameter_name)
		{
			yield return parameter_name;
		}
		#endregion

		#region Parameter Ids
		private IReadOnlyList<int> _parameterIds;
		public IReadOnlyList<int> ParameterIds 
		{ 
			get
			{
				if (this._parameterIds == null)
					this.UpdateIds();
				return this._parameterIds;
			}
			private set => this._parameterIds = value;
		}

		public void UpdateIds()
		{
			List<int> ids = new();
			foreach (var parameter_name in this.GetParameterNames(this.ParameterName))
				ids.Add(Shader.PropertyToID(parameter_name));
			this.ParameterIds = ids;
		}
		#endregion

		#region Value
		protected abstract ValueType GetValue(VisualEffect effect, IReadOnlyList<int> ids);

		protected abstract void SetValue(VisualEffect effect, IReadOnlyList<int> ids, ValueType value);

		public ValueType Value
		{
			get => this.GetValue(this.VisualEffect, this.ParameterIds);
			set => this.SetValue(this.VisualEffect, this.ParameterIds, value);
		}
		#endregion

		#region Unity Messages
		private void OnValidate()
		{
			this.UpdateIds();
		}
		#endregion
	}
}
