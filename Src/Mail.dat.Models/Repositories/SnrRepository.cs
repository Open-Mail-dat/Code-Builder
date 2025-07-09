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
// This code was auto-generated on July 8th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Diamond.Core.Repository;
using Diamond.Core.Repository.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mail.dat
{
	/// <summary>
	/// Repository for the <see cref="Snr"/> entity.
	/// </summary>
	[MaildatVersions("23-1", "24-1", "25-1")]
	public partial class SnrRepository : EntityFrameworkRepository<ISnr, Snr, MaildatContext> 
	{
		/// <summary>
		/// Creates and instance of the <see cref="SnrRepository"/> class with the specified context and entity
		/// factory.
		/// </summary>
		public SnrRepository(MaildatContext context, IEntityFactory<ISnr> entityFactory)
			 : base(context, entityFactory)
		{
		}

		/// <summary>
		/// Returns the DbSet for the <see cref="Snr"/> entity.
		/// </summary>
		protected override DbSet<Snr> MyDbSet(MaildatContext context) => context.Snr;
	}
}