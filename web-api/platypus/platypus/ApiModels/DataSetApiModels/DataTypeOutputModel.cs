﻿using Nssol.Platypus.Models.TenantModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nssol.Platypus.ApiModels.DataSetApiModels
{
    public class DataTypeOutputModel
    {
        public DataTypeOutputModel(DataType dataType)
        {
            this.Id = dataType.Id;
            this.Name = dataType.Name;
        }

        /// <summary>
        /// ID
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
    }
}
