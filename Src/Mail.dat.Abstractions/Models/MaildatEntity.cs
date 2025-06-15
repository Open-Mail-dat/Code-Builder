//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat. All rights reserved.
//
// ************************************************************************************************************************
// License Agreement:
//
// Open Mail.dat is free software: you can redistribute it and/or modify it under the terms of the
// GNU LESSER GENERAL PUBLIC LICENSE as published by the Free Software Foundation, either version 3
// of the License, or (at your option) any later version.
// Open Mail.dat is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU LESSER GENERAL PUBLIC LICENSE for more details.
// You should have received three files as part of the license agreemen for Open Mail.dat.
//
// LICENSE.md (GNU Lesser General Public License)
// LICENSE-GPL3.md (GNU General Public License)
// LICENSE-ADDENDUM.md (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Diamond.Core.Repository;

namespace Mail.dat
{
	public abstract class MaildatEntity : Entity, IMaildatEntity
	{
		/// <summary>
		/// The unique identifier for the record.
		/// </summary>
		[Key]
		[Column("Id", Order = 0)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Column("FileLineNumber", Order = 1)]
		public int FileLineNumber { get; set; }

		public virtual Task<ILoadError[]> ImportDataAsync(string version,int lineNumber, ReadOnlySpan<byte> line)
		{
			return this.OnImportDataAsync(version, lineNumber, line);
		}

		public virtual Task<string> ExportDataAsync(string version)
		{
			return this.OnExportDataAsync(version);
		}

		protected virtual Task<ILoadError[]> OnImportDataAsync(string version, int lineNumber, ReadOnlySpan<byte> line)
		{
			return Task.FromResult<ILoadError[]>([]);
		}

		protected virtual Task<string> OnExportDataAsync(string version)
		{
			return Task.FromResult<string>(null);
		}
	}
}
