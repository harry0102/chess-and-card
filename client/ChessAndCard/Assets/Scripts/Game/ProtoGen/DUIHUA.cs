//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: duihua.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DUIHUA")]
  public partial class DUIHUA : global::ProtoBuf.IExtensible
  {
    public DUIHUA() {}
    
    private int _say_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"say_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int say_id
    {
      get { return _say_id; }
      set { _say_id = value; }
    }
    private string _head = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"head", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string head
    {
      get { return _head; }
      set { _head = value; }
    }
    private int _name = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _head_location = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"head_location", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int head_location
    {
      get { return _head_location; }
      set { _head_location = value; }
    }
    private int _content = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int content
    {
      get { return _content; }
      set { _content = value; }
    }
    private int _height = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"height", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int height
    {
      get { return _height; }
      set { _height = value; }
    }
    private int _dikuang = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"dikuang", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int dikuang
    {
      get { return _dikuang; }
      set { _dikuang = value; }
    }
    private int _yaan = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"yaan", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int yaan
    {
      get { return _yaan; }
      set { _yaan = value; }
    }
    private int _dian = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"dian", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int dian
    {
      get { return _dian; }
      set { _dian = value; }
    }
    private int _anim = (int)0;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"anim", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int anim
    {
      get { return _anim; }
      set { _anim = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DUIHUA_ARRAY")]
  public partial class DUIHUA_ARRAY : global::ProtoBuf.IExtensible
  {
    public DUIHUA_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.DUIHUA> _items = new global::System.Collections.Generic.List<deploy.DUIHUA>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.DUIHUA> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}