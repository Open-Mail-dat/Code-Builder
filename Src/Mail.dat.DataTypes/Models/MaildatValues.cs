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
	/// Represents a list of values that are valid for a given field.
	/// </summary>
	public abstract class MaildatValues : List<MaildatValue>
	{
		public MaildatValues()
		{
			this.OnInitializeValues();
		}

		public string FileExtension => this.OnGetFile();
		public string FieldCode => this.OnGetFieldCode();

		public IEnumerable<MaildatValue> this[string version]
		{
			get
			{
				return this.Where(t => t.Version == version);
			}
		}

		protected virtual void OnInitializeValues()
		{
		}

		protected virtual string OnGetFile()
		{
			throw new NotImplementedException();
		}

		protected virtual string OnGetFieldCode()
		{
			throw new NotImplementedException();
		}
	}
}