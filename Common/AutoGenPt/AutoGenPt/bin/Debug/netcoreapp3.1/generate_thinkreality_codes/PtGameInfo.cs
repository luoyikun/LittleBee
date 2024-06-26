//Template auto generator:[AutoGenPt] v1.0
//Creation time:2021/6/30 11:58:47
using System;
using System.Collections;
using System.Collections.Generic;
namespace Lenovo.XR.Development.Net.Pt
{
public class PtGameInfo
{
    public byte __tag__ { get;private set;}

	public uint MapId{ get;private set;}
	public uint RoomId{ get;private set;}
	public List<PtEntity> EntityList{ get;private set;}
	   
    public PtGameInfo SetMapId(uint value){MapId=value; __tag__|=1; return this;}
	public PtGameInfo SetRoomId(uint value){RoomId=value; __tag__|=2; return this;}
	public PtGameInfo SetEntityList(List<PtEntity> value){EntityList=value; __tag__|=4; return this;}
	
    public bool HasMapId(){return (__tag__&1)==1;}
	public bool HasRoomId(){return (__tag__&2)==2;}
	public bool HasEntityList(){return (__tag__&4)==4;}
	
    public static byte[] Write(PtGameInfo data)
    {
        using(ByteBuffer buffer = new ByteBuffer())
        {
            buffer.WriteByte(data.__tag__);
			if(data.HasMapId())buffer.WriteUInt32(data.MapId);
			if(data.HasRoomId())buffer.WriteUInt32(data.RoomId);
			if(data.HasEntityList())buffer.WriteCollection(data.EntityList,element=>PtEntity.Write(element));
			
            return buffer.Getbuffer();
        }
    }

    public static PtGameInfo Read(byte[] bytes)
    {
        using(ByteBuffer buffer = new ByteBuffer(bytes))
        {
            PtGameInfo data = new PtGameInfo();
            data.__tag__ = buffer.ReadByte();
			if(data.HasMapId())data.MapId = buffer.ReadUInt32();
			if(data.HasRoomId())data.RoomId = buffer.ReadUInt32();
			if(data.HasEntityList())data.EntityList = buffer.ReadCollection(retbytes=>PtEntity.Read(retbytes));
			
            return data;
        }       
    }
}
}
