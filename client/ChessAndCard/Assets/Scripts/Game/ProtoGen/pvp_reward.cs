//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: pvp_reward.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_REWARD")]
  public partial class PVP_REWARD : global::ProtoBuf.IExtensible
  {
    public PVP_REWARD() {}
    
    private int _number_of_generals;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"number_of_generals", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int number_of_generals
    {
      get { return _number_of_generals; }
      set { _number_of_generals = value; }
    }
    private int _reward_ratio;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"reward_ratio", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int reward_ratio
    {
      get { return _reward_ratio; }
      set { _reward_ratio = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PVP_REWARD_ARRAY")]
  public partial class PVP_REWARD_ARRAY : global::ProtoBuf.IExtensible
  {
    public PVP_REWARD_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.PVP_REWARD> _items = new global::System.Collections.Generic.List<deploy.PVP_REWARD>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.PVP_REWARD> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}