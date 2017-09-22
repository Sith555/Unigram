// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Upload
{
	public partial class TLUploadCdnFileReuploadNeeded : TLUploadCdnFileBase 
	{
		public Byte[] RequestToken { get; set; }

		public TLUploadCdnFileReuploadNeeded() { }
		public TLUploadCdnFileReuploadNeeded(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadCdnFileReuploadNeeded; } }

		public override void Read(TLBinaryReader from)
		{
			RequestToken = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteByteArray(RequestToken);
		}
	}
}