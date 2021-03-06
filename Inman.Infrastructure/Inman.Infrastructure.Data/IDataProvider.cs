﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Inman.Infrastructure.Data
{
    public interface IDataProvider
    {
        void InitConnectionFactory();

        void SetDatabaseInitializer();

        void InitDatabase();

        bool StoredProceduredSupported { get; }

        DbParameter GetParameter();
    }
}
