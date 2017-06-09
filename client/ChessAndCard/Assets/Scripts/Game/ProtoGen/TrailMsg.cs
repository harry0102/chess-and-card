//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: TrailMsg.proto
// Note: requires additional types generated from: GuildMsg.proto

using GuildMsg;
namespace TrailMsg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2STrailChapterList")]
  public partial class C2STrailChapterList : global::ProtoBuf.IExtensible
  {
    public C2STrailChapterList() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CTrailChapterList")]
  public partial class S2CTrailChapterList : global::ProtoBuf.IExtensible
  {
    public S2CTrailChapterList() {}
    
    private readonly global::System.Collections.Generic.List<TrailChapter> _chpaterList = new global::System.Collections.Generic.List<TrailChapter>();
    [global::ProtoBuf.ProtoMember(1, Name=@"chpaterList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TrailChapter> chpaterList
    {
      get { return _chpaterList; }
    }
  
    private readonly global::System.Collections.Generic.List<TrailStage> _stageList = new global::System.Collections.Generic.List<TrailStage>();
    [global::ProtoBuf.ProtoMember(2, Name=@"stageList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<TrailStage> stageList
    {
      get { return _stageList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2STrailFightStart")]
  public partial class C2STrailFightStart : global::ProtoBuf.IExtensible
  {
    public C2STrailFightStart() {}
    
    private int _stageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int stageId
    {
      get { return _stageId; }
      set { _stageId = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _heroIds = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"heroIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> heroIds
    {
      get { return _heroIds; }
    }
  
    private int _fightVal;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"fightVal", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int fightVal
    {
      get { return _fightVal; }
      set { _fightVal = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CTrailFightStart")]
  public partial class S2CTrailFightStart : global::ProtoBuf.IExtensible
  {
    public S2CTrailFightStart() {}
    
    private long _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private readonly global::System.Collections.Generic.List<Item> _commonDropItems = new global::System.Collections.Generic.List<Item>();
    [global::ProtoBuf.ProtoMember(2, Name=@"commonDropItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Item> commonDropItems
    {
      get { return _commonDropItems; }
    }
  
    private readonly global::System.Collections.Generic.List<Item> _captionDropItems = new global::System.Collections.Generic.List<Item>();
    [global::ProtoBuf.ProtoMember(3, Name=@"captionDropItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Item> captionDropItems
    {
      get { return _captionDropItems; }
    }
  
    private readonly global::System.Collections.Generic.List<Item> _bossDropItems = new global::System.Collections.Generic.List<Item>();
    [global::ProtoBuf.ProtoMember(4, Name=@"bossDropItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Item> bossDropItems
    {
      get { return _bossDropItems; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2STrailFightEnd")]
  public partial class C2STrailFightEnd : global::ProtoBuf.IExtensible
  {
    public C2STrailFightEnd() {}
    
    private long _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private FightResultParam _resultParam;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"resultParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public FightResultParam resultParam
    {
      get { return _resultParam; }
      set { _resultParam = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CTrailFightEnd")]
  public partial class S2CTrailFightEnd : global::ProtoBuf.IExtensible
  {
    public S2CTrailFightEnd() {}
    
    private long _fightId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"fightId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long fightId
    {
      get { return _fightId; }
      set { _fightId = value; }
    }
    private FightResultType _result;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public FightResultType result
    {
      get { return _result; }
      set { _result = value; }
    }
    private DropReward _reward;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public DropReward reward
    {
      get { return _reward; }
      set { _reward = value; }
    }
    private int _star;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"C2STrialFightMopup")]
  public partial class C2STrialFightMopup : global::ProtoBuf.IExtensible
  {
    public C2STrialFightMopup() {}
    
    private int _stageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int stageId
    {
      get { return _stageId; }
      set { _stageId = value; }
    }
    private int _count;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"S2CTrialFightMopup")]
  public partial class S2CTrialFightMopup : global::ProtoBuf.IExtensible
  {
    public S2CTrialFightMopup() {}
    
    private int _stageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int stageId
    {
      get { return _stageId; }
      set { _stageId = value; }
    }
    private int _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int count
    {
      get { return _count; }
      set { _count = value; }
    }
    private readonly global::System.Collections.Generic.List<DropReward> _reward = new global::System.Collections.Generic.List<DropReward>();
    [global::ProtoBuf.ProtoMember(3, Name=@"reward", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DropReward> reward
    {
      get { return _reward; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TrailChapter")]
  public partial class TrailChapter : global::ProtoBuf.IExtensible
  {
    public TrailChapter() {}
    
    private int _chapterId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"chapterId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int chapterId
    {
      get { return _chapterId; }
      set { _chapterId = value; }
    }
    private int _isOpen;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"isOpen", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int isOpen
    {
      get { return _isOpen; }
      set { _isOpen = value; }
    }
    private int _challengeNum;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"challengeNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int challengeNum
    {
      get { return _challengeNum; }
      set { _challengeNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TrailStage")]
  public partial class TrailStage : global::ProtoBuf.IExtensible
  {
    public TrailStage() {}
    
    private int _stageId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"stageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int stageId
    {
      get { return _stageId; }
      set { _stageId = value; }
    }
    private int _star;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int star
    {
      get { return _star; }
      set { _star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}