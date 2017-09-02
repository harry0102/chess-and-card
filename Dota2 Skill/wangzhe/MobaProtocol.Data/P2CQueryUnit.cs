using ProtoBuf;
using System;

namespace MobaProtocol.Data
{
	[ProtoContract]
	public class P2CQueryUnit
	{
		[ProtoMember(1)]
		public int unitId
		{
			get;
			set;
		}

		[ProtoMember(2)]
		public UnitRuntimeInfo unitRuntimeInfo
		{
			get;
			set;
		}
	}
}
