﻿using System.Linq;
using System.Web;
using Tatum.Model;
using Tatum.Model.Requests;
using System.ComponentModel.DataAnnotations;

namespace Tatum.Model.Requests
{
    public class CeloTransferMultiTokenBatch : TransferMultiTokenBatch
    {

        [Required]
        public Currency feecurrency { get; set; }


    }
}