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
	/// Represents the options used for exporting data to a target file.
	/// </summary>
	/// <remarks>This class provides configuration settings for controlling the export process,  including the
	/// source file, target version, encoding, and other related options.</remarks>
	public class ExportOptions : IExportOptions
	{
		/// <summary>
		/// Gets or sets the path to the source file associated with the operation.
		/// </summary>
		public string SourceFile { get; set; }

		/// <summary>
		/// Gets or sets the target version of the application or component.
		/// </summary>
		public string TaregtVersion { get; set; }

		/// <summary>
		/// Gets or sets the target maildat file associated with the operation.
		/// </summary>
		/// <remarks>Ensure that the assigned value is not null and adheres to the expected implementation of <see
		/// cref="IMaildatFile"/>.</remarks>
		public IMaildatFile TargetFile { get; set; }

		/// <summary>
		/// Gets or sets the character encoding used for text operations.
		/// </summary>
		public Encoding Encoding { get; set; } = Encoding.UTF8;

		/// <summary>
		/// Gets or sets the string used to terminate lines in the output.
		/// </summary>
		/// <remarks>This property determines the sequence of characters appended to the end of each line.  It can be
		/// customized to use a specific line terminator, such as "\n" for Unix-style line endings  or "\r\n" for
		/// Windows-style line endings.</remarks>
		public string LineTerminator { get; set; } = Environment.NewLine;

		/// <summary>
		/// Gets or sets the logger used to log messages related to import options.
		/// </summary>
		public ILogger<IImportOptions> Logger { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="CancellationToken"/> used to propagate notification that operations should be
		/// canceled.
		/// </summary>
		/// <remarks>Assigning a new <see cref="CancellationToken"/> allows the caller to control the cancellation
		/// behavior of the associated operation.</remarks>
		public CancellationToken CancellationToken { get; set; }
	}
}
