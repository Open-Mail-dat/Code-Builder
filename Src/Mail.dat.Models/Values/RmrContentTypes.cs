//
// Copyright (c) 2025 Open Mail.dat
//
// This source code is licensed under the MIT license found in the LICENSE file in the root directory of this source tree.
//
// This code was auto-generated on June 14th, 2025.
// by the Open Mail.dat Code Generator.
//
// Author: Daniel M porrey
//
using Mail.dat.Abstractions;

namespace Mail.dat
{
	/// <summary>
	/// These are the allowed values for the property RmrContentType (RMR-1004).
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	[MaildatFieldLink(File = "rmr", FieldCode = "RMR-1004")]
	public class RmrContentTypes : MaildatValues 
	{

		/// <summary>
		/// Returns the Mail.dat file this set of values is lined to.
		/// </summary>
		protected override string OnGetFieldCode()
		{
			return "rmr";
		}

		/// <summary>
		/// Returns the field code that this set of values is linked to.
		/// </summary>
		protected override string OnGetFile()
		{
			return "RMR-1004";
		}

		/// <summary>
		/// Initializes the values.
		/// </summary>
		protected override void OnInitializeValues()
		{
			this.Add(new MaildatValue() { Version = "23-1", Key = "A", FileExtension = "rmr", Description = "Content Type A - Ride-Along Image URL (URL for the image source location, This image is displayed along with the mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "A", FileExtension = "rmr", Description = "Content Type A - Ride-Along Image URL (URL for the image source location, This image is displayed along with the mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "A", FileExtension = "rmr", Description = "Content Type A - Ride-Along Image URL (URL for the image source location, This image is displayed along with the mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "B", FileExtension = "rmr", Description = "Content Type B - Ride-Along Image Target URL (URL for marketing material/page for consumers).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "B", FileExtension = "rmr", Description = "Content Type B - Ride-Along Image Target URL (URL for marketing material/page for consumers).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "B", FileExtension = "rmr", Description = "Content Type B - Ride-Along Image Target URL (URL for marketing material/page for consumers).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "23-1", Key = "C", FileExtension = "rmr", Description = "Content Type C - Replacement Image URL (URL for the image source location. This image is displayed instead of the scanned mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "24-1", Key = "C", FileExtension = "rmr", Description = "Content Type C - Replacement Image URL (URL for the image source location. This image is displayed instead of the scanned mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
			this.Add(new MaildatValue() { Version = "25-1", Key = "C", FileExtension = "rmr", Description = "Content Type C - Replacement Image URL (URL for the image source location. This image is displayed instead of the scanned mailpiece image).", FieldCode = "RMR-1004", FieldName = "RmrContentType" });
		}
	}
}