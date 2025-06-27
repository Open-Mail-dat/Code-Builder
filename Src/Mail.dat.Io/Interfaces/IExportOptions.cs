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
using System.Text;
using Microsoft.Extensions.Logging;

namespace Mail.dat.Io
{
	/// <summary>
	/// Defines the options for exporting data to a target file.
	/// </summary>
	/// <remarks>This interface provides properties to configure the export process, including the target file, 
	/// source file, encoding, and other related settings. Implementations of this interface are used  to supply the
	/// necessary configuration for export operations.</remarks>
	public interface IExportOptions
	{
		IMaildatFile TargetFile { get; set; }
		string TaregtVersion { get; set; }
		string SourceFile { get; set; }
		Encoding Encoding { get; set; }
		string LineTerminator { get; set; }
		ILogger<IImportOptions> Logger { get; set; }
		CancellationToken CancellationToken { get; set; }
	}
}
