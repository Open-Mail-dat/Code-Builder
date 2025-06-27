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
		/// <summary>
		/// Gets or sets the target Mail.dat file associated with the operation.
		/// </summary>
		IMaildatFile TargetFile { get; set; }

		/// <summary>
		/// Gets or sets the target version of the application or component.
		/// </summary>
		string TaregtVersion { get; set; }

		/// <summary>
		/// Gets or sets the path to the source file associated with the operation.
		/// </summary>
		string SourceFile { get; set; }

		/// <summary>
		/// Gets or sets the character encoding used for text operations.
		/// </summary>
		/// <remarks>The encoding must be set to a valid <see cref="System.Text.Encoding"/> instance.  Common
		/// encodings include <see cref="System.Text.Encoding.UTF8"/> and <see
		/// cref="System.Text.Encoding.Unicode"/>.</remarks>
		Encoding Encoding { get; set; }

		/// <summary>
		/// Gets or sets the string used to terminate lines in the output.
		/// </summary>
		/// <remarks>The value of this property determines how lines are separated in the output.  Common values
		/// include "\n" for Unix-style line endings or "\r\n" for Windows-style line endings.  If set to <see
		/// langword="null"/> or an empty string, no line terminator will be appended.</remarks>
		string LineTerminator { get; set; }

		/// <summary>
		/// Gets or sets the logger used to record messages and events related to import options.
		/// </summary>
		ILogger<IImportOptions> Logger { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="System.Threading.CancellationToken"/> used to signal cancellation of an operation.
		/// </summary>
		CancellationToken CancellationToken { get; set; }
	}
}
