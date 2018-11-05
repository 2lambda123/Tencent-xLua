// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: GameModel.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GameModel {

  /// <summary>Holder for reflection information generated from GameModel.proto</summary>
  public static partial class GameModelReflection {

    #region Descriptor
    /// <summary>File descriptor for GameModel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GameModelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg9HYW1lTW9kZWwucHJvdG8SCUdhbWVNb2RlbCJeCglFcXVpcENhcmQSDAoE",
            "bmFtZRgBIAEoCRIiCgR0eXBlGAIgASgOMhQuR2FtZU1vZGVsLkVxdWlwVHlw",
            "ZRIOCgZhdHRhY2sYAyABKAUSDwoHZGVmZW5jZRgEIAEoBSJGCgRIZXJvEgwK",
            "BG5hbWUYASABKAkSIQoEdHlwZRgCIAEoDjITLkdhbWVNb2RlbC5IZXJvVHlw",
            "ZRINCgVoZWFydBgDIAEoBSoiCglFcXVpcFR5cGUSCgoGU0hJRUxEEAASCQoF",
            "U1dPUkQQASoiCghIZXJvVHlwZRIKCgZLTklHSFQQABIKCgZQQVNUT1IQAWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GameModel.EquipType), typeof(global::GameModel.HeroType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GameModel.EquipCard), global::GameModel.EquipCard.Parser, new[]{ "Name", "Type", "Attack", "Defence" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GameModel.Hero), global::GameModel.Hero.Parser, new[]{ "Name", "Type", "Heart" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  ///  装备类型
  /// </summary>
  public enum EquipType {
    /// <summary>
    /// 盾牌
    /// </summary>
    [pbr::OriginalName("SHIELD")] Shield = 0,
    /// <summary>
    /// 剑
    /// </summary>
    [pbr::OriginalName("SWORD")] Sword = 1,
  }

  /// <summary>
  ///  英雄职业
  /// </summary>
  public enum HeroType {
    /// <summary>
    /// 骑士
    /// </summary>
    [pbr::OriginalName("KNIGHT")] Knight = 0,
    /// <summary>
    /// 牧师
    /// </summary>
    [pbr::OriginalName("PASTOR")] Pastor = 1,
  }

  #endregion

  #region Messages
  /// <summary>
  ///  装备卡牌
  /// </summary>
  public sealed partial class EquipCard : pb::IMessage<EquipCard> {
    private static readonly pb::MessageParser<EquipCard> _parser = new pb::MessageParser<EquipCard>(() => new EquipCard());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EquipCard> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameModel.GameModelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipCard() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipCard(EquipCard other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      attack_ = other.attack_;
      defence_ = other.defence_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EquipCard Clone() {
      return new EquipCard(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// 装备名称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::GameModel.EquipType type_ = 0;
    /// <summary>
    /// 装备类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GameModel.EquipType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "attack" field.</summary>
    public const int AttackFieldNumber = 3;
    private int attack_;
    /// <summary>
    /// 装备的攻击力
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Attack {
      get { return attack_; }
      set {
        attack_ = value;
      }
    }

    /// <summary>Field number for the "defence" field.</summary>
    public const int DefenceFieldNumber = 4;
    private int defence_;
    /// <summary>
    /// 装备的防御力
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Defence {
      get { return defence_; }
      set {
        defence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EquipCard);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EquipCard other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Attack != other.Attack) return false;
      if (Defence != other.Defence) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Attack != 0) hash ^= Attack.GetHashCode();
      if (Defence != 0) hash ^= Defence.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Attack != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Attack);
      }
      if (Defence != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Defence);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Attack != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Attack);
      }
      if (Defence != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Defence);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EquipCard other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Attack != 0) {
        Attack = other.Attack;
      }
      if (other.Defence != 0) {
        Defence = other.Defence;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            type_ = (global::GameModel.EquipType) input.ReadEnum();
            break;
          }
          case 24: {
            Attack = input.ReadInt32();
            break;
          }
          case 32: {
            Defence = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  英雄
  /// </summary>
  public sealed partial class Hero : pb::IMessage<Hero> {
    private static readonly pb::MessageParser<Hero> _parser = new pb::MessageParser<Hero>(() => new Hero());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Hero> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GameModel.GameModelReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero(Hero other) : this() {
      name_ = other.name_;
      type_ = other.type_;
      heart_ = other.heart_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Hero Clone() {
      return new Hero(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// 英雄名称
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::GameModel.HeroType type_ = 0;
    /// <summary>
    /// 英雄职业
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GameModel.HeroType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "heart" field.</summary>
    public const int HeartFieldNumber = 3;
    private int heart_;
    /// <summary>
    /// 英雄血量
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Heart {
      get { return heart_; }
      set {
        heart_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Hero);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Hero other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Type != other.Type) return false;
      if (Heart != other.Heart) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Heart != 0) hash ^= Heart.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (Heart != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Heart);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (Heart != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Heart);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Hero other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Heart != 0) {
        Heart = other.Heart;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            type_ = (global::GameModel.HeroType) input.ReadEnum();
            break;
          }
          case 24: {
            Heart = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
