//
// This file is part of Open Mail.dat.
// Copyright (c) 2025 Open Mail.dat
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
// LICENSE (GNU Lesser General Public License)
// LICENSE.GPL3 (GNU General Public License)
// LICENSE-ADDENDUM.MD (Attribution and Public Use Addendum to the GNU Lesser General Public License v3.0 (LGPL-3.0))
//
// If not, see <https://www.gnu.org/licenses/>.
// ************************************************************************************************************************
//
// Author: Daniel M porrey
//
namespace Mail.dat.Json.Specification.Models
{
	public class FileOrdering : List<FileOrder>
	{
		public FileOrdering()
		{
			this.Add(new FileOrder { Extension = "hdr", Ordinal = 1 });
			this.Add(new FileOrder { Extension = "seg", Ordinal = 2 });
			this.Add(new FileOrder { Extension = "mpu", Ordinal = 3 });
			this.Add(new FileOrder { Extension = "mcr", Ordinal = 4 });
			this.Add(new FileOrder { Extension = "mpa", Ordinal = 5 });
			this.Add(new FileOrder { Extension = "cpt", Ordinal = 6 });
			this.Add(new FileOrder { Extension = "ccr", Ordinal = 7 });
			this.Add(new FileOrder { Extension = "csm", Ordinal = 8 });
			this.Add(new FileOrder { Extension = "cqt", Ordinal = 9 });
			this.Add(new FileOrder { Extension = "pqt", Ordinal = 10 });
			this.Add(new FileOrder { Extension = "wsr", Ordinal = 11 });
			this.Add(new FileOrder { Extension = "snr", Ordinal = 12 });
			this.Add(new FileOrder { Extension = "icr", Ordinal = 13 });
			this.Add(new FileOrder { Extension = "pdr", Ordinal = 14 });
			this.Add(new FileOrder { Extension = "pbc", Ordinal = 15 });
			this.Add(new FileOrder { Extension = "sfr", Ordinal = 16 });
			this.Add(new FileOrder { Extension = "sfb", Ordinal = 17 });
			this.Add(new FileOrder { Extension = "par", Ordinal = 18 });
			this.Add(new FileOrder { Extension = "oci", Ordinal = 19 });
			this.Add(new FileOrder { Extension = "upa", Ordinal = 20 });
			this.Add(new FileOrder { Extension = "epd", Ordinal = 21 });
			this.Add(new FileOrder { Extension = "rmr", Ordinal = 22 });
			this.Add(new FileOrder { Extension = "rmb", Ordinal = 23 });
			this.Add(new FileOrder { Extension = "rms", Ordinal = 24 });
			this.Add(new FileOrder { Extension = "chr", Ordinal = 25 });
			this.Add(new FileOrder { Extension = "cbr", Ordinal = 26 });
			this.Add(new FileOrder { Extension = "cdr", Ordinal = 27 });
			this.Add(new FileOrder { Extension = "cfr", Ordinal = 28 });
		}

		public static FileOrdering List => [];
	}
}
