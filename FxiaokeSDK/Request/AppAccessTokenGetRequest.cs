﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxiaokeSDK.Request
{
    public class AppAccessTokenGetRequest
    {
        public string AppId => FxiaokeConfig.AppId;

        public string AppSecret => FxiaokeConfig.AppSecret;
    }
}
