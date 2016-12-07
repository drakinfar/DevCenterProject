using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KDBookkeeper.Engine
{
	public enum ConsequenceType
	{
		/// <summary>
		/// automatically adds the item to the settlement
		/// </summary>
		Add = 1,
		/// <summary>
		/// automatically removes the item
		/// </summary>
		Remove = 2,
		/// <summary>
		/// Shows chart and should have no automatic consequence just a view
		/// </summary>
		Chart=3, 
	}

	/// <summary>
	/// Indicates the table to looks the consequence up on
	/// </summary>
	public enum ConsequenceObjectType
	{
		Innovation = 1,
		Location =2,
		Chart=3,
	}
}
