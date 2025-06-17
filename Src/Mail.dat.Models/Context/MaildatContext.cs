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
// This code was auto-generated on June 16th, 2025 by the Open Mail.dat Code Generator.
// Code Generator Author: Daniel M porrey
//
using Diamond.Core.Repository.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Mail.dat
{
	/// <summary>
	/// Entity Framework Core database context for Mail.dat entities.
	/// </summary>
	public partial class MaildatContext : RepositoryContext<MaildatContext> 
	{
		public  MaildatContext()
			 : base()
		{
		}

		public  MaildatContext(ILogger<MaildatContext> logger, DbContextOptions<MaildatContext> options)
			 : base(logger, options)
		{
			logger.LogDebug("Created {context}.", nameof(MaildatContext));
		}

		[MaildatExport(Order = 1)]
		public DbSet<Hdr> Hdr { get; set; }

		[MaildatExport(Order = 2)]
		public DbSet<Seg> Seg { get; set; }

		[MaildatExport(Order = 3)]
		public DbSet<Mpu> Mpu { get; set; }

		[MaildatExport(Order = 4)]
		public DbSet<Mcr> Mcr { get; set; }

		[MaildatExport(Order = 5)]
		public DbSet<Mpa> Mpa { get; set; }

		[MaildatExport(Order = 6)]
		public DbSet<Cpt> Cpt { get; set; }

		[MaildatExport(Order = 7)]
		public DbSet<Ccr> Ccr { get; set; }

		[MaildatExport(Order = 8)]
		public DbSet<Csm> Csm { get; set; }

		[MaildatExport(Order = 9)]
		public DbSet<Cqt> Cqt { get; set; }

		[MaildatExport(Order = 10)]
		public DbSet<Pqt> Pqt { get; set; }

		[MaildatExport(Order = 11)]
		public DbSet<Wsr> Wsr { get; set; }

		[MaildatExport(Order = 12)]
		public DbSet<Snr> Snr { get; set; }

		[MaildatExport(Order = 13)]
		public DbSet<Icr> Icr { get; set; }

		[MaildatExport(Order = 14)]
		public DbSet<Pdr> Pdr { get; set; }

		[MaildatExport(Order = 15)]
		public DbSet<Pbc> Pbc { get; set; }

		[MaildatExport(Order = 16)]
		public DbSet<Sfr> Sfr { get; set; }

		[MaildatExport(Order = 17)]
		public DbSet<Sfb> Sfb { get; set; }

		[MaildatExport(Order = 18)]
		public DbSet<Par> Par { get; set; }

		[MaildatExport(Order = 19)]
		public DbSet<Oci> Oci { get; set; }

		[MaildatExport(Order = 20)]
		public DbSet<Upa> Upa { get; set; }

		[MaildatExport(Order = 21)]
		public DbSet<Epd> Epd { get; set; }

		[MaildatExport(Order = 22)]
		public DbSet<Rmr> Rmr { get; set; }

		[MaildatExport(Order = 23)]
		public DbSet<Rmb> Rmb { get; set; }

		[MaildatExport(Order = 24)]
		public DbSet<Rms> Rms { get; set; }

		[MaildatExport(Order = 25)]
		public DbSet<Chr> Chr { get; set; }

		[MaildatExport(Order = 26)]
		public DbSet<Cbr> Cbr { get; set; }

		[MaildatExport(Order = 27)]
		public DbSet<Cdr> Cdr { get; set; }

		[MaildatExport(Order = 28)]
		public DbSet<Cfr> Cfr { get; set; }

		public DbSet<Error> Errors { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			this.Logger.LogDebug("OnModelCreating() called in {context}", nameof(MaildatContext));
			
			//
			// Specify the Key properties
			//
			modelBuilder.Entity<Cbr>().HasKey(t => t.Id);
			modelBuilder.Entity<Ccr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cfr>().HasKey(t => t.Id);
			modelBuilder.Entity<Chr>().HasKey(t => t.Id);
			modelBuilder.Entity<Cpt>().HasKey(t => t.Id);
			modelBuilder.Entity<Cqt>().HasKey(t => t.Id);
			modelBuilder.Entity<Csm>().HasKey(t => t.Id);
			modelBuilder.Entity<Epd>().HasKey(t => t.Id);
			modelBuilder.Entity<Hdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Icr>().HasKey(t => t.Id);
			modelBuilder.Entity<Mcr>().HasKey(t => t.Id);
			modelBuilder.Entity<Mpa>().HasKey(t => t.Id);
			modelBuilder.Entity<Mpu>().HasKey(t => t.Id);
			modelBuilder.Entity<Oci>().HasKey(t => t.Id);
			modelBuilder.Entity<Par>().HasKey(t => t.Id);
			modelBuilder.Entity<Pbc>().HasKey(t => t.Id);
			modelBuilder.Entity<Pdr>().HasKey(t => t.Id);
			modelBuilder.Entity<Pqt>().HasKey(t => t.Id);
			modelBuilder.Entity<Rmb>().HasKey(t => t.Id);
			modelBuilder.Entity<Rmr>().HasKey(t => t.Id);
			modelBuilder.Entity<Rms>().HasKey(t => t.Id);
			modelBuilder.Entity<Seg>().HasKey(t => t.Id);
			modelBuilder.Entity<Sfb>().HasKey(t => t.Id);
			modelBuilder.Entity<Sfr>().HasKey(t => t.Id);
			modelBuilder.Entity<Snr>().HasKey(t => t.Id);
			modelBuilder.Entity<Upa>().HasKey(t => t.Id);
			modelBuilder.Entity<Wsr>().HasKey(t => t.Id);
			
			//
			// Add indices for the Key properties.
			//
			modelBuilder.Entity<Cbr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Cbr>().HasIndex(t => t.CertificateOfMailingHeaderId);
			modelBuilder.Entity<Cbr>().HasIndex(t => t.BulkRecordId);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.ComponentId);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.CharacteristicType);
			modelBuilder.Entity<Ccr>().HasIndex(t => t.Characteristic);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.CertificateOfMailingHeaderId);
			modelBuilder.Entity<Cdr>().HasIndex(t => t.ComPieceId);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.CertificateOfMailingHeaderId);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.ComPieceId);
			modelBuilder.Entity<Cfr>().HasIndex(t => t.ServiceType);
			modelBuilder.Entity<Chr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Chr>().HasIndex(t => t.CertificateOfMailingHeaderId);
			modelBuilder.Entity<Cpt>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Cpt>().HasIndex(t => t.ComponentId);
			modelBuilder.Entity<Cqt>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Cqt>().HasIndex(t => t.CqtDatabaseId);
			modelBuilder.Entity<Csm>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Csm>().HasIndex(t => t.ContainerId);
			modelBuilder.Entity<Epd>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Epd>().HasIndex(t => t.PieceId);
			modelBuilder.Entity<Epd>().HasIndex(t => t.CridType);
			modelBuilder.Entity<Hdr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Hdr>().HasIndex(t => t.HeaderHistorySequenceNumber);
			modelBuilder.Entity<Icr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Icr>().HasIndex(t => t.ContainerId);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.SegmentId);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.MailPieceUnitId);
			modelBuilder.Entity<Mcr>().HasIndex(t => t.ComponentId);
			modelBuilder.Entity<Mpa>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Mpa>().HasIndex(t => t.MpaUniqueSequenceGroupingId);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.SegmentId);
			modelBuilder.Entity<Mpu>().HasIndex(t => t.MailPieceUnitId);
			modelBuilder.Entity<Oci>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Oci>().HasIndex(t => t.ContainerId);
			modelBuilder.Entity<Par>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Par>().HasIndex(t => t.SegmentId);
			modelBuilder.Entity<Par>().HasIndex(t => t.MailPieceUnitId);
			modelBuilder.Entity<Par>().HasIndex(t => t.ComponentId);
			modelBuilder.Entity<Par>().HasIndex(t => t.SequenceNumber);
			modelBuilder.Entity<Pbc>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Pbc>().HasIndex(t => t.PbcUniqueId);
			modelBuilder.Entity<Pdr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Pdr>().HasIndex(t => t.PieceId);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.CqtDatabaseId);
			modelBuilder.Entity<Pqt>().HasIndex(t => t.PackageId);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.RmsId);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.Barcode);
			modelBuilder.Entity<Rmb>().HasIndex(t => t.RmbContentType);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RmrId);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RmrIdType);
			modelBuilder.Entity<Rmr>().HasIndex(t => t.RmrContentType);
			modelBuilder.Entity<Rms>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Rms>().HasIndex(t => t.RmsId);
			modelBuilder.Entity<Seg>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Seg>().HasIndex(t => t.SegmentId);
			modelBuilder.Entity<Sfb>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Sfb>().HasIndex(t => t.PieceId);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.PieceId);
			modelBuilder.Entity<Sfr>().HasIndex(t => t.ServiceType);
			modelBuilder.Entity<Snr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Snr>().HasIndex(t => t.ContainerId);
			modelBuilder.Entity<Snr>().HasIndex(t => t.PackageId);
			modelBuilder.Entity<Snr>().HasIndex(t => t.MailPieceUnitId);
			modelBuilder.Entity<Snr>().HasIndex(t => t.SeedNameId);
			modelBuilder.Entity<Snr>().HasIndex(t => t.VersionKeyCode);
			modelBuilder.Entity<Upa>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Upa>().HasIndex(t => t.PieceId);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.JobId);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.SegmentId);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.PackageZipCode);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.PackageCRNumber);
			modelBuilder.Entity<Wsr>().HasIndex(t => t.CoPalletizationCode);
		}
	}
}