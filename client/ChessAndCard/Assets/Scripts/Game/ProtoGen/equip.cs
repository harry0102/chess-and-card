//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: equip.proto
namespace deploy
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EQUIP")]
  public partial class EQUIP : global::ProtoBuf.IExtensible
  {
    public EQUIP() {}
    
    private int _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int index
    {
      get { return _index; }
      set { _index = value; }
    }
    private int _name = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int name
    {
      get { return _name; }
      set { _name = value; }
    }
    private int _desc = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"desc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int desc
    {
      get { return _desc; }
      set { _desc = value; }
    }
    private int _tuji = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"tuji", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int tuji
    {
      get { return _tuji; }
      set { _tuji = value; }
    }
    private string _icon = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"icon", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string icon
    {
      get { return _icon; }
      set { _icon = value; }
    }
    private int _equip_type = (int)0;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"equip_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int equip_type
    {
      get { return _equip_type; }
      set { _equip_type = value; }
    }
    private int _equip_order = (int)0;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"equip_order", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int equip_order
    {
      get { return _equip_order; }
      set { _equip_order = value; }
    }
    private int _equip_upId = (int)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"equip_upId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int equip_upId
    {
      get { return _equip_upId; }
      set { _equip_upId = value; }
    }
    private int _equip_up_formula_id = (int)0;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"equip_up_formula_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int equip_up_formula_id
    {
      get { return _equip_up_formula_id; }
      set { _equip_up_formula_id = value; }
    }
    private string _attribute_pool = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"attribute_pool", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string attribute_pool
    {
      get { return _attribute_pool; }
      set { _attribute_pool = value; }
    }
    private string _attribute_fumo = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"attribute_fumo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string attribute_fumo
    {
      get { return _attribute_fumo; }
      set { _attribute_fumo = value; }
    }
    private int _up_lv_max = (int)0;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"up_lv_max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int up_lv_max
    {
      get { return _up_lv_max; }
      set { _up_lv_max = value; }
    }
    private int _fm_lv_max = (int)0;
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"fm_lv_max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int fm_lv_max
    {
      get { return _fm_lv_max; }
      set { _fm_lv_max = value; }
    }
    private readonly global::System.Collections.Generic.List<deploy.EQUIP.Item> _ItemTable = new global::System.Collections.Generic.List<deploy.EQUIP.Item>();
    [global::ProtoBuf.ProtoMember(14, Name=@"ItemTable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.EQUIP.Item> ItemTable
    {
      get { return _ItemTable; }
    }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Item")]
  public partial class Item : global::ProtoBuf.IExtensible
  {
    public Item() {}
    
    private int _formula_id = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"formula_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int formula_id
    {
      get { return _formula_id; }
      set { _formula_id = value; }
    }
    private int _fm_formula = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fm_formula", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int fm_formula
    {
      get { return _fm_formula; }
      set { _fm_formula = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EQUIP_ARRAY")]
  public partial class EQUIP_ARRAY : global::ProtoBuf.IExtensible
  {
    public EQUIP_ARRAY() {}
    
    private readonly global::System.Collections.Generic.List<deploy.EQUIP> _items = new global::System.Collections.Generic.List<deploy.EQUIP>();
    [global::ProtoBuf.ProtoMember(1, Name=@"items", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<deploy.EQUIP> items
    {
      get { return _items; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}