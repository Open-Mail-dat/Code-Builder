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
using Microsoft.Extensions.DependencyInjection;

namespace Mail.dat
{
	public static class ModelExtensions
	{
		/// <summary>
		/// Adds the Open Mail.dat services to the specified service collection.
		/// </summary>
		public static IServiceCollection AddOpenMaildatModels(this IServiceCollection services)
		{
			//
			// Hdr
			//
			services.AddTransient<IEntityFactory<IHdr>, EntityFactory<IHdr, Hdr>>();
			services.AddTransient<IRepository<IHdr>, HdrRepository>();
			
			//
			// Seg
			//
			services.AddTransient<IEntityFactory<ISeg>, EntityFactory<ISeg, Seg>>();
			services.AddTransient<IRepository<ISeg>, SegRepository>();
			
			//
			// Mpu
			//
			services.AddTransient<IEntityFactory<IMpu>, EntityFactory<IMpu, Mpu>>();
			services.AddTransient<IRepository<IMpu>, MpuRepository>();
			
			//
			// Mcr
			//
			services.AddTransient<IEntityFactory<IMcr>, EntityFactory<IMcr, Mcr>>();
			services.AddTransient<IRepository<IMcr>, McrRepository>();
			
			//
			// Mpa
			//
			services.AddTransient<IEntityFactory<IMpa>, EntityFactory<IMpa, Mpa>>();
			services.AddTransient<IRepository<IMpa>, MpaRepository>();
			
			//
			// Cpt
			//
			services.AddTransient<IEntityFactory<ICpt>, EntityFactory<ICpt, Cpt>>();
			services.AddTransient<IRepository<ICpt>, CptRepository>();
			
			//
			// Ccr
			//
			services.AddTransient<IEntityFactory<ICcr>, EntityFactory<ICcr, Ccr>>();
			services.AddTransient<IRepository<ICcr>, CcrRepository>();
			
			//
			// Csm
			//
			services.AddTransient<IEntityFactory<ICsm>, EntityFactory<ICsm, Csm>>();
			services.AddTransient<IRepository<ICsm>, CsmRepository>();
			
			//
			// Cqt
			//
			services.AddTransient<IEntityFactory<ICqt>, EntityFactory<ICqt, Cqt>>();
			services.AddTransient<IRepository<ICqt>, CqtRepository>();
			
			//
			// Pqt
			//
			services.AddTransient<IEntityFactory<IPqt>, EntityFactory<IPqt, Pqt>>();
			services.AddTransient<IRepository<IPqt>, PqtRepository>();
			
			//
			// Wsr
			//
			services.AddTransient<IEntityFactory<IWsr>, EntityFactory<IWsr, Wsr>>();
			services.AddTransient<IRepository<IWsr>, WsrRepository>();
			
			//
			// Snr
			//
			services.AddTransient<IEntityFactory<ISnr>, EntityFactory<ISnr, Snr>>();
			services.AddTransient<IRepository<ISnr>, SnrRepository>();
			
			//
			// Icr
			//
			services.AddTransient<IEntityFactory<IIcr>, EntityFactory<IIcr, Icr>>();
			services.AddTransient<IRepository<IIcr>, IcrRepository>();
			
			//
			// Pdr
			//
			services.AddTransient<IEntityFactory<IPdr>, EntityFactory<IPdr, Pdr>>();
			services.AddTransient<IRepository<IPdr>, PdrRepository>();
			
			//
			// Pbc
			//
			services.AddTransient<IEntityFactory<IPbc>, EntityFactory<IPbc, Pbc>>();
			services.AddTransient<IRepository<IPbc>, PbcRepository>();
			
			//
			// Sfr
			//
			services.AddTransient<IEntityFactory<ISfr>, EntityFactory<ISfr, Sfr>>();
			services.AddTransient<IRepository<ISfr>, SfrRepository>();
			
			//
			// Sfb
			//
			services.AddTransient<IEntityFactory<ISfb>, EntityFactory<ISfb, Sfb>>();
			services.AddTransient<IRepository<ISfb>, SfbRepository>();
			
			//
			// Par
			//
			services.AddTransient<IEntityFactory<IPar>, EntityFactory<IPar, Par>>();
			services.AddTransient<IRepository<IPar>, ParRepository>();
			
			//
			// Oci
			//
			services.AddTransient<IEntityFactory<IOci>, EntityFactory<IOci, Oci>>();
			services.AddTransient<IRepository<IOci>, OciRepository>();
			
			//
			// Upa
			//
			services.AddTransient<IEntityFactory<IUpa>, EntityFactory<IUpa, Upa>>();
			services.AddTransient<IRepository<IUpa>, UpaRepository>();
			
			//
			// Epd
			//
			services.AddTransient<IEntityFactory<IEpd>, EntityFactory<IEpd, Epd>>();
			services.AddTransient<IRepository<IEpd>, EpdRepository>();
			
			//
			// Rmr
			//
			services.AddTransient<IEntityFactory<IRmr>, EntityFactory<IRmr, Rmr>>();
			services.AddTransient<IRepository<IRmr>, RmrRepository>();
			
			//
			// Rmb
			//
			services.AddTransient<IEntityFactory<IRmb>, EntityFactory<IRmb, Rmb>>();
			services.AddTransient<IRepository<IRmb>, RmbRepository>();
			
			//
			// Rms
			//
			services.AddTransient<IEntityFactory<IRms>, EntityFactory<IRms, Rms>>();
			services.AddTransient<IRepository<IRms>, RmsRepository>();
			
			//
			// Chr
			//
			services.AddTransient<IEntityFactory<IChr>, EntityFactory<IChr, Chr>>();
			services.AddTransient<IRepository<IChr>, ChrRepository>();
			
			//
			// Cbr
			//
			services.AddTransient<IEntityFactory<ICbr>, EntityFactory<ICbr, Cbr>>();
			services.AddTransient<IRepository<ICbr>, CbrRepository>();
			
			//
			// Cdr
			//
			services.AddTransient<IEntityFactory<ICdr>, EntityFactory<ICdr, Cdr>>();
			services.AddTransient<IRepository<ICdr>, CdrRepository>();
			
			//
			// Cfr
			//
			services.AddTransient<IEntityFactory<ICfr>, EntityFactory<ICfr, Cfr>>();
			services.AddTransient<IRepository<ICfr>, CfrRepository>();
			
			//
			// Tsr
			//
			services.AddTransient<IEntityFactory<ITsr>, EntityFactory<ITsr, Tsr>>();
			services.AddTransient<IRepository<ITsr>, TsrRepository>();
			
			return services;
		}
	}
}