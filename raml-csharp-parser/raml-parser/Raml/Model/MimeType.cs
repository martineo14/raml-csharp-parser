/*
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
using Raml.Parser.Raml.Model.Parameter;

namespace Raml.Parser.Raml.Model
{
    public class MimeType
    {

    //@Key
    public string Type {get;set;}

    //@Scalar(rule = org.raml.parser.rule.SchemaRule.class)
    public string Schema {get;set;}

    //@Scalar
    public string Example {get;set;}

    //@Mapping
    public Dictionary<String, List<FormParameter>> FormParameters {get;set;}

    public MimeType()
    {
    }

    public MimeType(String type)
    {
        this.Type = type;
    }
    public String toString()
    {
        return "MimeType{" +
               "type='" + Type + '\'' +
               '}';
    }
    }
}
