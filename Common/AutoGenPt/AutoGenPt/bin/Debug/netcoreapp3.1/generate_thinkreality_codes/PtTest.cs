//Template auto generator:[AutoGenPt] v1.0
//Creation time:2021/6/30 11:58:47
using System;
using System.Collections;
using System.Collections.Generic;
namespace Lenovo.XR.Development.Net.Pt
{
public class PtTest
{
    public byte __tag__ { get;private set;}

	public uint EntityId{ get;private set;}
	public byte TeamId{ get;private set;}
	public string NickName{ get;private set;}
	public ClassA CA{ get;private set;}
	public List<PtTest> lists{ get;private set;}
	   
    public PtTest SetEntityId(uint value){EntityId=value; __tag__|=1; return this;}
	public PtTest SetTeamId(byte value){TeamId=value; __tag__|=2; return this;}
	public PtTest SetNickName(string value){NickName=value; __tag__|=4; return this;}
	public PtTest SetCA(ClassA value){CA=value; __tag__|=8; return this;}
	public PtTest Setlists(List<PtTest> value){lists=value; __tag__|=16; return this;}
	
    public bool HasEntityId(){return (__tag__&1)==1;}
	public bool HasTeamId(){return (__tag__&2)==2;}
	public bool HasNickName(){return (__tag__&4)==4;}
	public bool HasCA(){return (__tag__&8)==8;}
	public bool Haslists(){return (__tag__&16)==16;}
	
    public static byte[] Write(PtTest data)
    {
        using(ByteBuffer buffer = new ByteBuffer())
        {
            buffer.WriteByte(data.__tag__);
			if(data.HasEntityId())buffer.WriteUInt32(data.EntityId);
			if(data.HasTeamId())buffer.WriteByte(data.TeamId);
			if(data.HasNickName())buffer.WriteString(data.NickName);
			if(data.HasCA())buffer.WriteBytes(ClassA.Write(data.CA));
			if(data.Haslists())buffer.WriteCollection(data.lists,element=>PtTest.Write(element));
			
            return buffer.Getbuffer();
        }
    }

    public static PtTest Read(byte[] bytes)
    {
        using(ByteBuffer buffer = new ByteBuffer(bytes))
        {
            PtTest data = new PtTest();
            data.__tag__ = buffer.ReadByte();
			if(data.HasEntityId())data.EntityId = buffer.ReadUInt32();
			if(data.HasTeamId())data.TeamId = buffer.ReadByte();
			if(data.HasNickName())data.NickName = buffer.ReadString();
			if(data.HasCA())data.CA = ClassA.Read(buffer.ReadBytes());
			if(data.Haslists())data.lists = buffer.ReadCollection(retbytes=>PtTest.Read(retbytes));
			
            return data;
        }       
    }
}
}
