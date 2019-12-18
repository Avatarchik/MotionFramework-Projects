﻿using System;
using System.Collections;
using System.Collections.Generic;
using MotionFramework.Network;

/// <summary>
/// Protobuf网络消息解析器
/// </summary>
public class ProtoPackageParser : DefaultPackageParser
{
	public ProtoPackageParser()
	{
		PackageSizeFieldType = EPackageSizeFieldType.UShort;
		MessageIDFieldType = EMessageIDFieldType.UShort;
	}

	protected override byte[] EncodeInternal(object msgObj)
	{
		throw new NotImplementedException();
	}

	protected override object DecodeInternal(Type classType, byte[] bodyBytes)
	{
		throw new NotImplementedException();
	}
}