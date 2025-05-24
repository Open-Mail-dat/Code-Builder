// 
// Copyright (c) 2025 Open Mail.dat
// 
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
// 
// This code was auto-generated on May 23rd, 2025.
// by the Open Mail.dat Code Generator.
// 
// Author: Daniel M porrey
// Version 25.1.0.2
// 
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Mail.dat
{
	/// <summary>
	/// Provides barcode for special fees.
	/// </summary>
	[MaildatFile(Version = "25-1", Revision = "0.2", Extension = "sfb", File = "Special Barcode Record", Summary = "Barcode for special services.", Description = "Provides barcode for special fees.", LineLength = 68, ClosingCharacter = "#")]
	[Table("Sfb", Schema = "Maildat")]
	[PrimaryKey("Id")]
	public partial class Sfb : MaildatEntity
	{
		/// <summary>
		/// Job ID (SFB-1001)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1001", FieldName = "Job ID", Start = 1, Length = 8, Required = true, Key = true, DataType = "A/N", Type = "string", Format = "zfillnumeric", References = "HDR-1001")]
		[Column("JobID", Order = 2)]
		[Required]
		[MaildatKey]
		[MaxLength(8)]
		[Comment("SFB-1001")]
		public string JobID { get; set; }

		/// <summary>
		/// Piece ID (SFB-1018)
		/// Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID,
		/// right-justify in the Piece ID field and zero fill.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1018", FieldName = "Piece ID", Start = 9, Length = 22, Required = true, Key = true, DataType = "A/N", Description = "Unique ID of individual piece within a mailing. If connected to PBC, for PBC unique ID, right-justify in the Piece ID field and zero fill.", Type = "string", Format = "zfillnumeric", References = "PBC-1002")]
		[Column("PieceID", Order = 3)]
		[Required]
		[MaildatKey]
		[MaxLength(22)]
		[Comment("SFB-1018")]
		public string PieceID { get; set; }

		/// <summary>
		/// Barcode Type (SFB-1004)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1004", FieldName = "Barcode Type", Start = 31, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("BarcodeType", Order = 4)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("E", "F")]
		[Comment("SFB-1004")]
		public string BarcodeType { get; set; }

		/// <summary>
		/// Barcode (SFB-1003)
		/// IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode
		/// (IMb® or IMpb®) that has been added to the piece.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1003", FieldName = "Barcode", Start = 32, Length = 34, Required = true, Key = false, DataType = "A/N", Description = "IMpb® barcode representing extra services for a piece that bears an IMb®, or an additional barcode (IMb® or IMpb®) that has been added to the piece.", Type = "string", Format = "leftjustify")]
		[Column("Barcode", Order = 5)]
		[Required]
		[MaxLength(34)]
		[Comment("SFB-1003")]
		public string Barcode { get; set; }

		/// <summary>
		/// IMpb® Barcode Construct Code (SFB-1005)
		/// Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number
		/// is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it
		/// provides the 11 digit Zip code in the Piece Barcode field.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-1005", FieldName = "IMpb® Barcode Construct Code", Start = 66, Length = 1, Required = false, Key = false, DataType = "A/N", Description = "Populate when IMpb® is used. This code identifies which combination of ZIP, MID, and serial number is used in the IMpb. Industry has agreed that for IMpb, only PDR is the viable option because it provides the 11 digit Zip code in the Piece Barcode field.", Type = "enum", Format = "leftjustify")]
		[Column("IMpbBarcodeConstructCode", Order = 6)]
		[MaxLength(1)]
		[AllowedValues("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T")]
		[Comment("SFB-1005")]
		public string IMpbBarcodeConstructCode { get; set; }

		/// <summary>
		/// SFB Record Status (SFB-2000)
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-2000", FieldName = "SFB Record Status", Start = 67, Length = 1, Required = true, Key = false, DataType = "A/N", Type = "enum", Format = "leftjustify")]
		[Column("SFBRecordStatus", Order = 7)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("D", "I", "O", "U")]
		[Comment("SFB-2000")]
		public string SFBRecordStatus { get; set; }

		/// <summary>
		/// Closing Character (SFB-9999)
		/// Must be the # sign.
		/// </summary>
		[MaildatField(Extension = "sfb", FieldCode = "SFB-9999", FieldName = "Closing Character", Start = 68, Length = 1, Required = true, Key = false, Description = "Must be the # sign.", Type = "closing", Format = "leftjustify")]
		[Column("ClosingCharacter", Order = 8)]
		[Required]
		[MaxLength(1)]
		[AllowedValues("#")]
		[Comment("SFB-9999")]
		public string ClosingCharacter { get; set; } = "#";

		/// <summary>
		/// Sets property values from one line of an import file.
		/// </summary>
		protected override ILoadError[] OnLoadData(int fileLineNumber, byte[] line)
		{
			List<ILoadError> returnValue = [];
			
			this.FileLineNumber = fileLineNumber;
			this.JobID = line.Parse<Sfb, string>(p => p.JobID, returnValue);
			this.PieceID = line.Parse<Sfb, string>(p => p.PieceID, returnValue);
			this.BarcodeType = line.Parse<Sfb, string>(p => p.BarcodeType, returnValue);
			this.Barcode = line.Parse<Sfb, string>(p => p.Barcode, returnValue);
			this.IMpbBarcodeConstructCode = line.Parse<Sfb, string>(p => p.IMpbBarcodeConstructCode, returnValue);
			this.SFBRecordStatus = line.Parse<Sfb, string>(p => p.SFBRecordStatus, returnValue);
			this.ClosingCharacter = line.Parse<Sfb, string>(p => p.ClosingCharacter, returnValue);
			
			return returnValue.ToArray();
		}
	}
}