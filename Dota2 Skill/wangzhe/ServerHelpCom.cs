using ExitGames.Client.Photon;
using MobaClient;
using System;
/// <summary>
/// ������ͨ�Ű��������࣬�����˳���ӿ�
/// </summary>
public class ServerHelpCom
{
	public virtual bool ConnectFlag
	{
		get;
		protected set;
	}

	public virtual void OnAwake()
	{
	}

	public virtual void OnStart()
	{
	}

	public virtual void OnUpdate()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void Begin()
	{
	}

	public virtual void End()
	{
	}

	public virtual void OnApplicationPause(bool isPause)
	{
	}

	public virtual void OnApplicationFocus(bool isFocus)
	{
	}

	public virtual void OnConnected(MobaConnectedType cType)
	{
	}

	public virtual void OnDisconnected(MobaDisconnectedType dType)
	{
	}

	public virtual void OnStatusChanged(StatusCode code)
	{
	}
}
