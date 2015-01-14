﻿/*
 * Copyright 2015 (c) Sergio Martin Pueyo.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raml.Parser.Raml.Model
{
    [Serializable]
    public class SecurityScheme
    {

    //@Scalar
    public string description {get;set;}

    //@Scalar
    public string type {get;set;}

    //@Scalar
    public SecuritySchemeDescriptor describedBy {get;set;}

    //@Scalar
    public SecuritySettings settings { get; set; }

    }
}