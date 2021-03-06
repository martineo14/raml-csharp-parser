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
using Raml.Parser.Raml.Model.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raml.Parser.Raml.Model
{
    [Serializable]
    public class Action
    {

        //@Key
        public ActionType Type { get; set; }

        //@Scalar
        private String Description { get; set; }

        //@Mapping
        private Dictionary<String, Header> Headers { get; set; }

        //@Mapping
        private Dictionary<String, QueryParameter> QueryParameters { get; set; }

        //@Mapping(innerHandler = MimeTypeHandler.class)
        private Dictionary<String, MimeType> Body { get; set; }

        //@Mapping(innerHandler = ResponseHandler.class)
        private Dictionary<String, Response> Responses { get; set; }

        //@Parent
        private Resource Resource { get; set; }

        //@Sequence
        private List<String> Ais { get; set; }

        //@Sequence
        private List<Protocol> Protocols { get; set; }

        //@Sequence(rule = SecurityReferenceSequenceRule.class)
        private List<SecurityReference> SecuredBy { get; set; }

        //@Mapping(rule = org.raml.parser.rule.UriParametersRule.class)
        private Dictionary<String, List<UriParameter>> BaseUriParameters { get; set; }

        public Action()
        {
        }

        //@Override
        //public override String toString()
        //{
        //    return "Action{" +
        //           "type='" + type + '\'' +
        //           ", resource=" + (resource != null ? resource.getUri() : "-") + '}';
        //}
    }
}
